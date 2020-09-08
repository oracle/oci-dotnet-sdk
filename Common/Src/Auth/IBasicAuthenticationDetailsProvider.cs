/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using Org.BouncyCastle.Crypto.Parameters;

namespace Oci.Common.Auth
{
    /// <summary>An interface of authentication details provider that is based on private key.</summary>
    public interface IBasicAuthenticationDetailsProvider : IAbstractAuthenticationDetailsProvider
    {
        public string KeyId { get; }
        RsaKeyParameters GetPrivateKey();
        public char[] PassPhraseCharacters { get; }
    }
}
