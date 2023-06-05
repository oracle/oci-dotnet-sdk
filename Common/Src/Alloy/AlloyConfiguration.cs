/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
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

namespace Oci.Common.Alloy
{
    /// <summary>The Alloy configuration in use.</summary>
    public static class AlloyConfiguration
    {
        private static readonly string OCI_ALLOY_CONFIG_FILE_PATH = "OCI_ALLOY_CONFIG_FILE_PATH";
        private static readonly string OCI_ALLOY_REGION_COEXIST = "OCI_ALLOY_REGION_COEXIST";
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private static readonly string DEFAULT_ALLOY_CONFIG_FILE_PATH = Path.Combine("~", ".oci", "alloy-config.json");
        private static bool ociRegionCoexist;

        private static string getParsedServiceName(string serviceName)
        {
            return Regex.Replace(serviceName.ToLower(), @"[^a-z]", "");
        }

        private static string getAlloyConfigFilePath()
        {
            return FileUtils.ExpandUserHome(Environment.GetEnvironmentVariable(OCI_ALLOY_CONFIG_FILE_PATH) ?? DEFAULT_ALLOY_CONFIG_FILE_PATH);
        }

        private static void initializeAlloyConfiguration()
        {
            // Initialize the OciEnabledServiceSet
            OciEnabledServiceSet = new HashSet<string>();
            AlloyConfiguredRegions = new List<RegionSchema>();
            OciAlloyProvider = "";
            ociRegionCoexist = false;
            string configFilePath = getAlloyConfigFilePath();
            try
            {
                string content = File.ReadAllText(configFilePath);
                logger.Debug($"Raw content of Alloy config file: {content}");
                if (string.IsNullOrWhiteSpace(content))
                {
                    return;
                }

                var alloyConfig = JsonConvert.DeserializeObject<AlloyConfigFileSchema>(content, OciJsonSerializerSettings.GetDefaultJsonSerializerSettings());
                if (alloyConfig != null)
                {
                    // Add configured services to OciEnabledServiceSet
                    foreach (string service in alloyConfig?.services ?? Enumerable.Empty<string>())
                    {
                        OciEnabledServiceSet.Add(getParsedServiceName(service));
                    }

                    // Add configured Regions to AlloyConfiguredRegions
                    foreach (RegionSchema region in alloyConfig.regions ?? Enumerable.Empty<RegionSchema>())
                    {
                        AlloyConfiguredRegions.Add(region);
                    }

                    // Initialize Alloy provider
                    if (!string.IsNullOrWhiteSpace(alloyConfig.alloyProvider))
                    {
                        OciAlloyProvider = alloyConfig.alloyProvider;
                    }

                    // Initialize ociRegionCoexist from Alloy config
                    if (!string.IsNullOrWhiteSpace(alloyConfig.ociRegionCoexist))
                    {
                        bool.TryParse(alloyConfig.ociRegionCoexist, out ociRegionCoexist);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                logger.Debug($"Alloy config file not found at {configFilePath}, enabling all OCI services as default");
                return;
            }
            catch (IOException e)
            {
                logger.Warn($"Exception while reading file at {configFilePath} to fetch Alloy Configuration: {e}");
            }
            catch (Exception e)
            {
                logger.Warn($"Enabling all OCI services as failsafe. There was an exception while trying to read or de-serialize the alloy config file at: {configFilePath}, ex:{e}");
            }
        }

        static AlloyConfiguration()
        {
            initializeAlloyConfiguration();
        }

        public static string OciAlloyProvider { get; set; }
        public static HashSet<string> OciEnabledServiceSet { get; set; }
        public static List<RegionSchema> AlloyConfiguredRegions { get; set; }

        public static bool IsServiceEnabled(string service)
        {
            // Convert the service name to lower case to avoid match failure in list
            service = getParsedServiceName(service);
            if (OciEnabledServiceSet == null)
            {
                initializeAlloyConfiguration();
            }
            // If OciEnabledServiceSet is empty then we enable all services.
            if (OciEnabledServiceSet.Count == 0)
            {
                logger.Debug("The OciEnabledServiceSet is empty, all OCI services are enabled");
                return true;
            }
            return OciEnabledServiceSet.Contains(service);
        }

        public static bool IsOCIAlloyRegionCoexistEnabled()
        {
            string ociRegionCoexistFromEnvironmentVariable = Environment.GetEnvironmentVariable(OCI_ALLOY_REGION_COEXIST);
            if (!string.IsNullOrEmpty(ociRegionCoexistFromEnvironmentVariable))
            {
                logger.Debug($"The environment variable {OCI_ALLOY_REGION_COEXIST} is set to {ociRegionCoexistFromEnvironmentVariable}");
                bool.TryParse(ociRegionCoexistFromEnvironmentVariable, out bool result);
                return result;
            }
            return ociRegionCoexist;
        }

        public static bool DoesAlloyConfigFileExist()
        {
            return File.Exists(getAlloyConfigFilePath());
        }

        public static bool UseOnlyAlloyRegions()
        {
            return !IsOCIAlloyRegionCoexistEnabled() && (DoesAlloyConfigFileExist() || AlloyConfiguredRegions.Count != 0);
        }

        public static void ReInitialize()
        {
            Region.ResetAlloyConfig();
            Realm.ResetAlloyConfig();
            initializeAlloyConfiguration();
        }
    }
}