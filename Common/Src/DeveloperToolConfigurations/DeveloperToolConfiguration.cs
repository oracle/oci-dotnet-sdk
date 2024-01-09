/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

using Newtonsoft.Json;

using Oci.Common.Model;
using Oci.Common.Utils;

namespace Oci.Common.DeveloperToolConfigurations
{
    /// <summary>The Developer Tool configuration in use.</summary>
    public static class DeveloperToolConfiguration
    {
        private static readonly string OCI_DEVELOPER_TOOL_CONFIGURATION_FILE_PATH = "OCI_DEVELOPER_TOOL_CONFIGURATION_FILE_PATH";
        private static readonly string OCI_ALLOW_ONLY_DEVELOPER_TOOL_CONFIGURATION_REGIONS = "OCI_ALLOW_ONLY_DEVELOPER_TOOL_CONFIGURATION_REGIONS";
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private static readonly string DEFAULT_DEVELOPER_TOOL_CONFIGURATION_FILE_PATH = Path.Combine("~", ".oci", "developer-tool-configuration.json");
        private static bool ociAllowOnlyDeveloperToolConfigurationRegions;

        private static string getParsedServiceName(string serviceName)
        {
            return Regex.Replace(serviceName.ToLower(), @"[^a-z]", "");
        }

        private static string getDeveloperToolConfigFilePath()
        {
            return FileUtils.ExpandUserHome(Environment.GetEnvironmentVariable(OCI_DEVELOPER_TOOL_CONFIGURATION_FILE_PATH) ?? DEFAULT_DEVELOPER_TOOL_CONFIGURATION_FILE_PATH);
        }

        private static void initializeDeveloperToolConfiguration()
        {
            // Initialize the OciEnabledServiceSet
            OciEnabledServiceSet = new HashSet<string>();
            DeveloperToolConfigurationRegions = new List<RegionSchema>();
            DeveloperToolConfigurationProvider = "";
            ociAllowOnlyDeveloperToolConfigurationRegions = false;
            string configFilePath = getDeveloperToolConfigFilePath();
            try
            {
                string content = File.ReadAllText(configFilePath);
                logger.Debug($"Raw content of Developer Tool config file: {content}");
                if (string.IsNullOrWhiteSpace(content))
                {
                    return;
                }

                var developerToolConfig = JsonConvert.DeserializeObject<DeveloperToolConfigFileSchema>(content, OciJsonSerializerSettings.GetDefaultJsonSerializerSettings());
                if (developerToolConfig != null)
                {
                    // Add configured services to OciEnabledServiceSet
                    foreach (string service in developerToolConfig?.services ?? Enumerable.Empty<string>())
                    {
                        OciEnabledServiceSet.Add(getParsedServiceName(service));
                    }

                    // Add configured Regions to DeveloperTool Configured Regions
                    foreach (RegionSchema region in developerToolConfig.regions ?? Enumerable.Empty<RegionSchema>())
                    {
                        DeveloperToolConfigurationRegions.Add(region);
                    }

                    // Initialize DeveloperToolConfig provider
                    if (!string.IsNullOrWhiteSpace(developerToolConfig.developerToolConfigurationProvider))
                    {
                        DeveloperToolConfigurationProvider = developerToolConfig.developerToolConfigurationProvider;
                    }

                    // Initialize ociAllowOnlyDeveloperToolConfigurationRegions from DeveloperToolConfig
                    if (!string.IsNullOrWhiteSpace(developerToolConfig.allowOnlyDeveloperToolConfigurationRegions))
                    {
                        bool.TryParse(developerToolConfig.allowOnlyDeveloperToolConfigurationRegions, out ociAllowOnlyDeveloperToolConfigurationRegions);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                logger.Debug($"Developer Tool config file not found at {configFilePath}, enabling all OCI services as default");
                return;
            }
            catch (IOException e)
            {
                logger.Warn($"Exception while reading file at {configFilePath} to fetch Developer Tool Configuration: {e}");
            }
            catch (Exception e)
            {
                logger.Warn($"Enabling all OCI services as failsafe. There was an exception while trying to read or de-serialize the Developer Tool config file at: {configFilePath}, ex:{e}");
            }
        }

        static DeveloperToolConfiguration()
        {
            initializeDeveloperToolConfiguration();
        }

        public static string DeveloperToolConfigurationProvider { get; set; }
        public static HashSet<string> OciEnabledServiceSet { get; set; }
        public static List<RegionSchema> DeveloperToolConfigurationRegions { get; set; }

        public static bool IsServiceEnabled(string service)
        {
            // Convert the service name to lower case to avoid match failure in list
            service = getParsedServiceName(service);
            if (OciEnabledServiceSet == null)
            {
                initializeDeveloperToolConfiguration();
            }
            // If OciEnabledServiceSet is empty then we enable all services.
            if (OciEnabledServiceSet.Count == 0)
            {
                logger.Debug("The OciEnabledServiceSet is empty, all OCI services are enabled");
                return true;
            }
            return OciEnabledServiceSet.Contains(service);
        }

        public static bool IsOCIAllowOnlyDeveloperToolConfigurationRegionsEnabled()
        {
            string ociRegionCoexistFromEnvironmentVariable = Environment.GetEnvironmentVariable(OCI_ALLOW_ONLY_DEVELOPER_TOOL_CONFIGURATION_REGIONS);
            if (!string.IsNullOrEmpty(ociRegionCoexistFromEnvironmentVariable))
            {
                logger.Debug($"The environment variable {OCI_ALLOW_ONLY_DEVELOPER_TOOL_CONFIGURATION_REGIONS} is set to {ociRegionCoexistFromEnvironmentVariable}");
                bool.TryParse(ociRegionCoexistFromEnvironmentVariable, out bool result);
                return result;
            }
            return ociAllowOnlyDeveloperToolConfigurationRegions;
        }

        public static bool DoesDeveloperToolConfigurationFileExist()
        {
            return File.Exists(getDeveloperToolConfigFilePath());
        }

        public static bool UseOnlyDeveloperToolConfigurationRegions()
        {
            return IsOCIAllowOnlyDeveloperToolConfigurationRegionsEnabled() && (DoesDeveloperToolConfigurationFileExist() || DeveloperToolConfigurationRegions.Count != 0);
        }

        public static void ReInitialize()
        {
            Region.ResetDeveloperToolConfig();
            Realm.ResetDeveloperToolConfig();
            initializeDeveloperToolConfiguration();
        }
    }
}