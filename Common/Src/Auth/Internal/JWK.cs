/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;

namespace Oci.Common.Auth.Internal
{
    /// <summary>
    /// Class to extract the JWK from JWT Token
    /// </summary>
    public class JWK
    {
        // JSON Keys
        public string n { get; set; }
        public string e { get; set; }
        public string kid { get; set; }
        public string use { get; set; }
        public string algorithm { get; set; }

    }
}