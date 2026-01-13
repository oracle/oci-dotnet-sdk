/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.IO;
using Oci.Common.Utils;
using Org.BouncyCastle.Crypto.Parameters;

namespace Oci.Common.Auth
{
    /// <summary>A base authentication details provider that contains user authentication information and region information.
    /// This is an ideal provider to be used if customer authentication information is not read from config file.</summary>
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
