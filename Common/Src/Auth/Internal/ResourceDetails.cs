/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;

namespace Oci.Common.Auth.Internal
{
    /// <summary>
    /// ResourceDetails class is used to hold the request details of a compute instance certificates
    /// </summary>
    public class ResourceDetails
    {
        /// <value>
        /// The url of the certificate
        /// </value>
        public Uri Uri { get; set; }

        /// <value>
        /// Headers to be sent along with the resource fetch request
        /// </value>
        public Dictionary<string, string> Headers { get; set; }
    }
}
