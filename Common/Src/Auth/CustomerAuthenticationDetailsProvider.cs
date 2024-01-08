/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using Org.BouncyCastle.Crypto.Parameters;

namespace Oci.Common.Auth
{
    /// <summary>An abstract class for user-based authentication details provider.</summary>
    public abstract class CustomerAuthenticationDetailsProvider : IAuthenticationDetailsProvider
    {
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public string KeyId
        {
            get
            {
                if (!OCID.IsValidOCID(TenantId))
                {
                    logger.Warn($"tenantId '{TenantId}' does not match expected pattern");
                }
                if (!OCID.IsValidOCID(UserId))
                {
                    logger.Warn($"userId '{UserId}' does not match expected pattern");
                }
                string keyId = CustomerKeyIdFormatter.CreateKeyId(this);
                logger.Debug($"Using keyId: {keyId}");
                return keyId;
            }
        }

        public string Fingerprint { get; set; }
        public string TenantId { get; set; }
        public string UserId { get; set; }
        public char[] PassPhraseCharacters { get; set; }

        public abstract RsaKeyParameters GetPrivateKey();
    }
}
