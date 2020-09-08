/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

namespace Oci.Common.Auth.Internal
{
    /// <summary>Defines a basic interface for a federation endpoint that provides a security token for authentication. </summary>
    public interface IFederationClient
    {
        /// <summary>
        /// Gets a security token from the federation endpoint. May use a cached token if
        /// it judged to still be valid.
        /// </summary>
        /// <returns> A security token that can be used to authenticate requests. </returns>
        string GetSecurityToken();

        /// <summary>
        /// Gets a security token from the federation endpoint. This will always retreive
        /// a new token from the federation endpoint and does not use a cached token.
        /// </summary>
        /// <returns> A security token that can be used to authenticate requests. </returns>
        string RefreshAndGetSecurityToken();

        /// <summary>
        /// Get a claim embedded in the security token. May use the cached token if it is
        /// judged to still be valid.
        /// </summary>
        string GetStringClaim(string key);
    }
}
