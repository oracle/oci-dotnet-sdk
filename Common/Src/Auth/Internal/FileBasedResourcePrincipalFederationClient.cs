/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Runtime.CompilerServices;

using Org.BouncyCastle.Crypto;

namespace Oci.Common.Auth.Internal
{
    public class FileBasedResourcePrincipalFederationClient : IFederationClient
    {
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private readonly ISessionKeySupplier sessionKeySupplier;
        private readonly string resourcePrincipalSessionTokenPath;
        private volatile SecurityTokenAdapter securityTokenAdapter;
        public FileBasedResourcePrincipalFederationClient(ISessionKeySupplier sessionKeySupplier, string resourcePrincipalSessionTokenPath)
        {
            Contract.Requires(sessionKeySupplier != null);
            this.sessionKeySupplier = sessionKeySupplier;
            this.resourcePrincipalSessionTokenPath = resourcePrincipalSessionTokenPath;
            this.securityTokenAdapter = new SecurityTokenAdapter(null, sessionKeySupplier);
        }
        public string GetSecurityToken()
        {
            if (securityTokenAdapter.IsValid())
            {
                return securityTokenAdapter.SecurityToken;
            }
            return RefreshAndGetSecurityToken();
        }

        public string RefreshAndGetSecurityToken()
        {
            return RefreshAndGetSecurityTokenInner(false);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private string RefreshAndGetSecurityTokenInner(bool doFinalTokenValidityCheck)
        {
            // Check again to see if the JWT is still invalid, unless we want to skip that check
            if (!doFinalTokenValidityCheck || !securityTokenAdapter.IsValid())
            {
                logger.Info("Refreshing session keys.");
                sessionKeySupplier.RefreshKeys();

                logger.Info("Getting security token from file.");
                securityTokenAdapter = GetSecurityTokenFromFile();
                return securityTokenAdapter.SecurityToken;
            }
            return securityTokenAdapter.SecurityToken;
        }

        public string GetStringClaim(string key)
        {
            RefreshAndGetSecurityToken();
            return securityTokenAdapter.GetStringClaim(key);
        }

        protected SecurityTokenAdapter GetSecurityTokenFromFile()
        {
            AsymmetricCipherKeyPair keyPair = sessionKeySupplier.GetKeyPair();
            if (keyPair == null)
            {
                throw new ArgumentNullException("Keypair for session was not provided");
            }
            string securityToken;
            try
            {
                securityToken = File.ReadAllText(resourcePrincipalSessionTokenPath);
            }
            catch (IOException e)
            {
                throw new IOException($"Cannot read token from file {resourcePrincipalSessionTokenPath} : {e}");
            }
            return new SecurityTokenAdapter(securityToken, sessionKeySupplier);
        }

    }
}
