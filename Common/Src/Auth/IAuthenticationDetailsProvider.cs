/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

namespace Oci.Common.Auth
{
    /// <summary>An interface of user-based authentication details provider.</summary>
    public interface IAuthenticationDetailsProvider : IBasicAuthenticationDetailsProvider
    {
        public string Fingerprint { get; }
        public string TenantId { get; }
        public string UserId { get; }
    }
}
