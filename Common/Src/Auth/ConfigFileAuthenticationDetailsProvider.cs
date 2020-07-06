/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IO;

namespace Oci.Common.Auth
{
    /// <summary>An authentication details provider implementation that reads all authentication information from config file.</summary>
    public class ConfigFileAuthenticationDetailsProvider : SimpleAuthenticationDetailsProvider
    {
        public ConfigFileAuthenticationDetailsProvider(string profile) : this(ConfigFileReader.ParseDefault(profile)) { }

        public ConfigFileAuthenticationDetailsProvider(string configurationFilePath, string profile) : this(ConfigFileReader.Parse(configurationFilePath, profile)) { }

        public ConfigFileAuthenticationDetailsProvider(ConfigFile configFile)
        {
            string fingerprint = configFile.GetValue("fingerprint") ?? throw new InvalidDataException("missing fingerprint in config");
            string tenantId = configFile.GetValue("tenancy") ?? throw new InvalidDataException("missing tenancy in config");
            string userId = configFile.GetValue("user") ?? throw new InvalidDataException("missing user in config");
            string pemFilePath = configFile.GetValue("key_file") ?? throw new InvalidDataException("missing key_file in config");
            string passPhrase = configFile.GetValue("pass_phrase");

            Region region = null;
            string regionId = configFile.GetValue("region");
            if (regionId != null)
            {
                try
                {
                    region = Region.FromRegionId(regionId);
                }
                catch (Exception e)
                {
                    logger.Info($"Found regionId '{regionId}' in config file, but not supported by this version of the SDK: {e}");
                    region = Region.Register(regionId, Realm.OC1);
                }
            }
            else
            {
                logger.Info("Region not specified in Config file. Proceeding without setting a region.");
            }

            Fingerprint = fingerprint;
            TenantId = tenantId;
            UserId = userId;
            Region = region;
            PrivateKeySupplier = new FilePrivateKeySupplier(pemFilePath, passPhrase);

            if (passPhrase != null)
            {
                PassPhraseCharacters = passPhrase.ToCharArray();
            }
        }
    }
}
