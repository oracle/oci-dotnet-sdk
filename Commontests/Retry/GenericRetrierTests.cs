/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Moq;
using Newtonsoft.Json;
using Oci.Common.Http.Internal;
using Oci.Common.Model;
using Xunit;

namespace Oci.Common.Retry
{
    [ExcludeFromCodeCoverage]
    public class GenericRetryTests : BaseTest
    {
        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public async void TestNoRetryForSuccessFulResponse()
        {
            var retrier = new GenericRetrier(new RetryConfiguration());
            var mockCallHttpMethod = new Mock<Func<HttpRequestMessage, HttpCompletionOption, CancellationToken, Task<HttpResponseMessage>>>();
            var requestMessage = new HttpRequestMessage();

            mockCallHttpMethod.Setup(httpMethod => httpMethod(It.IsAny<HttpRequestMessage>(), It.IsAny<HttpCompletionOption>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.OK });

            await retrier.MakeRetryingCall(
                mockCallHttpMethod.Object,
                requestMessage,
                default,
                default);

            // Verify if httpMethod has been invoked only once.
            mockCallHttpMethod.Verify(mock => mock.Invoke(It.IsAny<HttpRequestMessage>(), It.IsAny<HttpCompletionOption>(), It.IsAny<CancellationToken>()), Times.Exactly(1));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public async void TestNoRetryForNotImplemented()
        {
            var retrier = new GenericRetrier(new RetryConfiguration());
            var mockCallHttpMethod = new Mock<Func<HttpRequestMessage, HttpCompletionOption, CancellationToken, Task<HttpResponseMessage>>>();
            var requestMessage = new HttpRequestMessage();

            mockCallHttpMethod.Setup(httpMethod => httpMethod(It.IsAny<HttpRequestMessage>(), It.IsAny<HttpCompletionOption>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new HttpResponseMessage()
                {
                    StatusCode = System.Net.HttpStatusCode.NotImplemented,
                    Content = ContentHelper.CreateHttpContent(new ErrorCodeAndMessage("NotImplemented", "Some Error"))
                });

            await retrier.MakeRetryingCall(
                mockCallHttpMethod.Object,
                requestMessage,
                default,
                default);

            // Verify if httpMethod has been invoked only once.
            mockCallHttpMethod.Verify(mock => mock.Invoke(It.IsAny<HttpRequestMessage>(), It.IsAny<HttpCompletionOption>(), It.IsAny<CancellationToken>()), Times.Exactly(1));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public async void TestRequestContentDisposed()
        {
            var retrier = new GenericRetrier(new RetryConfiguration
            {
                RetryableStatusCodeFamilies = new List<int>(new int[] { 1, 2, 3, 4, 5 }),
                MaxAttempts = 3,
            });
            var mockCallHttpMethod = new Mock<Func<HttpRequestMessage, HttpCompletionOption, CancellationToken, Task<HttpResponseMessage>>>();
            mockCallHttpMethod.Setup(httpMethod => httpMethod(It.IsAny<HttpRequestMessage>(), It.IsAny<HttpCompletionOption>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync((HttpRequestMessage requestMessage, HttpCompletionOption completionOption, CancellationToken cancellationToken) =>
                {
                    using var ms = requestMessage.Content.ReadAsStreamAsync().ConfigureAwait(false).GetAwaiter().GetResult();
                    using var streamReader = new StreamReader(ms);
                    var contentString = streamReader.ReadToEnd();
                    return new HttpResponseMessage()
                    {
                        StatusCode = System.Net.HttpStatusCode.BadRequest,
                        Content = ContentHelper.CreateHttpContent(new ErrorCodeAndMessage("Bad Request", "Some Error"))
                    };
                });

            var requestMessage = new HttpRequestMessage
            {
                Content = new StreamContent(new MemoryStream(Encoding.ASCII.GetBytes("Test Data")))
            };

            await retrier.MakeRetryingCall(
                mockCallHttpMethod.Object,
                requestMessage,
                    default,
                    default);

            // Verify if httpMethod has been invoked as requested by Retry Configuration.
            mockCallHttpMethod.Verify(mock => mock.Invoke(It.IsAny<HttpRequestMessage>(), It.IsAny<HttpCompletionOption>(), It.IsAny<CancellationToken>()), Times.Exactly(4));
        }

        [Theory]
        [InlineData(409, "IncorrectState")]
        [InlineData(429, "RandomError")]
        [InlineData(500, "InternalServerError")]
        [InlineData(502, null)]
        [InlineData(504, "")]
        [InlineData(505, "")]
        [InlineData(506, "")]
        [InlineData(507, "")]
        [InlineData(508, "")]
        [InlineData(510, "")]
        [InlineData(511, "")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public async void TestRetryForDefaultRetryConfig(int statusCode, string message)
        {
            var retrier = new GenericRetrier(new RetryConfiguration { GetNextDelayInSeconds = _ => 0 });  // disabling sleep time
            var mockCallHttpMethod = new Mock<Func<HttpRequestMessage, HttpCompletionOption, CancellationToken, Task<HttpResponseMessage>>>();
            var requestMessage = new HttpRequestMessage();

            mockCallHttpMethod.Setup(httpMethod => httpMethod(It.IsAny<HttpRequestMessage>(), It.IsAny<HttpCompletionOption>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new HttpResponseMessage()
                {
                    StatusCode = (System.Net.HttpStatusCode)statusCode,
                    Content = ContentHelper.CreateHttpContent(new ErrorCodeAndMessage(message, "Some Error"))
                });

            await retrier.MakeRetryingCall(
                mockCallHttpMethod.Object,
                requestMessage,
                default,
                default);

            var maxDefaultRetries = RetryConfiguration.DefaultWaiterConfiguration.MaxAttempts;
            // verify the number of retries. Total tries = maxDefaultRetries + 1 (original request).
            mockCallHttpMethod.Verify(mock => mock.Invoke(It.IsAny<HttpRequestMessage>(), It.IsAny<HttpCompletionOption>(), It.IsAny<CancellationToken>()), Times.Exactly(maxDefaultRetries + 1));
        }

        [Theory]
        [InlineData(409, "IncorrectState")]
        [InlineData(429, "RandomError")]
        [InlineData(500, "InternalServerError")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public async void TestRetryForGlobalRetryEnabled(int statusCode, string message)
        {
            Environment.SetEnvironmentVariable("OCI_SDK_DEFAULT_RETRY_ENABLED", "true");
            RetryConfiguration.DefaultRetryConfiguration = new RetryConfiguration { GetNextDelayInSeconds = _ => 0 }; // disabling sleep time
            var retrier = Retrier.GetPreferredRetrier(null, null);
            var mockCallHttpMethod = new Mock<Func<HttpRequestMessage, HttpCompletionOption, CancellationToken, Task<HttpResponseMessage>>>();
            var requestMessage = new HttpRequestMessage();

            mockCallHttpMethod.Setup(httpMethod => httpMethod(It.IsAny<HttpRequestMessage>(), It.IsAny<HttpCompletionOption>(), It.IsAny<CancellationToken>()))
                    .ReturnsAsync(new HttpResponseMessage()
                    {
                        StatusCode = (System.Net.HttpStatusCode)statusCode,
                        Content = ContentHelper.CreateHttpContent(new ErrorCodeAndMessage(message, "Some Error"))
                    });

            await retrier.MakeRetryingCall(
                mockCallHttpMethod.Object,
                requestMessage,
                default,
                default);

            var maxDefaultRetries = RetryConfiguration.DefaultWaiterConfiguration.MaxAttempts;
            // verify the number of retries. Total tries = maxDefaultRetries + 1 (original request).
            mockCallHttpMethod.Verify(mock => mock.Invoke(It.IsAny<HttpRequestMessage>(), It.IsAny<HttpCompletionOption>(), It.IsAny<CancellationToken>()), Times.Exactly(maxDefaultRetries + 1));
        }

        [Theory]
        [InlineData(406, "CustomError")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public async void TestRetryForCustomConfig(int statusCode, string message)
        {
            var customConfig = new RetryConfiguration
            {
                MaxAttempts = 10,
                RetryableErrors = new Collection<Tuple<int, string>> { new Tuple<int, string>(statusCode, message) },
                GetNextDelayInSeconds = _ => 0
            };

            var retrier = new GenericRetrier(customConfig);
            var mockCallHttpMethod = new Mock<Func<HttpRequestMessage, HttpCompletionOption, CancellationToken, Task<HttpResponseMessage>>>();
            var requestMessage = new HttpRequestMessage();

            mockCallHttpMethod.Setup(httpMethod => httpMethod(It.IsAny<HttpRequestMessage>(), It.IsAny<HttpCompletionOption>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new HttpResponseMessage()
                {
                    StatusCode = (System.Net.HttpStatusCode)statusCode,
                    Content = ContentHelper.CreateHttpContent(new ErrorCodeAndMessage(message, "Some Error"))
                });

            await retrier.MakeRetryingCall(
                mockCallHttpMethod.Object,
                requestMessage,
                default,
                default);

            mockCallHttpMethod.Verify(mock => mock.Invoke(It.IsAny<HttpRequestMessage>(), It.IsAny<HttpCompletionOption>(), It.IsAny<CancellationToken>()), Times.Exactly(customConfig.MaxAttempts + 1));
        }

        [Theory]
        [InlineData(409, "IncorrectState")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public async void TestRetryThrowsTimeoutException(int statusCode, string message)
        {
            var customConfig = new RetryConfiguration()
            {
                MaxAttempts = 10,
                TotalElapsedTimeInSecs = 1, // This makes sure the request timesout before returning error response.
                GetNextDelayInSeconds = (retryAttempt) => Math.Pow(2, retryAttempt)
            };

            var retrier = new GenericRetrier(customConfig);
            var mockCallHttpMethod = new Mock<Func<HttpRequestMessage, HttpCompletionOption, CancellationToken, Task<HttpResponseMessage>>>();
            var requestMessage = new HttpRequestMessage();

            mockCallHttpMethod.Setup(httpMethod => httpMethod(It.IsAny<HttpRequestMessage>(), It.IsAny<HttpCompletionOption>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new HttpResponseMessage()
                {
                    StatusCode = (System.Net.HttpStatusCode)statusCode,
                    Content = ContentHelper.CreateHttpContent(new ErrorCodeAndMessage(message, "Some Error"))
                });

            await Assert.ThrowsAsync<OciException>(() => retrier.MakeRetryingCall(
                mockCallHttpMethod.Object,
                requestMessage,
                default,
                default));
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
