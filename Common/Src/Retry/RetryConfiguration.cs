/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Oci.Common.Retry
{
    /// <summary>The retry configuration for HTTP client to send HTTP requests.</summary>
    public class RetryConfiguration : Oci.Common.Waiters.WaiterConfiguration
    {
        private static readonly int MAX_DURATION = 60 * 10; // 10 Mins

        /// <summary>The default collection of status codes families (first digit) that can be retried.</summary>
        public static readonly ReadOnlyCollection<int> RETRYABLE_STATUSCODE_FAMILY = new ReadOnlyCollection<int>(new int[] { 5 });

        /// <summary>The default collection of errors that can be retried.</summary>
        public static readonly ReadOnlyCollection<Tuple<int, string>> RETRYABLE_ERRORS = new ReadOnlyCollection<Tuple<int, string>>(
            new Tuple<int, string>[] {
                new Tuple<int, string>(400, "RelatedResourceNotAuthorizedOrNotFound"),
                new Tuple<int, string>(401, "NotAuthenticated"),
                new Tuple<int, string>(404, "NotAuthorizedOrNotFound"),
                new Tuple<int, string>(409, "IncorrectState"),
                new Tuple<int, string>(409, "NotAuthorizedOrResourceAlreadyExists"),
                new Tuple<int, string>(429, "TooManyRequests"),
                new Tuple<int, string>(500, "InternalServerError"),
            }
        );

        /// <summary>The total elapsed time allowed for reties.</summary>
        public int TotalElapsedTimeInSecs { get; set; } = MAX_DURATION;

        /// <summary>The collection of status codes families (first digit) that can be retried.</summary>
        public List<int> RetryableStatusCodeFamilies { get; set; } = new List<int>(RETRYABLE_STATUSCODE_FAMILY);

        /// <summary>The collection of errors that can be retried.</summary>
        public Collection<Tuple<int, string>> RetryableErrors { get; set; } = new Collection<Tuple<int, string>>(RETRYABLE_ERRORS);
    }
}
