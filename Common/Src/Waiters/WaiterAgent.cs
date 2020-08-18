/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Threading.Tasks;
using Oci.Common.Model;
using Polly;

namespace Oci.Common.Waiters
{
    /// <summary>
    /// Provides a waiter agent that waits until a desired condition is met.
    /// </summary>
    /// <typeparam name="Request">Get request for the desired resource</typeparam>
    /// <typeparam name="Response">Request response type</typeparam>
    public class WaiterAgent<Request, Response>
    {
        /// <summary>
        /// Provides a new request instance to fetch the current state.
        /// </summary>
        private readonly Request request;
        /// <summary>
        /// Function that will be invoked to fetch the current state. It  will be provided the request instance given by the request parameter.
        /// </summary>
        private readonly Func<Request, Task<Response>> query;
        /// <summary>
        /// The termination predicate that will inspect the current state (returned response instance) to determine if it is done waiting.
        /// </summary>
        private readonly Predicate<Response> condition;
        /// <summary>
        /// True to allow 404 responses to be accepted.
        /// </summary>
        private readonly bool allow404s;
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public WaiterAgent(Request request, Func<Request, Task<Response>> query, Predicate<Response> condition, bool allow404s = false)
        {
            this.request = request;
            this.query = query;
            this.condition = condition;
            this.allow404s = allow404s;
        }

        /// <summary>
        /// Waits until a desired condition is met.
        /// </summary>
        /// <param name="waiterConfig">Waiter config contains the configuration for waiters such as max attempts and sleep time in between retries </param>
        /// <returns> Response </returns>
        public Response Execute(WaiterConfiguration waiterConfig)
        {
            var retryAndSleepPolicy = Policy
                .HandleResult<Response>(response => !this.condition(response))
                .WaitAndRetryAsync(
                    retryCount: waiterConfig.MaxAttempts,
                    sleepDurationProvider: (retryCount, response, context) => TimeSpan.FromSeconds(waiterConfig.GetNextDelayInSeconds(retryCount)),
                    onRetryAsync: async (response, timespan, retryCount, context) =>
                    {
                        logger.Trace($"Retry Attempt: {retryCount}");
                        await Task.CompletedTask.ConfigureAwait(false);
                    });

            Task<PolicyResult<Response>> policyResultTask = retryAndSleepPolicy.ExecuteAndCaptureAsync(() => query.Invoke(request));
            PolicyResult<Response> policyResult = policyResultTask.Result;

            if (policyResult.Outcome == OutcomeType.Failure)
            {
                if (policyResult.FinalException != null)
                {
                    if (allow404s && policyResult.FinalException.InnerException is OciException && ((OciException)policyResult.FinalException.InnerException).StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        //If the targetted resource is terminated and the user is interested in the Terminated state, return the default value(i.e null).
                        return default;
                    }
                    throw policyResult.FinalException;
                }

                throw new WaitConditionFailedException("Failed to reach desired state.");
            }
            return policyResult.Result;
        }
    }

    // Exception will be thrown when the desired resource state is not met.
    public class WaitConditionFailedException : Exception
    {
        public WaitConditionFailedException(string message) : base(message) { }
    }
}
