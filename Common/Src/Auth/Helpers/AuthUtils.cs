/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Oci.Common.Auth.Internal;

namespace Oci.Common.Auth.Utils
{
    /// <summary>A utility class to get information from X509Certificate2 certificates.</summary>
    public class AuthUtils
    {
        /// <summary>Extract TenantId from the X509 certificate.</summary>
        /// <param name="certificate">certificate to read tenantId from.</param>
        /// <returns>return the tenantId</returns>
        public static string GetTenantIdFromCertificate(X509Certificate2 certificate)
        {
            if (certificate == null)
            {
                throw new NullReferenceException();
            }

            foreach (var item in certificate.Subject.Split(','))
            {
                if (item.Contains(Constants.OPC_TENANT))
                {
                    return item.Split(':')[1];
                }
                else if (item.Contains(Constants.OPC_IDENTITY))
                {
                    return item.Split(':')[1];
                }
            }
            return null;
        }

        /// <summary>Converts thumbprint to fingerprint.</summary>
        /// <param name="thumbprint">The thumbprint to convert.</param>
        /// <returns>Return the tenantId.</returns>
        /// <example>
        /// A1B2C3D4 ==> a1:b2:c3:d4
        /// </example>
        public static string GetFingerPrint(string thumbprint)
        {
            StringBuilder bar = new StringBuilder();
            int count = 0;
            foreach (char c in thumbprint.ToLower())
            {
                count++;
                bar.Append(c);
                if (count % 2 == 0)
                {
                    bar.Append(':');
                }
            }
            return bar.ToString().TrimEnd(':');
        }
    }
}
