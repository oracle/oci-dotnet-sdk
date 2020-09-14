/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using Org.BouncyCastle.Crypto;

namespace Oci.Common.Auth
{
    /// <summary>
    /// A session key supplier is responsible for providing public/private key pairs that will be used to both
    /// fetch federated service tokens and to sign individual requests to OCI.
    /// The returned keys should not change unless there as been a call to refreshKeys().
    /// </summary>
    public interface ISessionKeySupplier
    {
        /// <summary>
        /// Returns the current RSA key pair.
        /// </summary>
        /// <returns> The RSA key pair.</returns>
        AsymmetricCipherKeyPair GetKeyPair();

        /// <summary>
        /// If the auth service-issued security token expires, the federation client will try to re-generate a new set of keys
        /// by calling this method. The implementer should create a new pair of keys for security reasons.
        ///
        /// Refreshing keys should not be a long-running blocking call. You can refresh keys in an async thread and return from
        /// this method immediately. When the async process is done refreshing the keys, the client code will automatically
        /// pick up the latest set of keys and update the security token accordingly
        /// </summary>
        void RefreshKeys();
    }
}
