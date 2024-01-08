/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IO;
using Oci.Common.Utils;

namespace Oci.Common.Auth
{
    /// <summary>A file-based delegation token provider. This class reads a delegation token from a file.</summary>
    public class FileDelegationTokenSupplier : ISupplier<string>
    {
        protected readonly string delegationTokenPath;

        protected string delegationToken = null;

        public FileDelegationTokenSupplier(string delegationTokenPath)
        {
            this.delegationTokenPath = delegationTokenPath;
        }

        /// <summary>Gets the delegation token.</summary>
        /// <returns>Delegation token string.</returns>
        public string GetKey()
        {
            return delegationToken ?? ReadToken();
        }

        /// <summary>Reads the delegation token.</summary>
        /// <returns>The read delegation token.</returns>
        private string ReadToken()
        {
            string token = null;
            using (StreamReader reader = File.OpenText(FileUtils.ExpandUserHome(delegationTokenPath)))
            {
                try
                {
                    token = reader.ReadToEnd();
                }
                catch (Exception e)
                {
                    throw new Exception("Error reading delegation token file.", e);
                }
            }
            return delegationToken = token;
        }
    }
}
