/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

﻿namespace Oci.Common.Retry
{
    /// <summary>An implementaion of a retrier class.</summary>
    public class Retrier
    {
        public Retrier()
        {
        }

        /// <summary>
        /// Returns a generic retrier.
        /// <br/>
        /// If request level retry configuration is sepcified, return a generic retrier for it;
        /// or if a client level retry configuration is specified, return a generic retrier for it;
        /// if none of them is specified, return null.
        /// </summary>
        /// <param name="requestLevelRetry">A retry configuration at request level.</param>
        /// <param name="clientLevelRetry">A retry configuration at client level.</param>
        /// <returns>A generic retrier, or null if no retry configuration is provided.</returns>
        public static GenericRetrier GetPreferredRetrier(
            RetryConfiguration requestLevelRetry,
            RetryConfiguration clientLevelRetry)
        {
            if (requestLevelRetry != null)
            {
                return new GenericRetrier(requestLevelRetry);
            }
            else if (clientLevelRetry != null)
            {
                return new GenericRetrier(clientLevelRetry);
            }

            // no retry by default
            return null;
        }
    }
}
