/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.IO;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using Oci.Common.Auth.Internal;
using Oci.Common.Http.Internal;
using Oci.Common.Utils;

namespace Oci.Common.Auth
{
    /// <summary>
    /// A class that retrieves both certificate and private key off of URL.
    /// This class also provides a way to manually refresh the certificate and
    /// private key at any point.
    /// </summary>
    public class URLBasedX509CertificateSupplier : IX509CertificateSupplier
    {
        /**
        * The certificate and the private key of certificate.
        */
        private CertificateAndPrivateKeyPair certificateAndKeyPair;

        /**
        * The resource details of certificate.
        */
        private ResourceDetails certificateDetails;

        /**
        * The resource details of private key.
        */
        private ResourceDetails privateKeyDetails;

        /**
        * The passphrase of private key.
        */
        private char[] privateKeyPassphraseCharacters;

        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public HttpClient Client { get; set; }

        public URLBasedX509CertificateSupplier(
            ResourceDetails certificateResourceDetails,
            ResourceDetails privateKeyResourceDetails,
            char[] privateKeyPassphraseCharacters)
        {
            this.certificateDetails = certificateResourceDetails;
            this.privateKeyDetails = privateKeyResourceDetails;
            this.privateKeyPassphraseCharacters = privateKeyPassphraseCharacters;
        }

        /// <summary>
        /// Returns the X509 certificate and private key.  The X509 certificate will always
        /// be valid.  The private key may be null for intermediate certificates.  For leaf
        /// certificates, the private key will always be valid.
        /// </summary>
        /// <returns> An object with the certificate and private key pair.</returns>
        public CertificateAndPrivateKeyPair GetCertificateAndKeyPair()
        {
            return this.certificateAndKeyPair;
        }

        /// <summary> Update or extend the validity period for an Object. </summary>
        public void Refresh()
        {
            if (Client == null)
            {
                Client = new HttpClient();
            }
            try
            {
                var x509Certificate = ReadRawCertificate(certificateDetails);
                RsaKeyParameters privateKey = ReadPrivateKey(this.privateKeyDetails, this.privateKeyPassphraseCharacters);
                this.certificateAndKeyPair = new CertificateAndPrivateKeyPair();
                this.certificateAndKeyPair.Certificate = x509Certificate;
                this.certificateAndKeyPair.PrivateKey = privateKey;
            }
            finally
            {
                Dispose();
            }
        }

        private void Dispose()
        {
            this.Client.Dispose();
            this.Client = null;
        }

        private X509Certificate2 ReadRawCertificate(ResourceDetails certificateDetails)
        {
            logger.Info("reading the raw certificate");
            var requestMsg = new HttpRequestMessage(HttpMethod.Get, certificateDetails.Uri);
            foreach (KeyValuePair<string, string> entry in certificateDetails.Headers)
            {
                requestMsg.Headers.TryAddWithoutValidation(entry.Key, entry.Value);
            }

            var response = Client.SendAsync(requestMsg).Result;
            if (response == null || !response.IsSuccessStatusCode)
            {
                logger.Debug("Received non successful response while trying to get the raw certificate");
                ResponseHelper.HandleNonSuccessfulResponse(response);
            }

            var certificateString = response.Content.ReadAsStringAsync().Result;
            var certificateBytes = Encoding.UTF8.GetBytes(certificateString);
            return new X509Certificate2(certificateBytes);
        }

        private RsaKeyParameters ReadPrivateKey(ResourceDetails privateKeyResourceDetails, char[] privateKeyPassphrase)
        {
            if (privateKeyResourceDetails == null || privateKeyResourceDetails.Uri == null)
            {
                return null;
            }
            logger.Info("reading the private key");
            var requestMsg = new HttpRequestMessage(HttpMethod.Get, privateKeyResourceDetails.Uri);
            foreach (KeyValuePair<string, string> entry in privateKeyResourceDetails.Headers)
            {
                requestMsg.Headers.TryAddWithoutValidation(entry.Key, entry.Value);
            }

            var response = Client.SendAsync(requestMsg).Result;
            if (response == null || !response.IsSuccessStatusCode)
            {
                logger.Debug("Received non successful response while trying to get the private key");
                ResponseHelper.HandleNonSuccessfulResponse(response);
            }

            var stream = response.Content.ReadAsStreamAsync().Result;
            string privateKeyPassphraseToUse = null;
            if (privateKeyPassphrase != null && privateKeyPassphrase.Length > 0)
            {
                privateKeyPassphraseToUse = privateKeyPassphrase.ToString();
            }
            return GetKey(stream, StringUtils.StringToSecureString(privateKeyPassphraseToUse));
        }

        private RsaKeyParameters GetKey(Stream stream, SecureString passPhrase)
        {
            AsymmetricCipherKeyPair keyPair;
            using (StreamReader reader = new StreamReader(stream))
            {
                try
                {
                    // PemReader uses password only if the private is password encrypted.
                    // If password is passed for a plain private key, it would be ignored.
                    keyPair = (AsymmetricCipherKeyPair)new PemReader(reader, passPhrase == null ? null : new PasswordFinder(passPhrase)).ReadObject();
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
            return (RsaKeyParameters)keyPair.Private;
        }
    }
}
