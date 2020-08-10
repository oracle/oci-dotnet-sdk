/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
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
            var mockCallHttpMethod = new Mock<Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>>>();
            var requestMessage = new HttpRequestMessage();

            mockCallHttpMethod.Setup(httpMethod => httpMethod(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.OK });

            await retrier.MakeRetryingCall(
                mockCallHttpMethod.Object,
                requestMessage,
                default);

            // Verify if httpMethod has been invoked only once.
            mockCallHttpMethod.Verify(mock => mock.Invoke(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()), Times.Exactly(1));
        }

        [Theory]
        [InlineData(500, "InternalServerError")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public async void TestRetryForDefaultRetryConfig(int statusCode, string message)
        {
            var retrier = new GenericRetrier(new RetryConfiguration { GetNextDelayInSeconds = _ => 0 });  // disabling sleep time
            var mockCallHttpMethod = new Mock<Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>>>();
            var requestMessage = new HttpRequestMessage();

            mockCallHttpMethod.Setup(httpMethod => httpMethod(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new HttpResponseMessage()
                {
                    StatusCode = (System.Net.HttpStatusCode)statusCode,
                    Content = ContentHelper.CreateHttpContent(new ErrorCodeAndMessage(message, "Some Error"))
                });

            await retrier.MakeRetryingCall(
                mockCallHttpMethod.Object,
                requestMessage,
                default);

            var maxDefaultRetries = RetryConfiguration.DefaultWaiterConfiguration.MaxAttempts;
            // verify the number of retries. Total tries = maxDefaultRetries + 1 (original request).
            mockCallHttpMethod.Verify(mock => mock.Invoke(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()), Times.Exactly(maxDefaultRetries + 1));
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
            var mockCallHttpMethod = new Mock<Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>>>();
            var requestMessage = new HttpRequestMessage();

            mockCallHttpMethod.Setup(httpMethod => httpMethod(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new HttpResponseMessage()
                {
                    StatusCode = (System.Net.HttpStatusCode)statusCode,
                    Content = ContentHelper.CreateHttpContent(new ErrorCodeAndMessage(message, "Some Error"))
                });

            await retrier.MakeRetryingCall(
                mockCallHttpMethod.Object,
                requestMessage,
                default);

            mockCallHttpMethod.Verify(mock => mock.Invoke(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()), Times.Exactly(customConfig.MaxAttempts + 1));
        }

        [Theory]
        [InlineData(404, "NotAuthorizedOrNotFound")]
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
            var mockCallHttpMethod = new Mock<Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>>>();
            var requestMessage = new HttpRequestMessage();

            mockCallHttpMethod.Setup(httpMethod => httpMethod(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new HttpResponseMessage()
                {
                    StatusCode = (System.Net.HttpStatusCode)statusCode,
                    Content = ContentHelper.CreateHttpContent(new ErrorCodeAndMessage(message, "Some Error"))
                });

            await Assert.ThrowsAsync<OciException>(() => retrier.MakeRetryingCall(
                mockCallHttpMethod.Object,
                requestMessage,
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
