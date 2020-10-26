/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http;
using Moq;
using Oci.Common.Auth;
using Oci.Common.Http.Signing.Internal;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Xunit;

namespace Oci.Common.Http.Signing
{
    [ExcludeFromCodeCoverage]
    public class DefaultRequestSignerTests : BaseTest
    {
        private const string OBO_TOKEN = "FakeOBOToken";
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private readonly Mock<IBasicAuthenticationDetailsProvider> authProviderMock;
        private readonly Mock<RsaKeyParameters> rsaKeyParamMock;
        private readonly Mock<ISigner> signerMock;

        public DefaultRequestSignerTests()
        {
            authProviderMock = new Mock<IBasicAuthenticationDetailsProvider>();
            authProviderMock.Setup(p => p.KeyId).Returns("dummy-key-id");

            rsaKeyParamMock = new Mock<RsaKeyParameters>(true, new BigInteger("1"), new BigInteger("2"));
            authProviderMock.Setup(p => p.GetPrivateKey()).Returns(rsaKeyParamMock.Object);

            signerMock = new Mock<ISigner>();

            signerMock.Setup(s => s.GenerateSignature()).Returns(new byte[] { 1, 2, 3, 4, 5 });
        }

        [Theory]
        [InlineData("GET")]
        [InlineData("HEAD")]
        [InlineData("DELETE")]
        [InlineData("PUT")]
        [InlineData("POST")]
        [InlineData("PATCH")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void SignRequestVerifyRequiredAndOptionalHeaders(string httpMethod)
        {
            // Set up HttpRequestMessage.
            var method = new HttpMethod(httpMethod);
            var uriBuilder = new UriBuilder("http://test.com/test/path")
            {
                Query = "query1=1&query2=2"
            };

            var message = new HttpRequestMessage(method, uriBuilder.Uri);
            if (httpMethod.Equals("PUT") || httpMethod.Equals("POST") || httpMethod.Equals("PATCH"))
            {
                message.Content = new StringContent("Dummy Content");
            }
            message.Headers.Add("opc-request-id", "2F9BA4A30BB3452397A5BC1BFE447C5D");
            message.Headers.Add("accept", Constants.JSON_CONTENT_TYPE);

            var defaultRequestSigner = new DefaultRequestSigner(authProviderMock.Object, signerMock.Object);

            defaultRequestSigner.SignRequest(message);

            // Validations
            Assert.True(message.Headers.Contains(Constants.AUTHORIZATION_HEADER));

            var headers = GetHeadersList(message.Headers.GetValues(Constants.AUTHORIZATION_HEADER).FirstOrDefault());
            logger.Info($"Headers size: {headers.Length}");

            AssertEqualHeaders(Constants.REQUIRED_SIGNING_HEADERS, httpMethod.ToLowerInvariant(), headers);
            //verify Constants.OPC_OBO_TOKEN is not included in headers for a non IUserDelegationprovider   
            Assert.False(message.Headers.Contains(Constants.OPC_OBO_TOKEN));
            // Add optional headers
            message.Headers.Add("opc-obo-token", "dummy-obo-token");
            message.Headers.Add("x-subscription", "dummy-subscription");
            message.Headers.Add("x-cross-tenancy-request", "true");

            // remove previously signed AuthHeader
            message.Headers.Remove(Constants.AUTHORIZATION_HEADER);
            defaultRequestSigner.SignRequest(message);

            // Validations
            Assert.True(message.Headers.Contains(Constants.AUTHORIZATION_HEADER));
            headers = GetHeadersList(message.Headers.GetValues(Constants.AUTHORIZATION_HEADER).FirstOrDefault());

            AssertEqualHeaders(Constants.OPTIONAL_SIGNING_HEADERS, httpMethod.ToLowerInvariant(), headers);
        }

        [Theory]
        [InlineData("PUT")]
        [InlineData("POST")]
        [InlineData("PATCH")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void SignRequestVerifyExcludeBodyHeaders(string httpMethod)
        {
            // Set up HttpRequestMessage.
            var method = new HttpMethod(httpMethod);
            var uriBuilder = new UriBuilder("http://test.com/test/path")
            {
                Query = "query1=1&query2=2"
            };

            var message = new HttpRequestMessage(method, uriBuilder.Uri)
            {
                Content = new StringContent("Dummy Content")
            };

            var excludeBodyRequestSigner = new DefaultRequestSigner(
                authProviderMock.Object,
                SigningStrategy.STANDARD,
                signerMock.Object);

            excludeBodyRequestSigner.SignRequest(message);

            // Validations
            Assert.True(message.Headers.Contains(Constants.AUTHORIZATION_HEADER));

            var headers = GetHeadersList(message.Headers.GetValues(Constants.AUTHORIZATION_HEADER).FirstOrDefault());
            logger.Info($"Headers size: {headers.Length}");

            AssertEqualHeaders(Constants.REQUIRED_EXCLUDE_BODY_SIGNING_HEADERS, httpMethod.ToLowerInvariant(), headers);
        }

        [Theory]
        [InlineData("GET", 1)]
        [InlineData("HEAD", 1)]
        [InlineData("DELETE", 1)]
        [InlineData("PUT", 1)]
        [InlineData("POST", 1)]
        [InlineData("PATCH", 1)]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void VerifyOBOHeaderAdditionForDelegationProviders(string httpMethod, int expectedOBOHeaderCount)
        {
            // Set up HttpRequestMessage.
            var method = new HttpMethod(httpMethod);
            var uriBuilder = new UriBuilder("http://test.com/test/path")
            {
                Query = "query1=1&query2=2"
            };

            var message = new HttpRequestMessage(method, uriBuilder.Uri);
            if (httpMethod.Equals("PUT") || httpMethod.Equals("POST") || httpMethod.Equals("PATCH"))
            {
                message.Content = new StringContent("Dummy Content");
            }
            message.Headers.Add("opc-request-id", "2F9BA4A30BB3452397A5BC1BFE447C5D");
            message.Headers.Add("accept", Constants.JSON_CONTENT_TYPE);

            var defaultRequestSigner = new DefaultRequestSigner(GetDelegationProviderMockObject().Object, signerMock.Object);

            defaultRequestSigner.SignRequest(message);

            // Validations
            Assert.True(message.Headers.Contains(Constants.AUTHORIZATION_HEADER));

            var headers = GetHeadersList(message.Headers.GetValues(Constants.AUTHORIZATION_HEADER).FirstOrDefault());
            logger.Info($"Headers size: {headers.Length}");

            AssertEqualHeaders(Constants.REQUIRED_SIGNING_HEADERS, httpMethod.ToLowerInvariant(), headers);

            // Validations
            Assert.True(message.Headers.Contains(Constants.AUTHORIZATION_HEADER));
            headers = GetHeadersList(message.Headers.GetValues(Constants.AUTHORIZATION_HEADER).FirstOrDefault());
            //verifies if obo token is signed
            Assert.Contains(Constants.OPC_OBO_TOKEN, headers);
            //verifies only one Constants.OPC_OBO_TOKEN is included in the header
            Assert.Equal(message.Headers.GetValues(Constants.OPC_OBO_TOKEN).Count(), expectedOBOHeaderCount);
            //verify value of Constants.OPC_OBO_TOKEN is injected into http headers when provider implements IUserDelegationDetailsProvider.
            Assert.Equal(OBO_TOKEN, message.Headers.GetValues(Constants.OPC_OBO_TOKEN).First());
        }

        private void AssertEqualHeaders(Dictionary<string, ReadOnlyCollection<string>> expectedHeaders,
            string httpMethod, string[] headers)
        {
            if (expectedHeaders.TryGetValue(httpMethod, out var values))
            {
                foreach (var header in values)
                {
                    logger.Info($"Checking header {header}");
                    Assert.Contains(header, headers);
                }
            }

        }

        private string[] GetHeadersList(string authHeader)
        {
            var startIndex = authHeader.IndexOf("headers=") + 9;
            var endIndex = authHeader.IndexOf('\"', startIndex);

            return authHeader.Substring(startIndex, endIndex - startIndex).Split(' ');
        }

        private Mock<IUserDelegationDetailsProvider> GetDelegationProviderMockObject()
        {
            var providerMock = new Mock<IUserDelegationDetailsProvider>();
            providerMock.Setup(p => p.KeyId).Returns(authProviderMock.Object.KeyId);
            providerMock.Setup(p => p.GetPrivateKey()).Returns(authProviderMock.Object.GetPrivateKey());
            providerMock.Setup(p => p.GetDelegationToken()).Returns(OBO_TOKEN);
            return providerMock;
        }
    }
}
