/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IO;
using System.Security;
using Oci.Common.Utils;

namespace Oci.Common.Auth
{
    /// <summary>An authentication details provider implementation that reads all authentication information from config file.</summary>
    public class ConfigFileAuthenticationDetailsProvider : SimpleAuthenticationDetailsProvider
    {
        private static readonly string REGION_ENV_VAR_NAME = "OCI_REGION";

        /// <summary>Constructor. Reads from the config file at default location.</summary>
        public ConfigFileAuthenticationDetailsProvider(string profile, FilePrivateKeySupplier keySupplier = null) : this(ConfigFileReader.ParseDefault(profile), keySupplier) { }

        /// <summary>Constructor. Reads from the config file at given location.</summary>
        public ConfigFileAuthenticationDetailsProvider(string configurationFilePath, string profile, FilePrivateKeySupplier keySupplier = null) : this(ConfigFileReader.Parse(configurationFilePath, profile), keySupplier) { }

        /// <summary>
        /// Constructor. Reads from a ConfigFile object.
        /// If a FilePrivateKeySupplier is provided, it will be used to obtain private key. Otherwise,
        /// a FilePrivateKeySupplier object will be created based on information from configFile.
        /// If additional security checks on the private key file are needed, provide a FileSecurePrivateKeySupplier object.
        /// </summary>
        public ConfigFileAuthenticationDetailsProvider(ConfigFile configFile, FilePrivateKeySupplier keySupplier = null)
        {
            if (keySupplier == null)
            {
                string pemFilePath = configFile.GetValue("key_file") ?? throw new InvalidDataException("missing key_file in config");
                SecureString passPhrase = StringUtils.StringToSecureString(configFile.GetValue("pass_phrase"));
                SetupConfigFileAuthenticationDetailsProvider(configFile, new FilePrivateKeySupplier(pemFilePath, passPhrase));
            }
            else
            {
                SetupConfigFileAuthenticationDetailsProvider(configFile, keySupplier);
            }
        }

        private void SetupConfigFileAuthenticationDetailsProvider(ConfigFile configFile, FilePrivateKeySupplier keySupplier)
        {
            string fingerprint = configFile.GetValue("fingerprint") ?? throw new InvalidDataException("missing fingerprint in config");
            string tenantId = configFile.GetValue("tenancy") ?? throw new InvalidDataException("missing tenancy in config");
            string userId = configFile.GetValue("user") ?? throw new InvalidDataException("missing user in config");
            string regionId = configFile.GetValue("region");
            Region region = null;

            if (String.IsNullOrEmpty(regionId))
            {
                logger.Info($"Config file does not contain valid regionId. Checking environment variable {REGION_ENV_VAR_NAME}");
                regionId = Environment.GetEnvironmentVariable(REGION_ENV_VAR_NAME);
            }

            if (!String.IsNullOrEmpty(regionId))
            {
                try
                {
                    region = Region.FromRegionId(regionId);
                }
                catch (Exception e)
                {
                    logger.Info($"Found regionId '{regionId}', but not supported by this version of the SDK: {e}");
                    region = Region.Register(regionId, Realm.OC1);
                }
            }
            else
            {
                logger.Info("Region not specified in Config file or environment vairable. Proceeding without setting a region.");
            }

            Fingerprint = fingerprint;
            TenantId = tenantId;
            UserId = userId;
            Region = region;
            PrivateKeySupplier = keySupplier;
        }
    }
}
