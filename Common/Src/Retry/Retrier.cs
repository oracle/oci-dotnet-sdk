/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

﻿namespace Oci.Common.Retry
{
    public class Retrier
    {
        public Retrier()
        {
        }

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
