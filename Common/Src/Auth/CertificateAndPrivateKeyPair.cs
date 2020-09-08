/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Crypto.Parameters;

namespace Oci.Common.Auth
{
    /// <summary>A class to hold X509 certificate and private key together.</summary>
    public class CertificateAndPrivateKeyPair
    {
        public X509Certificate2 Certificate { get; set; }
        public RsaKeyParameters PrivateKey { get; set; }
    }
}
