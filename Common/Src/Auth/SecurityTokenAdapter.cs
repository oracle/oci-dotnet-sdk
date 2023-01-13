/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;

using Newtonsoft.Json;

using Oci.Common.Auth.Internal;
using Oci.Common.Utils;

namespace Oci.Common.Auth
{
    /// <summary>
    /// A class that parses the jwt token, checks for the validity
    /// and can provide information of the jwt token.
    /// </summary>
    public class SecurityTokenAdapter
    {
        private static readonly string ALGORITHM = "RS256";
        private JwtSecurityToken jwt;
        private readonly ISessionKeySupplier sessionKeySupplier;
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public readonly string SecurityToken;

        public SecurityTokenAdapter(string securityToken, ISessionKeySupplier sessionKeySupplier)
        {
            this.SecurityToken = securityToken;
            if (String.IsNullOrEmpty(this.SecurityToken))
            {
                jwt = null;
            }
            else
            {
                jwt = Parse(this.SecurityToken);
            }
            this.sessionKeySupplier = sessionKeySupplier;
        }

        private JwtSecurityToken Parse(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            jwt = (JwtSecurityToken)handler.ReadJwtToken(token);
            return jwt;
        }

        /// <summary>
        /// Checks to see if the current token is still valid
        /// Copy and paste the token here: https://jwt.io/ to find keys and values
        /// </summary>
        /// <returns> true if valid </returns>
        public bool IsValid()
        {
            if (jwt == null)
            {
                logger.Debug("Security token is not valid.");
                return false;
            }
            try
            {
                var expDateTime = jwt.ValidTo;
                if (expDateTime != null && expDateTime.CompareTo(DateTime.UtcNow) > 0)
                {
                    logger.Debug("Security token is not expired");
                    string[] tokenParts = this.SecurityToken.Split('.');
                    // Next we Verifying JWT signed with the RS256 algorithm using public key
                    // Refer: https://stackoverflow.com/a/34423434
                    string jwk = GetStringClaim("jwk");
                    if (!String.IsNullOrEmpty(jwk))
                    {
                        var jwkObject = JsonConvert.DeserializeObject<JWK>(jwk, OciJsonSerializerSettings.GetDefaultJsonSerializerSettings());
                        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                        rsa.ImportParameters(
                            new RSAParameters()
                            {
                                Modulus = FromBase64Url(jwkObject.n),
                                Exponent = FromBase64Url(jwkObject.e)
                            }
                        );
                        SHA256 sha256 = SHA256.Create();
                        byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(tokenParts[0] + '.' + tokenParts[1]));

                        RSAPKCS1SignatureDeformatter rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                        rsaDeformatter.SetHashAlgorithm(ALGORITHM);
                        if (rsaDeformatter.VerifySignature(hash, FromBase64Url(tokenParts[2])))
                        {
                            logger.Debug("Security token is still valid. Public key matches with the JWK.");
                            return true;
                        }
                        logger.Debug("Security token is invalid. Public key does not match with the JWK.");
                    }
                }
            }
            catch (Exception e)
            {
                logger.Debug($"JWT parsing failed: {e}");
            }
            logger.Debug("Security token is not valid");
            return false;
        }

        /// <summary>
        /// Return a value for the given claim in the jwt token
        /// </summary>
        public string GetStringClaim(string key)
        {
            if (jwt == null)
            {
                logger.Debug("Security token is not valid");
                return null;
            }

            if (String.IsNullOrEmpty(key))
            {
                logger.Debug("Key is invalid");
                return null;
            }
            else
            {
                foreach (var claim in jwt.Claims)
                {
                    if (key.Equals(claim.Type))
                    {
                        return claim.Value;
                    }
                }
                logger.Debug("Claim not found");
                return null;
            }
        }

        private static byte[] FromBase64Url(string base64Url)
        {
            string padded = base64Url.Length % 4 == 0
                ? base64Url : base64Url + "====".Substring(base64Url.Length % 4);
            string base64 = padded.Replace("_", "/")
                                    .Replace("-", "+");
            return Convert.FromBase64String(base64);
        }
    }
}
