/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;

namespace Oci.Common.Auth
{
    /// <summary>A class that builds key id.</summary>
    public class CustomerKeyIdFormatter
    {
        /// <summary>Builds key id.</summary>
        /// <param name="tenantId">The tenantId.</param>
        /// <param name="userId">The userId.</param>
        /// <param name="fingerprint">The fignerprint of the user.</param>
        /// <returns>The key id.</returns>
        public static string CreateKeyId(string tenantId, string userId, string fingerprint)
        {
            return $"{tenantId}/{userId}/{fingerprint}";
        }

        /// <summary>Builds key id.</summary>
        /// <param name="provider">The authentication details provider.</param>
        /// <returns>The key id.</returns>
        public static string CreateKeyId(IAuthenticationDetailsProvider provider)
        {
            return CreateKeyId(provider.TenantId, provider.UserId, provider.Fingerprint);
        }
    }
}
