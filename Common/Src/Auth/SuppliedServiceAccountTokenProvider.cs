/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.IO;

namespace Oci.Common.Auth
{
    public class SuppliedServiceAccountTokenProvider : AbstractServiceAccountTokenSupplier
    {
        protected static new NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private readonly string token;

        protected override string getTokenInner()
        {
            return token;
        }

        public SuppliedServiceAccountTokenProvider(string token)
        {
            this.token = token;
        }
    }
}