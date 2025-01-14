/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Security;

using Oci.Common.Utils;

using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;

namespace Oci.Common.Auth
{
    /// <summary>
    /// A Session Key Supplier that gets the private key and it's pass phrase from files
    /// </summary>
    public class FileBasedKeySupplier : ISessionKeySupplier
    {
        private volatile AsymmetricCipherKeyPair keyPair;

        private readonly string privateKeyPath;

        private readonly string passphrasePath;
        public FileBasedKeySupplier(string privateKeyPath, string passphrasePath)
        {
            this.privateKeyPath = privateKeyPath;
            this.passphrasePath = passphrasePath;
        }

        public AsymmetricCipherKeyPair GetKeyPair() => this.keyPair;

        /// <summary>
        /// Refresh the Keys of the File Based Key Supplier
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>        
        public void RefreshKeys()
        {
            if (this.privateKeyPath == null)
            {
                throw new ArgumentNullException($"Private Key Path is not set");
            }
            SecureString passPhrase = null;
            if (!string.IsNullOrWhiteSpace(passphrasePath))
            {
                passPhrase = FileUtils.GetSecurePassphraseFromFile(passphrasePath);
            }
            var filePrivateKeySupplier = new FilePrivateKeySupplier(privateKeyPath, passPhrase);
            var privateKey = filePrivateKeySupplier.GetKey();
            var publicKey = new RsaKeyParameters(false, privateKey.Modulus, privateKey.Exponent);
            keyPair = new AsymmetricCipherKeyPair(publicKey, privateKey);
        }
    }

}