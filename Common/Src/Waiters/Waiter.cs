/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

﻿using System;
using System.Threading.Tasks;

namespace Oci.Common.Waiters
{
    /// <summary>
    /// Provides a mechanism for waiting on some condition in either blocking or async manner.
    /// </summary>
    /// <typeparam name="Request">Request Type</typeparam>
    /// <typeparam name="Response">Response Type</typeparam>
    public class Waiter<Request, Response>
    {
        private readonly WaiterAgent<Request, Response> agent;
        private readonly WaiterConfiguration configuration;

        // A function which invokes waiter agent to wait until
        // a condition is met and returns the response.
        private readonly Func<Response> invokableWaiterAgent;

        public Waiter(WaiterConfiguration configuration, WaiterAgent<Request, Response> agent)
        {
            this.configuration = configuration;
            this.agent = agent;
        }

        public Waiter(Func<Response> invokableWaiterAgent)
        {
            this.invokableWaiterAgent = invokableWaiterAgent;
        }

        /// <summary>
        /// Executes the waiter agent in a new thread and it is blocked until the condition is met or throws an exception.
        /// </summary>
        /// <returns>Response</returns>
        public Response Execute()
        {
            var task = Task.Run<Response>(() => GetResponse());
            var response = task.Result;
            return response;
        }

        private Response GetResponse()
        {
            if (this.invokableWaiterAgent != null)
            {
                return this.invokableWaiterAgent.Invoke();
            }
            return agent.Execute(this.configuration);
        }

        /// <summary>
        /// Returns a Task<typeparamref name="Response"></typeparamref> which can be waited on and the result
        /// would contain response in the desired state or throws an exception if the condition is not met.
        /// </summary>
        /// <returns>Task<typeparamref name="Response"></typeparamref></returns>
        public Task<Response> ExecuteAsync()
        {
            if(this.invokableWaiterAgent != null)
            {
                return new TaskFactory().StartNew(() => this.invokableWaiterAgent.Invoke());
            }

            return new TaskFactory().StartNew(() => agent.Execute(this.configuration));
        }
    }
}
