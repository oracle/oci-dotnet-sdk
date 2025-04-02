/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using Oci.Common.Retry;

namespace Oci.Common
{
    /// <summary>This class provides configuration options for client requests.</summary>
    public class ClientConfiguration
    {
        private static readonly int TIMEOUT_MILLIS = 100000;
        private static readonly long RESPONSE_CONTENT_BUFFER_BYTES = (long)2 * 1024 * 1024 * 1024 - 1;

        /// <summary>The max time to wait for a request to complete, in millis.  Default is 100000.</summary>
        public int TimeoutMillis { get; set; } = TIMEOUT_MILLIS;

        /// <summary>The max number of bytes to buffer when reading the response content. Default is 2GB.</summary>
        public long ResponseContentBufferBytes { get; set; } = RESPONSE_CONTENT_BUFFER_BYTES;

        /// <summary>
        /// Additional user agent string set by the client of this SDK. It will be appended to default user agent.
        /// The format is (by convention) "Application/Version", ex "MyApp/1.3.5".
        /// Note, this value is only used to set user agent header the first time a client is created, and once
        /// set, it cannot be changed.
        /// </summary>
        public string ClientUserAgent { get; set; } = null;

        /// <summary>The retry configuration to use.  Default is no retry.</summary>
        public RetryConfiguration RetryConfiguration { get; set; }

        /// <summary>Optional ClientCertificateOption.  Default is Automatic.</summary>
        public ClientCertificateOption ClientCertificateOption { get; set; } = ClientCertificateOption.Automatic;

        /// <summary>Optional array of client X509Certificate to trust.</summary>
        public X509Certificate[] ClientCertificates { get; set; }

    }
}
