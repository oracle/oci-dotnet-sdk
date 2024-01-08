/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;

namespace Oci.Common.Utils
{
    /// <summary>
    /// Config file utility class.
    /// </summary>
    public class ConfigUtils
    {
        public static readonly string DELEGATION_TOKEN_FILE = "delegation_token_file";
        public static readonly string TENANCY = "tenancy";
        public static readonly string USER = "user";
        public static readonly string PASS_PHRASE = "pass_phrase";
        public static readonly string KEY_FILE = "key_file";
        public static readonly string FINGERPRINT = "fingerprint";
        public static readonly string AUTH_TYPE_IDENTIFIER = "authentication_type";
        public static readonly string AUTH_TYPE_INSTANCE_PRINCIPAL = "instance_principal";
        public static readonly string REGION_ENV_VAR_NAME = "OCI_REGION";
        public static readonly string SESSION_TOKEN_FILE = "security_token_file";

        /// <summary>
        /// Sets the out variable with the, region id available in the config file. Otherwise,
        /// Sets the region id from OCI_REGION.
        /// </summary>
        public static void SetRegion(ConfigFile configFile, out Region region)
        {
            string regionId = configFile.GetValue("region");
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
                logger.Info("Region not specified in Config file or environment variable. Proceeding without setting a region.");
                region = null;
            }
        }

        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
    }
}
