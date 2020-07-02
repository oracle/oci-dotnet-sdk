/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Moq;
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

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public async void TestRetryForDefaultRetryConfig()
        {
            var retrier = new GenericRetrier(new RetryConfiguration { GetNextDelayInSeconds = _ => 0 });  // disabling sleep time
            var mockCallHttpMethod = new Mock<Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>>>();
            var requestMessage = new HttpRequestMessage();

            mockCallHttpMethod.Setup(httpMethod => httpMethod(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.InternalServerError });

            await retrier.MakeRetryingCall(
                mockCallHttpMethod.Object,
                requestMessage,
                default);

            var maxDefaultRetries = RetryConfiguration.DefaultWaiterConfiguration.MaxAttempts;
            // verify the number of retries. Total tries = maxDefaultRetries + 1 (original request).
            mockCallHttpMethod.Verify(mock => mock.Invoke(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()), Times.Exactly(maxDefaultRetries + 1));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public async void TestRetryForCustomConfig()
        {
            var customConfig = new RetryConfiguration()
            {
                MaxAttempts = 10,
                RetryableStatusCodes = new List<int> { 404 },
                GetNextDelayInSeconds = _ => 0
            };

            var retrier = new GenericRetrier(customConfig);
            var mockCallHttpMethod = new Mock<Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>>>();
            var requestMessage = new HttpRequestMessage();

            mockCallHttpMethod.Setup(httpMethod => httpMethod(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.NotFound });

            await retrier.MakeRetryingCall(
                mockCallHttpMethod.Object,
                requestMessage,
                default);

            mockCallHttpMethod.Verify(mock => mock.Invoke(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()), Times.Exactly(customConfig.MaxAttempts + 1));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public async void TestRetryThrowsTimeoutException()
        {
            var customConfig = new RetryConfiguration()
            {
                MaxAttempts = 10,
                TotalElapsedTimeInSecs = 1, // This makes sure the request timesout before returning error response.
                RetryableStatusCodes = new List<int> { 404 },
                GetNextDelayInSeconds = (retryAttempt) => Math.Pow(2, retryAttempt)
            };

            var retrier = new GenericRetrier(customConfig);
            var mockCallHttpMethod = new Mock<Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>>>();
            var requestMessage = new HttpRequestMessage();

            mockCallHttpMethod.Setup(httpMethod => httpMethod(It.IsAny<HttpRequestMessage>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new HttpResponseMessage() { StatusCode = System.Net.HttpStatusCode.NotFound });

            await Assert.ThrowsAsync<OciException>(() => retrier.MakeRetryingCall(
                mockCallHttpMethod.Object,
                requestMessage,
                default));
        }
    }
}
