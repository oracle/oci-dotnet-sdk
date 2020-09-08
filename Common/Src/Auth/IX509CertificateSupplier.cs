/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

namespace Oci.Common.Auth
{
    public interface IX509CertificateSupplier
    {
        /// <summary>
        /// Returns the X509 certificate and private key.  The X509 certificate will always
        /// be valid.  The private key may be null for intermediate certificates.  For leaf
        /// certificates, the private key will always be valid.
        /// </summary>
        /// <returns> An object with the certificate and private key pair.</returns>
        CertificateAndPrivateKeyPair GetCertificateAndKeyPair();

        /// <summary> Update or extend the validity period for an Object. </summary>
        void Refresh();
    }
}
