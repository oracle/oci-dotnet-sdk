/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

namespace Oci.Common.Auth
{
    /// <summary>An interface of user-based delegation details provider.</summary>
    public interface IUserDelegationDetailsProvider : IBasicAuthenticationDetailsProvider
    {
        public string TenantId { get; }
        public string GetDelegationToken();

    }
}
