/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Oci.Common.Http.Internal;
using Oci.Common.Model;
using Oci.Common.Utils;
using Polly;
using Polly.Retry;
using Polly.Timeout;

namespace Oci.Common.Retry
{
    /// <summary>A generic retrier class.</summary>
    public class GenericRetrier
    {
        private readonly RetryConfiguration retryConfiguration;
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public RetryConfiguration GetRetryConfiguration()
        {
            return this.retryConfiguration;
        }
        public GenericRetrier(RetryConfiguration retryConfiguration)
        {
            this.retryConfiguration = retryConfiguration;
        }

        public Task<HttpResponseMessage> MakeRetryingCall(
            Func<HttpRequestMessage, HttpCompletionOption, CancellationToken, Task<HttpResponseMessage>> asyncHttpCall,
            HttpRequestMessage requestMessage,
            HttpCompletionOption completionOption,
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
                    logger.Info($"Retry Attempt: #{retryAttempt}");
                    await Task.CompletedTask.ConfigureAwait(false);
                }
            );

            return timeOutPolicy
                .WrapAsync(retryAndSleepPolicy)
                .ExecuteAsync(async () =>
                {
                    // A new copy of the request message needs to be created because it is disposed each time it is sent, and
                    // resending the same request will result in the following error message:
                    // "The request message was already sent. Cannot send the same request message multiple times."
                    var newRequestMessage = await HttpUtils.CloneHttpRequestMessage(requestMessage);
                    return await asyncHttpCall.Invoke(newRequestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                });
        }

        private bool ShoulRetryOnHttpResponse(HttpResponseMessage response)
        {
            var statusCode = (int)response.StatusCode;
            var responseFamily = statusCode / 100;

            // Response with successful status code should not be retried.
            if (statusCode >= 200 && statusCode <= 299)
            {
                return false;
            }
            else
            {
                try
                {
                    // The response is not successful. Try to get the service code from the error response. HandleNonSuccessfulResponse
                    // should throw an OciException containing the service code.
                    ResponseHelper.HandleNonSuccessfulResponse(response);
                }
                catch (OciException e)
                {
                    bool shouldRetry = retryConfiguration.RetryableStatusCodeFamilies.Contains(responseFamily) ||
                        retryConfiguration.RetryableErrors.Contains(new Tuple<int, string>(statusCode, "")) ||
                        retryConfiguration.RetryableErrors.Contains(new Tuple<int, string>(statusCode, e.ServiceCode));
                    if (shouldRetry)
                    {
                        logger.Debug($"{statusCode}: {e.ServiceCode} matches the RetryConfiguration being used and will be retried!");
                    }
                    else
                    {
                        logger.Debug($"{statusCode}: {e.ServiceCode} does not match the RetryConfiguration being used and will not be retried!");
                    }
                    return shouldRetry;
                }
            }
            return false;
        }

    }
}
