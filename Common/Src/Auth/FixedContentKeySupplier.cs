/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;

using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;

namespace Oci.Common.Auth
{
    public class FixedContentKeySupplier : ISessionKeySupplier
    {
        private readonly AsymmetricCipherKeyPair keyPair;
        public FixedContentKeySupplier(string privateKeyContent, string passphrase)
        {
            if (privateKeyContent == null)
            {
                throw new ArgumentNullException($"Private Key is not set");
            }
            var privateKeySupplier = new PrivateKeySupplier(privateKeyContent, passphrase);
            var privateKey = privateKeySupplier.GetKey();
            var publicKey = new RsaKeyParameters(false, privateKey.Modulus, privateKey.Exponent);
            keyPair = new AsymmetricCipherKeyPair(publicKey, privateKey);
        }

        public AsymmetricCipherKeyPair GetKeyPair() => this.keyPair;

        /// <summary>
        /// Refresh key for FixedContentKeySupplier is a No-Operation as Key Pair is already fixed.
        /// </summary>
        public void RefreshKeys()
        { }
    }
}