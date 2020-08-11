/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;

namespace Oci.Common.Waiters
{
    /// <summary>Provides configuration for Waiters.</summary>
    public class WaiterConfiguration
    {
        /// <summary>Maximum number of attempts to be made until the resource reaches a desired state.</summary>
        public int MaxAttempts { get; set; } = 5;

        /// <summary>
        /// Function which enables the users to configure the sleep time in between the retries.
        /// This function takes the current retry attempt as input and returns the sleep time.
        /// Default delay strategy is expotential delay. Set GetNextDelayInSeconds to another delay strategy if
        /// necessary, e.g. DelayStrategy.GetFixedDelayInSeconds.
        /// </summary>
        public Func<int, double> GetNextDelayInSeconds { get; set; } = DelayStrategy.GetExponentialDelayInSeconds;

        public static WaiterConfiguration DefaultWaiterConfiguration = new WaiterConfiguration();
    }
}
