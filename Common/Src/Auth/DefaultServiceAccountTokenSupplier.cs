/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.IO;

namespace Oci.Common.Auth
{
    public class DefaultServiceAccountTokenSupplier : AbstractServiceAccountTokenSupplier
    {
        protected static new NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private static readonly string KUBERNETES_SERVICE_ACCOUNT_TOKEN_PATH = "/var/run/secrets/kubernetes.io/serviceaccount/token";
        private readonly string tokenPath;

        protected override string getTokenInner()
        {
            if (File.Exists(tokenPath))
            {
                return File.ReadAllText(tokenPath).Trim();
            }
            throw new IOException($"Kubernetes service account token doesn't exist at path: {tokenPath}");
        }

        public DefaultServiceAccountTokenSupplier() : this(null) { }
        public DefaultServiceAccountTokenSupplier(string tokenPath)
        {
            this.tokenPath = tokenPath ?? KUBERNETES_SERVICE_ACCOUNT_TOKEN_PATH;
        }
    }
}