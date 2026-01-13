/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IO;
using System.IdentityModel.Tokens.Jwt;

namespace Oci.Common.Auth
{
    public abstract class AbstractServiceAccountTokenSupplier : IServiceAccountTokenSupplier
    {
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private bool isValidServiceAccountToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            JwtSecurityToken jwt = handler.ReadJwtToken(token);
            if (jwt == null)
            {
                logger.Debug("Kubernetes Service Account token is not valid.");
                return false;
            }

            var expDateTime = jwt.ValidTo;
            if (expDateTime != null && expDateTime.CompareTo(DateTime.UtcNow) > 0)
            {
                logger.Debug("Kubernetes Service Account token is not expired");
                return true;
            }
            logger.Debug("Kubernetes Service Account token is not valid");
            return false;
        }

        public string ServiceAccountToken
        {
            get
            {
                string currentToken = getTokenInner();
                logger.Debug($"Using Kubernetes Service Account token: {currentToken}");
                if (!isValidServiceAccountToken(currentToken))
                {
                    throw new ArgumentException("Kubernetes service account token expired.");
                }
                return currentToken;
            }
        }

        protected virtual string getTokenInner() => throw new IOException();
    }
}