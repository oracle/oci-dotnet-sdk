/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using Org.BouncyCastle.Crypto.Parameters;

namespace Oci.Common.Auth
{
    public class SimpleAuthenticationDetailsProvider : CustomerAuthenticationDetailsProvider, IRegionProvider
    {
        public Region Region { get; set; }

        public ISupplier<RsaKeyParameters> PrivateKeySupplier { get; set; }

        public override RsaKeyParameters GetPrivateKey()
        {
            return PrivateKeySupplier.GetKey();
        }
    }
}
