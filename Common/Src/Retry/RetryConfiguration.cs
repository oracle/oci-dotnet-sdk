/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

﻿using System.Collections.Generic;

namespace Oci.Common.Retry
{
    /// <summary>The retry configuration for HTTP client to send HTTP requests.</summary>
    public class RetryConfiguration : Oci.Common.Waiters.WaiterConfiguration
    {
        private static readonly int MAX_DURATION = 60 * 10; // 10 Mins

        /// <summary>The total elapsed time allowed for reties.</summary>
        public int TotalElapsedTimeInSecs { get; set; } = MAX_DURATION;

        /// <summary>The group of status codes (first digit) that can be retried.</summary>
        public List<int> RetryableStatusCodeFamilies { get; set; } = new List<int> { 5 };

        /// <summary>The set of status codes that can be retried.</summary>
        public List<int> RetryableStatusCodes { get; set; } = new List<int> { 408, 429 };
    }
}
