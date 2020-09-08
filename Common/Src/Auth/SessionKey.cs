/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Security;

namespace Oci.Common.Auth
{
    /// <summary>A class to generate a public and private key pair.</summary>
    public class SessionKey : ISessionKeySupplier
    {
        private AsymmetricCipherKeyPair keyPair;

        public SessionKey()
        {
            RefreshKeys();
        }

        /// <summary>A function to get the key pair.</summary>
        /// <returns>Returns the current key pair.</returns>
        public AsymmetricCipherKeyPair GetKeyPair()
        {
            return this.keyPair;
        }

        /// <summary>Generate a new key pair.</summary>
        public void RefreshKeys()
        {
            RsaKeyPairGenerator rsaKeyPair = new RsaKeyPairGenerator();
            rsaKeyPair.Init(new KeyGenerationParameters(new SecureRandom(), 2048));
            AsymmetricCipherKeyPair keyPair = rsaKeyPair.GenerateKeyPair();
            this.keyPair = keyPair;
        }
    }
}
