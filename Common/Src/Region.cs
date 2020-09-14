/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Oci.Common.Internal;

namespace Oci.Common
{
    /// <summary>
    /// Class containing all of the known Regions that can be contacted.
    /// <br/>
    /// Note, not all services may be available in all regions.
    /// </summary>
    public class Region
    {
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private static readonly Dictionary<string, Region> KNOWN_REGIONS = new Dictionary<string, Region>();

        // OC1
        public static readonly Region AP_CHUNCHEON_1 = Register("ap-chuncheon-1", Realm.OC1, "yny");
        public static readonly Region AP_HYDERABAD_1 = Register("ap-hyderabad-1", Realm.OC1, "hyd");
        public static readonly Region AP_MELBOURNE_1 = Register("ap-melbourne-1", Realm.OC1, "mel");
        public static readonly Region AP_MUMBAI_1 = Register("ap-mumbai-1", Realm.OC1, "bom");
        public static readonly Region AP_OSAKA_1 = Register("ap-osaka-1", Realm.OC1, "kix");
        public static readonly Region AP_SEOUL_1 = Register("ap-seoul-1", Realm.OC1, "icn");
        public static readonly Region AP_SYDNEY_1 = Register("ap-sydney-1", Realm.OC1, "syd");
        public static readonly Region AP_TOKYO_1 = Register("ap-tokyo-1", Realm.OC1, "nrt");
        public static readonly Region CA_MONTREAL_1 = Register("ca-montreal-1", Realm.OC1, "yul");
        public static readonly Region CA_TORONTO_1 = Register("ca-toronto-1", Realm.OC1, "yyz");
        public static readonly Region EU_AMSTERDAM_1 = Register("eu-amsterdam-1", Realm.OC1, "ams");
        public static readonly Region EU_FRANKFURT_1 = Register("eu-frankfurt-1", Realm.OC1, "fra");
        public static readonly Region EU_ZURICH_1 = Register("eu-zurich-1", Realm.OC1, "zrh");
        public static readonly Region ME_JEDDAH_1 = Register("me-jeddah-1", Realm.OC1, "jed");
        public static readonly Region SA_SAOPAULO_1 = Register("sa-saopaulo-1", Realm.OC1, "gru");
        public static readonly Region UK_LONDON_1 = Register("uk-london-1", Realm.OC1, "lhr");
        public static readonly Region US_ASHBURN_1 = Register("us-ashburn-1", Realm.OC1, "iad");
        public static readonly Region US_PHOENIX_1 = Register("us-phoenix-1", Realm.OC1, "phx");
        public static readonly Region US_SANJOSE_1 = Register("us-sanjose-1", Realm.OC1, "sjc");

        // OC2
        public static readonly Region US_LANGLEY_1 = Register("us-langley-1", Realm.OC2, "lfi");
        public static readonly Region US_LUKE_1 = Register("us-luke-1", Realm.OC2, "luf");

        // OC3
        public static readonly Region US_GOV_ASHBURN_1 = Register("us-gov-ashburn-1", Realm.OC3, "ric");
        public static readonly Region US_GOV_CHICAGO_1 = Register("us-gov-chicago-1", Realm.OC3, "pia");
        public static readonly Region US_GOV_PHOENIX_1 = Register("us-gov-phoenix-1", Realm.OC3, "tus");

        // OC4
        public static readonly Region UK_GOV_LONDON_1 = Register("uk-gov-london-1", Realm.OC4, "ltn");
        public static readonly Region UK_GOV_CARDIFF_1 = Register("uk-gov-cardiff-1", Realm.OC4, "brs");

        // OC8
        public static readonly Region AP_CHIYODA_1 = Register("ap-chiyoda-1", Realm.OC8, "nja");

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
            foreach (Region region in Values())
            {
                if (region.RegionId.Equals(regionId))
                {
                    return region;
                }
            }
            throw new ArgumentException($"Unable to find region from regionId {regionId}.");
        }

        /// <summary>Returns the Region object from the canonical public region id or region code.</summary>
        /// <param name="regionCodeOrId">The region id or region code.</param>
        /// <returns>The region object.</returns>
        /// <exception>Throws ArgumentException when region id is not found.</exception>
        public static Region FromRegionCodeOrId(string regionCodeOrId)
        {
            foreach (Region region in Values())
            {
                if (region.RegionCode.Equals(regionCodeOrId) || region.RegionId.Equals(regionCodeOrId))
                {
                    return region;
                }
            }
            throw new ArgumentException($"Unable to find region from regionId or regionCode {regionCodeOrId}.");
        }

        /// <summary>
        /// Return all known Regions in this version of the SDK.
        /// </summary>
        /// <returns>All known regions.</returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Region[] Values()
        {
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

            foreach (Region region in Values())
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
    }
}
