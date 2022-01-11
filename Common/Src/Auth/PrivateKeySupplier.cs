/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IO;
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
        private string privateKeyContent;

        public PrivateKeySupplier(string keyContent)
        {
            this.privateKeyContent = keyContent;
        }

        /// <summary>Retrieves the private key from a key string.</summary>
        public RsaKeyParameters GetKey()
        {
            AsymmetricCipherKeyPair keyPair;

            try
            {
                keyPair = (AsymmetricCipherKeyPair)new PemReader(new StringReader(privateKeyContent)).ReadObject();
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

            return (RsaKeyParameters)keyPair.Private;
        }
    }
}
