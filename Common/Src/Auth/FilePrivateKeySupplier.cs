/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IO;
using System.Security;
using Oci.Common.Utils;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;

namespace Oci.Common.Auth
{
    /// <summary>A file-based key provider. This class reads private key from a pem key file.</summary>
    public class FilePrivateKeySupplier : ISupplier<RsaKeyParameters>
    {
        protected readonly string pemFilePath;
        protected readonly SecureString passPhrase;
        protected RsaKeyParameters key = null;

        public FilePrivateKeySupplier(string pemFilePath, SecureString passPhrase)
        {
            this.pemFilePath = pemFilePath;
            this.passPhrase = passPhrase ?? null;
        }

        /// <summary>Returns the private key.</summary>
        /// <returns>The private key from key pair.</returns>
        public RsaKeyParameters GetKey()
        {
            return key ?? ReadKey();
        }

        /// <summary>Reads the private key.</summary>
        /// <returns>The private key from key pair.</returns>
        private RsaKeyParameters ReadKey()
        {
            AsymmetricCipherKeyPair keyPair;
            using (StreamReader reader = File.OpenText(FileUtils.ExpandUserHome(pemFilePath)))
            {
                try
                {
                    // PemReader uses password only if the private is password encrypted.
                    // If password is passed for a plain private key, it would be ignored.
                    keyPair = (AsymmetricCipherKeyPair)new PemReader(reader, this.passPhrase == null ? null : new PasswordFinder(this.passPhrase)).ReadObject();
                }
                catch (InvalidCipherTextException e)
                {
                    throw new ArgumentException("Incorrect passphrase for private key", e);
                }
                catch (PasswordException e)
                {
                    throw new ArgumentException("Private key is encrypted with a pass phrase. Please provide passphrase in the config", e);
                }
                catch (InvalidKeyException e)
                {
                    throw new ArgumentException("Invalid Key has been provided", e);
                }

            }
            return key = (RsaKeyParameters)keyPair.Private;
        }
    }
}
