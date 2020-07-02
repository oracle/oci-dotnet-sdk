/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using Oci.Common.Retry;

namespace Oci.Common
{
    public class ClientConfiguration
    {
        private static readonly int TIMEOUT_MILLIS = 100000;
        private static readonly long RESPONSE_CONTENT_BUFFER_BYTES = (long)2 * 1024 * 1024 * 1024 - 1;

        // The max time to wait for a request to complete, in millis.  Default is 100000.
        public int TimeoutMillis { get; set; } = TIMEOUT_MILLIS;

        // The max number of bytes to buffer when reading the response content. Default is 2GB.
        public long ResponseContentBufferBytes { get; set; } = RESPONSE_CONTENT_BUFFER_BYTES;

        // Additional user agent string set by the client of this SDK. It will be appended to default user agent.
        // The format is (by convention) "Application/Version", ex "MyApp/1.3.5".
        // Note, this value is only used to set user agent header the first time a client is created, and once
        // set, it cannot be changed.
        public string ClientUserAgent { get; set; } = null;

        // The retry configuration to use.  Default is no retry.
        public RetryConfiguration RetryConfiguration { get; set; }
    }
}
