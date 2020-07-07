/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.Net.Http;
using Oci.Common.Auth;

namespace Oci.Common.Http.Signing
{
    /// <summary>An abstract class for signing a request.</summary>
    public abstract class RequestSigner
    {
        public RequestSigner(IBasicAuthenticationDetailsProvider authDetailsProvider)
        {
            AuthDetailsProvider = authDetailsProvider;
        }

        public abstract void SignRequest(HttpRequestMessage requestMessage);
        protected IBasicAuthenticationDetailsProvider AuthDetailsProvider { get; }
    }
}
