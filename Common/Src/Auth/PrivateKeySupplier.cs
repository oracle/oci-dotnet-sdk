/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    /// <summary>An implementation of ISupplier that reads private key.</summary>
    public class PrivateKeySupplier : ISupplier<RsaKeyParameters>
    {
        private RsaKeyParameters privateKey;
        private string privateKeyContent;
        private SecureString passPhrase;
        public PrivateKeySupplier(string keyContent) : this(keyContent, null) { }

        public PrivateKeySupplier(string keyContent, string passPhrase)
        {
            this.privateKeyContent = keyContent;
            this.passPhrase = StringUtils.StringToSecureString(passPhrase);
        }

        public PrivateKeySupplier(RsaKeyParameters privateKey)
        {
            this.privateKey = privateKey;
        }

        /// <summary>Retrieves the private key from a key string.</summary>
        public RsaKeyParameters GetKey()
        {
            if (this.privateKey != null)
            {
                return this.privateKey;
            }

            try
            {
                object pemReader = new PemReader(new StringReader(privateKeyContent), this.passPhrase == null ? null : new PasswordFinder(this.passPhrase)).ReadObject();
                if (pemReader is AsymmetricCipherKeyPair pair)
                {
                    return (RsaKeyParameters)pair.Private;
                }
                else if (pemReader is AsymmetricKeyParameter)
                {
                    RsaPrivateCrtKeyParameters rsaPrivateCrtKeyParameters = (RsaPrivateCrtKeyParameters)pemReader;
                    return new RsaKeyParameters(rsaPrivateCrtKeyParameters.IsPrivate, rsaPrivateCrtKeyParameters.Modulus, rsaPrivateCrtKeyParameters.Exponent);
                }
                else
                {
                    throw new FormatException("The given key does not have the expected type");
                }
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
    }
}
