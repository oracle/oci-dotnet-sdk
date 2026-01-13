/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Oci.Common.Utils;

namespace Oci.Common.Retry
{
    /// <summary>The retry configuration for HTTP client to send HTTP requests.</summary>
    public class RetryConfiguration : Oci.Common.Waiters.WaiterConfiguration
    {
        private static readonly int MAX_DURATION = 60 * 10; // 10 Mins

        /// <summary>The collection of status codes families (first digit) that can be retried.</summary>
        public static readonly ReadOnlyCollection<int> RETRYABLE_STATUSCODE_FAMILY = new ReadOnlyCollection<int>(new int[] { });

        /// <summary>
        /// The collection of errors that can be retried. Providing an empty string "" means that the status code would be retried regardless of the Error code.
        /// </summary>
        public static readonly ReadOnlyCollection<Tuple<int, string>> RETRYABLE_ERRORS = new ReadOnlyCollection<Tuple<int, string>>(
            new Tuple<int, string>[] {
                new Tuple<int, string>(409, "IncorrectState"),
                new Tuple<int, string>(429, ""),
                new Tuple<int, string>(500, ""),
                new Tuple<int, string>(502, ""),
                new Tuple<int, string>(503, ""),
                new Tuple<int, string>(504, ""),
                new Tuple<int, string>(505, ""),
                new Tuple<int, string>(506, ""),
                new Tuple<int, string>(507, ""),
                new Tuple<int, string>(508, ""),
                new Tuple<int, string>(510, ""),
                new Tuple<int, string>(511, ""),
            }
        );

        /// <summary>The total elapsed time allowed for reties.</summary>
        public int TotalElapsedTimeInSecs { get; set; } = MAX_DURATION;

        /// <summary>The collection of status codes families (first digit) that can be retried.</summary>
        public List<int> RetryableStatusCodeFamilies { get; set; } = new List<int>(RETRYABLE_STATUSCODE_FAMILY);

        /// <summary>The collection of errors that can be retried.</summary>
        public Collection<Tuple<int, string>> RetryableErrors { get; set; } = new Collection<Tuple<int, string>>(RETRYABLE_ERRORS);

        public static RetryConfiguration DefaultRetryConfiguration = new RetryConfiguration();

        public static readonly bool isDefaultRetryEnabled = RetryUtils.IsDefaultRetryConfigurationEnabled();
    }
}
