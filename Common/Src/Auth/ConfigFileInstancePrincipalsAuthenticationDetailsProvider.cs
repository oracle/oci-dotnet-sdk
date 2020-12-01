/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.IO;
using Oci.Common.Utils;

namespace Oci.Common.Auth
{
    /// <summary>
    /// An Authentication details provider to provide delegation tokens from config file and generate service tokens from instance principals
    /// for actual signing. 
    /// </summary>
    public class ConfigFileInstancePrincipalsAuthenticationDetailsProvider : InstancePrincipalsAuthenticationDetailsProvider, IUserDelegationDetailsProvider
    {
        public string TenantId { get; }
        public ISupplier<string> DelegationTokenSupplier { get; }

        public ConfigFileInstancePrincipalsAuthenticationDetailsProvider(string profile) : this(ConfigFileReader.ParseDefault(profile))
        { }

        public ConfigFileInstancePrincipalsAuthenticationDetailsProvider(string configurationFilePath, string profile) : this(ConfigFileReader.Parse(configurationFilePath, profile))
        { }

        /// <summary>
        /// Constructor. Reads tenancy id, delegation token and an optional Region value from a ConfigFile object.
        /// </summary>
        public ConfigFileInstancePrincipalsAuthenticationDetailsProvider(ConfigFile configFile)
        {
            string delegationTokenFilePath = configFile.GetValue(ConfigUtils.DELEGATION_TOKEN_FILE) ?? throw new InvalidDataException($"missing {ConfigUtils.DELEGATION_TOKEN_FILE} in config");
            DelegationTokenSupplier = new FileDelegationTokenSupplier(delegationTokenFilePath);
            TenantId = configFile.GetValue(ConfigUtils.TENANCY) ?? throw new InvalidDataException($"missing {ConfigUtils.TENANCY} in config");
            Region region;
            ConfigUtils.SetRegion(configFile, out region);
            this.Region = region;
        }

        public string GetDelegationToken()
        {
            return DelegationTokenSupplier?.GetKey();
        }

        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
    }
}
