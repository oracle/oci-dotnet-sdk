/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

﻿namespace Oci.Common.Retry
{
    /// <summary>A retry strategy that uses exponetial backoff to calculate delays.</summary>
    public class BackOffRetryStrategy
    {
        public int BaseSleepTimeSeconds { get; set; }
        public int ExponentialGrowthFactor { get; set; }
        public int MaxWaitBetweenCallsSeconds { get; set; }
        public RetryBackOffType BackOffType { get; set; }

        /// <summary>Constructor.</summary>
        /// <param name="backOffType">The retry backoff type.</param>
        /// <param name="baseSleepTimeSeconds">The sleep time to start with.</param>
        /// <param name="exponentialGrowthFactor">The exponential growth factor used to calculate subsequent delays.</param>
        /// <param name="maxWaitBetweenCallsSeconds">The maximum delay duration in seconds.</param>
        public BackOffRetryStrategy(RetryBackOffType backOffType, int baseSleepTimeSeconds, int exponentialGrowthFactor, int maxWaitBetweenCallsSeconds)
        {
            this.BackOffType = backOffType;
            this.BaseSleepTimeSeconds = baseSleepTimeSeconds;
            this.ExponentialGrowthFactor = exponentialGrowthFactor;
            this.MaxWaitBetweenCallsSeconds = maxWaitBetweenCallsSeconds;
        }
    }
}
