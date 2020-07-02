/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

﻿using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Oci.Common.Model;
using Polly;
using Polly.Retry;
using Polly.Timeout;

namespace Oci.Common.Retry
{
    public class GenericRetrier
    {
        private readonly RetryConfiguration retryConfiguration;
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public GenericRetrier(RetryConfiguration retryConfiguration)
        {
            this.retryConfiguration = retryConfiguration;
        }

        public Task<HttpResponseMessage> MakeRetryingCall(
            Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> asyncHttpCall,
            HttpRequestMessage requestMessage,
            CancellationToken cancellationToken)
        {
            AsyncTimeoutPolicy timeOutPolicy = Policy.TimeoutAsync(
                retryConfiguration.TotalElapsedTimeInSecs,
                TimeoutStrategy.Optimistic,
                onTimeoutAsync: (context, timespan, t1, exception) => throw new OciException(
                    HttpStatusCode.RequestTimeout,
                    "Request has been timed out. Please increase the total elapsed time for this request and retry",
                    "Unknown",
                    exception)
                );

            AsyncRetryPolicy<HttpResponseMessage> retryAndSleepPolicy = Policy
                .HandleResult<HttpResponseMessage>(r => ShoulRetryOnHttpResponse(r))
                .WaitAndRetryAsync(
                retryCount: retryConfiguration.MaxAttempts,
                sleepDurationProvider: (retryCount, response, context) => TimeSpan.FromSeconds(retryConfiguration.GetNextDelayInSeconds(retryCount)),
                onRetryAsync: async (response, timespan, retryAttempt, context) =>
                {
                    logger.Info($"Retry Attempt: {retryAttempt}");
                    await Task.CompletedTask;
                }
            );

            return timeOutPolicy
                .WrapAsync(retryAndSleepPolicy)
                .ExecuteAsync(() => asyncHttpCall.Invoke(requestMessage, cancellationToken));
        }

        private bool ShoulRetryOnHttpResponse(HttpResponseMessage response)
        {
            var statusCode = (int)response.StatusCode;
            var responseFamily = statusCode / 100;

            return retryConfiguration.RetryableStatusCodeFamilies.Contains(responseFamily) ||
                retryConfiguration.RetryableStatusCodes.Contains(statusCode);
        }
    }
}
