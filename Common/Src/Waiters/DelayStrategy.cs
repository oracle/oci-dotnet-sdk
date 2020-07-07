/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

﻿using System;
namespace Oci.Common.Waiters
{
    /// <summary>Utility class which contains Fixed and Exponential delay strategies.</summary>
    public class DelayStrategy
    {
        private static readonly int DEFAULT_DELAY_SECONDS = 5;

        /// <summary>Returns DEFAULT_DELAY value.</summary>
        public static double GetFixedDelayInSeconds(int _)
        {
            return DEFAULT_DELAY_SECONDS;
        }

        /// <summary>Returns base 2 exponential delay depending on the retryAttempt</summary>
        /// <param name="retryAttempt">The current retry attempt.</param>
        /// <returns>The delay duration in seconds.</returns>
        public static double GetExponentialDelayInSeconds(int retryAttempt)
        {
            return Math.Pow(2, retryAttempt);
        }
    }
}
