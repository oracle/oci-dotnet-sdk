/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Net.Http;
using Polly;


namespace Oci.Common.CircuitBreaker
{
    public class CircuitBreakerFactory
    {
        public static Polly.CircuitBreaker.AsyncCircuitBreakerPolicy GetCircuitBreakerPolicy(
        int exceptionsAllowedBeforeBreaking,
        TimeSpan durationOfBreak,
        Action<Exception, TimeSpan> onBreak,
        Action onReset,
        Action onHalfOpen)
        {
            return Policy
                .Handle<HttpRequestException>()
                .CircuitBreakerAsync(
                    exceptionsAllowedBeforeBreaking: exceptionsAllowedBeforeBreaking,
                    durationOfBreak: durationOfBreak,
                    onBreak: onBreak,
                    onReset: onReset,
                    onHalfOpen: onHalfOpen);
        }
    }
}