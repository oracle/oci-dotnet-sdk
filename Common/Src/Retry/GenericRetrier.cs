/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Oci.Common.Http.Internal;
using Oci.Common.Model;
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
                    var newRequestMessage = await CloneHttpRequestMessage(requestMessage).ConfigureAwait(false);
                    return await asyncHttpCall.Invoke(newRequestMessage, cancellationToken).ConfigureAwait(false);
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
                    logger.Info($"Checking if {statusCode}: {e.ServiceCode} should be retried.");
                    return retryConfiguration.RetryableStatusCodeFamilies.Contains(responseFamily) ||
                        retryConfiguration.RetryableErrors.Contains(new Tuple<int, string>(statusCode, e.ServiceCode));
                }
            }
            return false;
        }

        /// <summary>Make a copy of HttpRequestMessage.</summary>
        /// <param name="request">The source HttpRequestMessage</param>
        /// <returns>A cloned copy of HttpRequestMessage with exactly the same headers and content.</returns>
        private async Task<HttpRequestMessage> CloneHttpRequestMessage(HttpRequestMessage request)
        {
            var clone = new HttpRequestMessage(request.Method, request.RequestUri);
            if (request.Content != null)
            {
                var ms = new MemoryStream();
                await request.Content.CopyToAsync(ms).ConfigureAwait(false);
                ms.Position = 0;
                clone.Content = new StreamContent(ms);
                if (request.Content.Headers != null)
                {
                    foreach (var header in request.Content.Headers)
                    {
                        clone.Content.Headers.Add(header.Key, header.Value);
                    }
                }
            }

            foreach (var header in request.Headers)
            {
                clone.Headers.TryAddWithoutValidation(header.Key, header.Value);
            }

            return clone;
        }
    }
}
