/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Oci.Common.Http.Signing
{
    public class SignatureSigner : ISignatureSigner
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Sign the given message using the given private keys
        /// </summary>
        /// <param name="privateKey">The private key to use to sign the message</param>
        /// <param name="message">The message to sign, must not be null or empty</param>
        /// <returns>An RSA signature of the message made using given private key</returns>
        ///
        public byte[] sign(RsaKeyParameters privateKey, byte[] message)
        {
            try
            {
                var signer = SignerUtilities.GetSigner("SHA-256withRSA");
                signer.Init(true, privateKey);
                signer.BlockUpdate(message, 0, message.Length);
                return signer.GenerateSignature();
            }
            catch (Exception ex)
            {
                logger.Debug($"Error signing message:{ex}");
                throw ex;
            }
        }
    }
}