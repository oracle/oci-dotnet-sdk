/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Oci.Common.Internal
{
    /// <summary>
    /// EndpointBuilder provides a wrapper to construct the appropriate
    /// endpoint for a service.  The service may override the endpoint template, but
    /// if not, a default template will be used.
    /// </summary>
    public class EndpointBuilder
    {
        private static readonly string SERVICE_ENDPOINT_PREFIX_TEMPLATE = "{serviceEndpointPrefix}";
        private static readonly string REGION_ID_TEMPLATE = "{region}";
        private static readonly string SECOND_LEVEL_DOMAIN_TEMPLATE = "{secondLevelDomain}";
        public static readonly string DEFAULT_ENDPOINT_TEMPLATE = $"https://{SERVICE_ENDPOINT_PREFIX_TEMPLATE}.{REGION_ID_TEMPLATE}.{SECOND_LEVEL_DOMAIN_TEMPLATE}";
        private static readonly Dictionary<string, string> OVERRIDE_REGION_IDS = new Dictionary<string, string>();

        /// <summary>Creates the service endpoint</summary>
        /// <param name="service">The service.</param>
        /// <param name="regionId">The region id.</param>
        /// <param name="secondLevelDomain">The second level domain for the realm this region belongs to.</param>
        /// <returns>The endpoint (protocol + FQDN) for this service.</returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static string CreateEndpoint(Service service, string regionId, string secondLevelDomain)
        {
            if (service == null || String.IsNullOrWhiteSpace(regionId) || String.IsNullOrWhiteSpace(secondLevelDomain))
            {
                throw new ArgumentNullException();
            }

            string endpointTemplateToUse;

            if (!string.IsNullOrEmpty(service.ServiceEndpointTemplate))
            {
                endpointTemplateToUse = service.ServiceEndpointTemplate;
            }
            else
            {
                endpointTemplateToUse = DEFAULT_ENDPOINT_TEMPLATE;
            }

            if (!OVERRIDE_REGION_IDS.TryGetValue(regionId, out var regionIdToUse))
            {
                regionIdToUse = regionId;
            }

            return BuildEndpoint(endpointTemplateToUse, regionIdToUse, service.ServiceEndpointPrefix, secondLevelDomain);
        }

        /// <summary>Creates the service endpoint</summary>
        /// <param name="service">The service.</param>
        /// <param name="regionId">The region id.</param>
        /// <param name="realm">The realm this region belongs to.</param>
        /// <returns>The endpoint (protocol + FQDN) for this service.</returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static string CreateEndpoint(Service service, string regionId, Realm realm)
        {
            if (realm == null)
            {
                throw new ArgumentNullException();
            }
            return CreateEndpoint(service, regionId, realm.SecondLevelDomain);
        }

        /// <summary>Creates the service endpoint from region.</summary>
        /// <param name="service">The service.</param>
        /// <param name="region">The region id.</param>
        /// <returns>The endpoint (protocol + FQDN) for this service.</returns>
        public static string CreateEndpoint(Service service, Region region)
        {
            if (service == null || region == null)
            {
                throw new ArgumentNullException();
            }
            return CreateEndpoint(service, region.RegionId, region.Realm);
        }

        /// <summary>Builds the service endpoint</summary>
        /// <param name="template">The endpoint template.</param>
        /// <param name="regionId">The region id.</param>
        /// <param name="endpointPrefix">The endpoint prefix.</param>
        /// <param name="secondLevelDomain">The second level domain.</param>
        /// <returns>The endpoint (protocol + FQDN) for this service.</returns>
        public static string BuildEndpoint(string template, string regionId, string endpointPrefix, string secondLevelDomain)
        {
            if (template == null || regionId == null || endpointPrefix == null || secondLevelDomain == null)
            {
                throw new ArgumentNullException();
            }

            return template.Replace(SERVICE_ENDPOINT_PREFIX_TEMPLATE, endpointPrefix)
                .Replace(REGION_ID_TEMPLATE, regionId)
                .Replace(SECOND_LEVEL_DOMAIN_TEMPLATE, secondLevelDomain);
        }
    }
}
