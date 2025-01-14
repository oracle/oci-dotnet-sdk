/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Moq;
using Moq.Protected;
using Xunit;
using Oci.Common.Auth.Internal;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Oci.Common.Http.Internal;
using Oci.Common.Http.Signing;
using Oci.Common.Model;
using Newtonsoft.Json;
using Polly.Utilities;
using Polly.CircuitBreaker;
using NLog;

namespace Oci.Common.Auth
{
    [ExcludeFromCodeCoverage]
    public class X509FederationClientTests : BaseTest
    {

        private X509FederationClient x509FederationClient;
        private readonly Mock<RsaKeyParameters> rsaKeyParamMock;
        private readonly Mock<IFederationRequestSigner> signerMock;
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public X509FederationClientTests()
        {
            var leafCertificateSupplier = new Mock<IX509CertificateSupplier>();
            var certificateKeyPair = new CertificateAndPrivateKeyPair();
            certificateKeyPair.Certificate = new X509Certificate2("cacert.pem");
            rsaKeyParamMock = new Mock<RsaKeyParameters>(true, new BigInteger("1"), new BigInteger("2"));
            certificateKeyPair.PrivateKey = rsaKeyParamMock.Object;

            leafCertificateSupplier.Setup(p => p.Refresh());
            leafCertificateSupplier.Setup(p => p.GetCertificateAndKeyPair()).Returns(certificateKeyPair);

            var intermediateCertificateSuppliers = new Mock<HashSet<IX509CertificateSupplier>>();
            var certificate = new Mock<IX509CertificateSupplier>();
            certificate.Setup(p => p.Refresh());
            intermediateCertificateSuppliers.Object.Add(certificate.Object);

            signerMock = new Mock<IFederationRequestSigner>();
            signerMock.Setup(s => s.SignRequest(It.IsAny<HttpRequestMessage>(), It.IsAny<RsaKeyParameters>(), It.IsAny<string>()));

            x509FederationClient = new X509FederationClient("https://auth.us-phoenix-1.oraclecloud.com", "",
                    leafCertificateSupplier.Object,
                    new SessionKey(),
                    intermediateCertificateSuppliers.Object,
                    "test",
                    signerMock.Object);


        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void GetSecurityToken()
        {
            var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";
            var actualJwtToken = $"{{'token': '{token}'}}";
            var expectedJwtToken = token;

            var handlerMock = new Mock<HttpMessageHandler>();
            var response = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(actualJwtToken),
            };

            handlerMock
               .Protected()
               .Setup<Task<HttpResponseMessage>>(
                  "SendAsync",
                  ItExpr.IsAny<HttpRequestMessage>(),
                  ItExpr.IsAny<CancellationToken>())
               .ReturnsAsync(response);

            x509FederationClient.Client = new HttpClient(handlerMock.Object);
            Assert.Equal(expectedJwtToken, x509FederationClient.GetSecurityToken());
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void GetSecurityTokenNoRetryOn4xx()
        {
            var handlerMock = new Mock<HttpMessageHandler>();
            var response = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.Unauthorized,
            };

            handlerMock
               .Protected()
               .Setup<Task<HttpResponseMessage>>(
                  "SendAsync",
                  ItExpr.IsAny<HttpRequestMessage>(),
                  ItExpr.IsAny<CancellationToken>())
               .ReturnsAsync(response);

            // Assert that 401 is returned as the final error as an OCI Exception
            x509FederationClient.Client = new HttpClient(handlerMock.Object);
            var exception = Assert.Throws<OciException>(() => x509FederationClient.GetSecurityToken());
            Assert.Equal(HttpStatusCode.Unauthorized, exception.StatusCode);

            // Assert that the call was only retried once
            handlerMock.Protected().Verify(
                "SendAsync",
                Times.Once(), // Check that SendAsync was called exactly once
                ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>()
            );
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void GetSecurityTokenSuccessAfterRetry()
        {
            // Mock the SystemClock.SleepAsync to avoid actual delay
            var sleepCallCount = 0;
            SystemClock.SleepAsync = (_, _) =>
            {
                sleepCallCount++;
                return Task.CompletedTask; // Immediately complete the sleep
            };

            var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";
            var actualJwtToken = $"{{'token': '{token}'}}";
            var expectedJwtToken = token;

            // Mock HttpMessageHandler
            var callCount = 0;
            var handlerMock = new Mock<HttpMessageHandler>();
            var successResponse = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(actualJwtToken),
            };
            var badGateWayResponse = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.BadGateway,
                Content = ContentHelper.CreateHttpContent(new ErrorCodeAndMessage("BadGateway", "Some Error"))
            };
            var serviceUnavailableResponse = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.ServiceUnavailable,
                Content = ContentHelper.CreateHttpContent(new ErrorCodeAndMessage("ServiceUnavailable", "Some Error"))
            };

            handlerMock
               .Protected()
               .Setup<Task<HttpResponseMessage>>(
                  "SendAsync",
                  ItExpr.IsAny<HttpRequestMessage>(),
                  ItExpr.IsAny<CancellationToken>())
               .ReturnsAsync(() =>
               {
                   callCount++;
                   if (callCount == 1)
                   {
                       return badGateWayResponse;
                   }
                   if (callCount == 2)
                   {
                       return serviceUnavailableResponse;
                   }
                   return successResponse;
               });

            x509FederationClient.Client = new HttpClient(handlerMock.Object);
            Assert.Equal(expectedJwtToken, x509FederationClient.GetSecurityToken());

            // Check HttpClient called 3 times
            handlerMock.Protected().Verify(
                "SendAsync",
                Times.Exactly(3), // Check that SendAsync was called thrice
                ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>()
            );

            // Cleanup
            SystemClock.Reset(); // Reset to default behavior after test
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void GetSecurityTokenFailureAfterRetry()
        {
            // Mock the SystemClock.SleepAsync to avoid actual delay
            var sleepCallCount = 0;
            SystemClock.SleepAsync = (_, _) =>
            {
                sleepCallCount++;
                return Task.CompletedTask; // Immediately complete the sleep
            };

            // Mock HttpMessageHandler
            var callCount = 0;
            var handlerMock = new Mock<HttpMessageHandler>();
            var badGateWayResponse = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.BadGateway,
                Content = ContentHelper.CreateHttpContent(new ErrorCodeAndMessage("BadGateway", "Some Error"))
            };
            var serviceUnavailableResponse = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.ServiceUnavailable,
                Content = ContentHelper.CreateHttpContent(new ErrorCodeAndMessage("ServiceUnavailable", "Some Error"))
            };

            handlerMock
               .Protected()
               .Setup<Task<HttpResponseMessage>>(
                  "SendAsync",
                  ItExpr.IsAny<HttpRequestMessage>(),
                  ItExpr.IsAny<CancellationToken>())
               .ReturnsAsync(() =>
               {
                   callCount++;
                   if (callCount == 1)
                   {
                       return badGateWayResponse;
                   }
                    return serviceUnavailableResponse;
               });

            x509FederationClient.Client = new HttpClient(handlerMock.Object);
            var exception = Assert.Throws<OciException>(() => x509FederationClient.GetSecurityToken());
            // Assert OCI Exception was ServiceUnavailable
            Assert.Equal(HttpStatusCode.ServiceUnavailable, exception.StatusCode);

            // Check HttpClient called 3 times
            handlerMock.Protected().Verify(
                "SendAsync",
                Times.Exactly(3), // Check that SendAsync was called thrice
                ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>()
            );

            // Cleanup
            SystemClock.Reset(); // Reset to default behavior after test
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public async void TestCircuitBreakerPolicy()
        {
            var circuitBreakerPolicy = CircuitBreaker.CircuitBreakerFactory.GetCircuitBreakerPolicy(
            exceptionsAllowedBeforeBreaking: Constants.DEFAULT_AUTH_CIRCUIT_BREAKER_THRESHOLD,
            durationOfBreak: TimeSpan.FromSeconds(5),
            onBreak: (exception, breakDelay) =>
                    {
                        logger.Info("onBreak called");
                    },
                    onReset: () =>
                    {
                        logger.Info("onReset called");
                    },
                    onHalfOpen: () =>
                    {
                        logger.Info("onHalfOpen called");
                    }
            );

            // Trigger the breaker
            await Assert.ThrowsAsync<HttpRequestException>(async () =>
                await circuitBreakerPolicy.ExecuteAsync(() =>
                {
                    throw new HttpRequestException("Simulated failure");
                }
            ));

            await Assert.ThrowsAsync<HttpRequestException>(async () =>
                await circuitBreakerPolicy.ExecuteAsync(() =>
                {
                    throw new HttpRequestException("Simulated failure");
                }
            ));

            await Assert.ThrowsAsync<HttpRequestException>(async () =>
                await circuitBreakerPolicy.ExecuteAsync(() =>
                {
                    throw new HttpRequestException("Simulated failure");
                }
            ));
            Assert.Equal(CircuitState.Open, circuitBreakerPolicy.CircuitState);

            // Any new calls before half-open state would return BrokenCircuitException
            await Assert.ThrowsAsync<BrokenCircuitException>(async () =>
                await circuitBreakerPolicy.ExecuteAsync(() =>
                {
                    throw new HttpRequestException("Simulated failure");
                }
            ));

            await Task.Delay(5500); // Slightly longer than the break duration
            Assert.Equal(CircuitState.HalfOpen, circuitBreakerPolicy.CircuitState);

            //This should succeed now as the circuit is half-open and call succeeded
            var response = await circuitBreakerPolicy.ExecuteAsync(() => 
                {
                    return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));
                }
            );
            
            Assert.Equal(CircuitState.Closed, circuitBreakerPolicy.CircuitState);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
        
        private class ErrorCodeAndMessage
        {
            [JsonProperty("code")]
            public readonly string Code;

            [JsonProperty("message")]
            public readonly string Message;

            public ErrorCodeAndMessage(string code, string message)
            {
                this.Code = code;
                this.Message = message;
            }
        }
    }
}