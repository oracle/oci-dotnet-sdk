/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

using Org.BouncyCastle.Crypto;

namespace Oci.Common.Auth.Internal
{
    public class FixedContentResourcePrincipalFederationClient : IFederationClient
    {
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private readonly SecurityTokenAdapter securityTokenAdapter;
        public FixedContentResourcePrincipalFederationClient(ISessionKeySupplier sessionKeySupplier, string resourcePrincipalSessionToken)
        {
            this.securityTokenAdapter = new SecurityTokenAdapter(resourcePrincipalSessionToken, sessionKeySupplier);
        }

        public string GetSecurityToken() => securityTokenAdapter.SecurityToken;

        public string RefreshAndGetSecurityToken() => securityTokenAdapter.SecurityToken;

        public string GetStringClaim(string key) => securityTokenAdapter.GetStringClaim(key);

    }
}