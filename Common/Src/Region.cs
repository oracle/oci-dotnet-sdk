/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

using Newtonsoft.Json;

using Oci.Common.Internal;
using Oci.Common.Model;
using Oci.Common.Utils;

namespace Oci.Common
{
    /// <summary>
    /// Class containing all of the known Regions that can be contacted.
    /// <br/>
    /// Note, not all services may be available in all regions.
    /// </summary>
    public partial class Region
    {
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private static readonly Dictionary<string, Region> KNOWN_REGIONS = new Dictionary<string, Region>();
        private static readonly string OCI_REGION_METADATA_ENV_VAR_NAME = "OCI_REGION_METADATA";
        private static readonly string REGIONS_CONFIG_FILE_PATH = Path.Combine("~", ".oci", "regions-config.json");
        private static volatile bool HasUsedEnvVar = false;
        private static volatile bool HasUsedConfigFile = false;
        private static volatile bool HasUsedInstanceMetadataService = false;
        private static volatile bool HasReceivedInstanceMetadataServiceResponse = false;
        private static volatile bool HasWarnedAboutValuesWithoutInstanceMetadataService = false;
        private static volatile bool HasOptedForInstanceMetadataService = false;
        private static Region RegionFromIMDS = null;
        private static RegionSchema RegionSchemaFromIMDS = null;
        private static readonly string METADATA_SERVICE_BASE_URL = "http://169.254.169.254/";
        private static readonly string METADATA_SERVICE_API_URL = "opc/v2/instance/regionInfo/";

        /// <summary>The region identifier as defined in https://docs.cloud.oracle.com/iaas/Content/General/Concepts/regions.htm</summary>
        public string RegionId { get; }

        /// <summary>The region key as defined in https://docs.cloud.oracle.com/iaas/Content/General/Concepts/regions.htm</summary>
        public string RegionCode { get; }

        /// <summary>The realm this region belongs to.</summary>
        public Realm Realm { get; }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private Region(string regionId, string regionCode, Realm realm)
        {
            if (regionId == null || realm == null)
            {
                throw new ArgumentNullException();
            }
            RegionId = regionId;
            RegionCode = regionCode;
            Realm = realm;

            KNOWN_REGIONS.Add(regionId, this);
        }

        /// <summary>Resolves a service name to its endpoint in the region, if available.</summary>
        /// <param name="service">The service.</param>
        /// <returns>The endpoint for the given service, or empty if the service endpoint is not known.</returns>
        public string GetEndpoint(Service service)
        {
            return FormatDefaultRegionEndpoint(service, this);
        }

        /// <summary>Enables contact to IMDS (Instance Metadata Service, only available on OCI instances) if user decides to opt-in</summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void EnableInstanceMetadataService()
        {
            HasOptedForInstanceMetadataService = true;
        }

        /// <summary>Instructs the SDK to not contact the IMDS (Instance Metadata Service, only available on OCI instances).</summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void SkipInstanceMetadataService()
        {
            HasUsedInstanceMetadataService = true;
            HasOptedForInstanceMetadataService = false;
        }

        /// <summary> Resets the HasUsedEnvVar check for Region Metadata </summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void ResetEnvironmentVariableInUse()
        {
            HasUsedEnvVar = false;
        }


        /// <summary> Resets the HasUsedConfigFile check for reading Region Metadata from region config file</summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void ResetConfigFileInUse()
        {
            HasUsedConfigFile = false;
        }

        /// <summary>
        /// Creates a default endpoint URL for the given service in the given region.
        /// <br/>
        /// Note, the region is not validated against known regions, this just creates
        /// a URL that follows the default format.
        /// </summary>
        /// <param name="service">The service.</param>
        /// <param name="region">The region.</param>
        /// <returns>The endpoint constructed from the service and region.</returns>
        public static string FormatDefaultRegionEndpoint(Service service, Region region)
        {
            return EndpointBuilder.CreateEndpoint(service, region);
        }

        /// <summary>
        /// Creates a default endpoint URL for the given service in the given region.
        /// <br/>
        /// Note, the regionId is not validated against known regions, this just creates
        /// a URL that follows the default format.
        /// </summary>
        /// <param name="service">The service.</param>
        /// <param name="regionId">The region.</param>
        /// <returns>The endpoint constructed from the service and region.</returns>
        public static string FormatDefaultRegionEndpoint(Service service, string regionId)
        {
            // Try to get a real region first.
            Region region = FromRegionId(regionId);
            if (region != null)
            {
                return FormatDefaultRegionEndpoint(service, region);
            }
            else
            {
                // Else we need to fall back to OC1 SLD.
                logger.Debug($"Unknown regionId '{regionId}', will assume it's in Realm OC1");
                return EndpointBuilder.CreateEndpoint(service, regionId, Realm.OC1);
            }
        }

        /// <summary>Returns the Region object from the canonical public region id.</summary>
        /// <param name="regionId">The region id.</param>
        /// <returns>The region object.</returns>
        /// <exception>Throws ArgumentException when region id is not found.</exception>
        public static Region FromRegionId(string regionId)
        {
            Region region = GetRegionAndRegisterIfNeccessary(regionId);
            if (region == null)
            {
                throw new ArgumentException($"Unable to find region from regionId {regionId}.");
            }
            return region;
        }

        /// <summary>Returns the Region object from the canonical public region id or region code.</summary>
        /// <param name="regionCodeOrId">The region id or region code.</param>
        /// <returns>The region object.</returns>
        /// <exception>Throws ArgumentException when region id is not found.</exception>
        public static Region FromRegionCodeOrId(string regionCodeOrId)
        {
            Region region = GetRegionAndRegisterIfNeccessary(regionCodeOrId);
            if (region == null)
            {
                throw new ArgumentException($"Unable to find region from regionId or regionCode {regionCodeOrId}.");
            }
            return region;
        }

        /// <summary>
        /// Return all known Regions in this version of the SDK.
        /// </summary>
        /// <returns>All known regions.</returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Region[] Values()
        {
            if (!HasUsedInstanceMetadataService && !HasWarnedAboutValuesWithoutInstanceMetadataService)
            {
                logger.Warn(
                "Call to Regions.Values() without having contacted IMDS (Instance Metadata Service, only available on OCI instances)" +
                "If you do need the region from IMDS, call Region.RegisterFromInstanceMetadataService() before calling Region.Values()");
                HasWarnedAboutValuesWithoutInstanceMetadataService = true;
            }
            RegisterAllRegions();
            return KNOWN_REGIONS.Values.ToArray();
        }

        /// <summary>Register a new region. Used to allow the SDK to be forward compatible with unreleased regions.</summary>
        /// <param name="regionId">The region id.</param>
        /// <param name="realm">The realm of the new region.</param>
        /// <returns>The registered region (or existing one if found).</returns>
        public static Region Register(string regionId, Realm realm)
        {
            if (regionId == null || realm == null)
            {
                throw new ArgumentNullException();
            }
            return Register(regionId, realm, null);
        }

        /// <summary>Register a new region. Used to allow the SDK to be forward compatible with unreleased regions.</summary>
        /// <param name="regionId">The region id.</param>
        /// <param name="realm">The realm of the new region.</param>
        /// <param name="regionCode">The 3-letter region code.</param>
        /// <returns>The registered region (or existing one if found).</returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Region Register(string regionId, Realm realm, string regionCode)
        {
            if (regionId == null || realm == null)
            {
                throw new ArgumentNullException();
            }

            regionId = regionId.Trim().ToLower(new CultureInfo("en-US", false));

            if (string.IsNullOrEmpty(regionId))
            {
                throw new ArgumentNullException("Cannot have empty regionId");
            }

            foreach (Region region in KNOWN_REGIONS.Values)
            {
                if (region.RegionId.Equals(regionId))
                {
                    if (!region.Realm.Equals(realm))
                    {
                        throw new ArgumentException($"Region : {regionId} is already registered with {region.Realm}. It cannot be re-registered with a different realm.");
                    }
                    return region;
                }
            }

            if (regionCode != null)
            {
                regionCode = regionCode.Trim().ToLower(new CultureInfo("en-Us", false));
                if (string.IsNullOrEmpty(regionCode))
                {
                    regionCode = null;
                }
            }

            return new Region(regionId, regionCode, realm);
        }

        /// <summary>Gets Region from Region Id or Region Code</summary>
        /// <param name="regionCodeOrId">The region code/Id.</param>
        /// <returns>Region corresponding to the region code or Id</returns>
        private static Region GetRegionFromRegionCodeOrIdWithoutRegistering(string regionCodeOrId)
        {
            foreach (Region region in KNOWN_REGIONS.Values)
            {
                if ((region.RegionId != null && region.RegionId.Equals(regionCodeOrId)) || (region.RegionCode != null && region.RegionCode.Equals(regionCodeOrId)))
                {
                    return region;
                }
            }
            return null;
        }

        /// <summary>Gets Region from Region Id or Region Code and registers it if neccessary</summary>
        /// <param name="regionCodeOrId">The region code/Id.</param>
        /// <returns>Region corresponding to the region code or Id</returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        private static Region GetRegionAndRegisterIfNeccessary(string regionCodeOrId)
        {

            Region region = GetRegionFromRegionCodeOrIdWithoutRegistering(regionCodeOrId);
            if (region != null)
            {
                return region;
            }

            if (!HasUsedConfigFile)
            {
                RegisterRegionFromRegionConfigFile(); //sets HasUsedConfigFile to true.
                region = GetRegionFromRegionCodeOrIdWithoutRegistering(regionCodeOrId);
                if (region != null)
                {
                    return region;
                }
            }

            if (!HasUsedEnvVar)
            {
                RegisterRegionFromRegionEnvironmentVariable(); //sets HasUsedEnvVar to true.
                region = GetRegionFromRegionCodeOrIdWithoutRegistering(regionCodeOrId);
                if (region != null)
                {
                    return region;
                }
            }

            if (HasOptedForInstanceMetadataService && !HasUsedInstanceMetadataService)
            {
                RegisterRegionFromInstanceMetadataService();
                region = GetRegionFromRegionCodeOrIdWithoutRegistering(regionCodeOrId);
            }
            return region;
        }

        /// <summary> Registers all regions from Regions Config file and/or OCI_REGION_METADATA Environment Variable</summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        private static void RegisterAllRegions()
        {
            if (!HasUsedConfigFile)
            {
                RegisterRegionFromRegionConfigFile();
            }
            if (!HasUsedEnvVar)
            {
                RegisterRegionFromRegionEnvironmentVariable();
            }
        }

        /// <summary>Registers region and sets HasUsedConfigFile status to true</summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        private static void RegisterRegionFromRegionConfigFile()
        {
            var regionConfigFile = FileUtils.ExpandUserHome(REGIONS_CONFIG_FILE_PATH);
            HasUsedConfigFile = true;
            if (!File.Exists(regionConfigFile))
            {
                logger.Info($"Region config file not found to fetch regions at {regionConfigFile}");
                return;
            }
            try
            {
                var content = File.ReadAllText(regionConfigFile);
                logger.Info("Region schemas from regions-config.json are {}", content);
                if (String.IsNullOrEmpty(content))
                {
                    return;
                }
                try
                {
                var regionSchemas = JsonConvert.DeserializeObject<List<RegionSchema>>(content);
                    if (regionSchemas != null)
                    {
                        foreach (RegionSchema regionSchema in regionSchemas)
                        {
                            if (regionSchema != null && regionSchema.isValid())
                            {
                                Register(regionSchema.regionIdentifier, Realm.Register(regionSchema.realmKey, regionSchema.realmDomainComponent), regionSchema.regionKey);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    logger.Warn($"Unable to convert the Region metadata read from {REGIONS_CONFIG_FILE_PATH} due to exception: {e}");
                }
            }
            catch (Exception e)
            {
                logger.Warn($"Exception in reading or parsing {FileUtils.ExpandUserHome(REGIONS_CONFIG_FILE_PATH)} to fetch regions: {e}");
            }
        }

        ///<summary>Registers region and sets HasUsedEnvVar status to true.</summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        private static void RegisterRegionFromRegionEnvironmentVariable()
        {
            var regionMetadataEnvVar = Environment.GetEnvironmentVariable(OCI_REGION_METADATA_ENV_VAR_NAME);
            HasUsedEnvVar = true;
            logger.Info($"Region metadata schema from OCI_REGION_METADATA env variable is:{regionMetadataEnvVar}");
            if (!String.IsNullOrEmpty(regionMetadataEnvVar))
            {
                var regionSchema = JsonConvert.DeserializeObject<RegionSchema>(regionMetadataEnvVar);
                try
                {
                    if (regionSchema != null && regionSchema.isValid())
                    {
                        Register(regionSchema.regionIdentifier, Realm.Register(regionSchema.realmKey, regionSchema.realmDomainComponent), regionSchema.regionKey);
                    }
                }
                catch (Exception e)
                {
                    logger.Warn($"Unable to convert the region metadata from {OCI_REGION_METADATA_ENV_VAR_NAME} due to exception: {e}");
                }
            }
            else
            {
                logger.Info($"{OCI_REGION_METADATA_ENV_VAR_NAME} environment variable is not set");
            }
        }

        /// <summary> Send request to IMDS (Instance Metadata Service, only available on OCI instances) </summary>
        /// <returns> RegionSchema extracted from the IMDS </returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static RegionSchema GetRegionSchemaFromInstanceMetaDataService()
        {
            if (HasReceivedInstanceMetadataServiceResponse)
            {
                return RegionSchemaFromIMDS;
            }
            var client = new HttpClient();
            try
            {
                logger.Info($"Requesting region metadata blob from IMDS at {METADATA_SERVICE_BASE_URL}{METADATA_SERVICE_API_URL}");
                client.BaseAddress = new Uri(METADATA_SERVICE_BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "Oracle");
                client.DefaultRequestHeaders.UserAgent.ParseAdd(HttpUtils.BuildUserAgent(""));
                var response = client.GetAsync(METADATA_SERVICE_API_URL).Result;
                if (response.IsSuccessStatusCode)
                {
                    var regionMetadata = response.Content.ReadAsStringAsync().Result;
                    logger.Debug($"Response from IMDS: {regionMetadata}");
                    if (!String.IsNullOrEmpty(regionMetadata))
                    {
                        RegionSchemaFromIMDS = JsonConvert.DeserializeObject<RegionSchema>(regionMetadata);
                        logger.Debug($"Region read from IMDS Id:{RegionSchemaFromIMDS.regionIdentifier} Realm:{RegionSchemaFromIMDS.realmKey} Domain:{RegionSchemaFromIMDS.realmDomainComponent} Key:{RegionSchemaFromIMDS.regionKey}");
                    }
                }
                else
                {
                    logger.Info($"Request to Instance Metadata Service failed: {response.StatusCode} ({response.ReasonPhrase})");
                }
            }
            catch (Exception e)
            {
                logger.Warn($"Region Schema read from Instance Metadata Service due to expception: {e}");
            }
            finally
            {
                client.Dispose();
            }
            return RegionSchemaFromIMDS;
        }

        /// <summary> Calls GetRegionSchemaFromInstanceMetaDataService , only available on OCI instances), registers region</summary>
        /// <returns> Returns Region registered from InstanceMetadataServiceResponse</returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Region RegisterRegionFromInstanceMetadataService()
        {
            if (HasUsedInstanceMetadataService)
            {
                return RegionFromIMDS;
            }
            EnableInstanceMetadataService();
            HasUsedInstanceMetadataService = true;
            var regionSchema = GetRegionSchemaFromInstanceMetaDataService();
            if (regionSchema != null && regionSchema.isValid())
            {
                HasReceivedInstanceMetadataServiceResponse = true;
                RegionFromIMDS = Register(regionSchema.regionIdentifier, Realm.Register(regionSchema.realmKey, regionSchema.realmDomainComponent), regionSchema.regionKey);
            }
            return RegionFromIMDS;
        }
    }
}
