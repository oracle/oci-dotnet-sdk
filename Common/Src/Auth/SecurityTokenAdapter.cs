/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IdentityModel.Tokens.Jwt;
using Org.BouncyCastle.Asn1.Cms;

namespace Oci.Common.Auth
{
    /// <summary>
    /// A class that parses the jwt token, checks for the validity
    /// and can provide information of the jwt token.
    /// </summary>
    public class SecurityTokenAdapter
    {
        private JwtSecurityToken jwt;
        private readonly ISessionKeySupplier sessionKeySupplier;
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public readonly string SecurityToken;

        public SecurityTokenAdapter(string securityToken, ISessionKeySupplier sessionKeySupplier)
        {
            this.SecurityToken = securityToken;
            if (string.IsNullOrEmpty(this.SecurityToken))
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
            return (JwtSecurityToken)handler.ReadJwtToken(token);
        }

        /// <summary>
        /// Checks to see if the current token is still valid
        /// Copy and paste the token here: https://jwt.io/ to find keys and values
        /// </summary>
        /// <returns> true if valid </returns>
        public bool IsValid(double time = 0d)
        {
            if (jwt == null)
            {
                logger.Debug("Security token is not valid.");
                return false;
            }

            var expDateTime = jwt.ValidTo;
            expDateTime.Subtract(TimeSpan.FromMilliseconds(time));
            if (expDateTime != null && expDateTime.CompareTo(DateTime.UtcNow) > 0)
            {
                logger.Debug("Security token is not expired");
                return true;
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

            if (string.IsNullOrEmpty(key))
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

        /// <summary>
        /// Return the total milliseconds the jwt token is valid for
        /// </summary>
        public double GetTokenValidDuration()
        {
            if (jwt == null)
            {
                return 0d;
            }
            var issueDateTime = jwt.ValidFrom;
            var expDateTime = jwt.ValidTo;
            return expDateTime.Subtract(issueDateTime).TotalMilliseconds;
        }
    }
}
