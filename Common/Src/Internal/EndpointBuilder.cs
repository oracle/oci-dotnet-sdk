/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Oci.Common.Internal
{
    public class EndpointBuilder
    {
        private static readonly string SERVICE_ENDPOINT_PREFIX_TEMPLATE = "{serviceEndpointPrefix}";
        private static readonly string REGION_ID_TEMPLATE = "{region}";
        private static readonly string SECOND_LEVEL_DOMAIN_TEMPLATE = "{secondLevelDomain}";
        public static readonly string DEFAULT_ENDPOINT_TEMPLATE = $"https://{SERVICE_ENDPOINT_PREFIX_TEMPLATE}.{REGION_ID_TEMPLATE}.{SECOND_LEVEL_DOMAIN_TEMPLATE}";
        private static readonly Dictionary<string, string> OVERRIDE_REGION_IDS = new Dictionary<string, string>();

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static string CreateEndpoint(Service service, string regionId, Realm realm)
        {
            if (service == null || regionId == null || realm == null)
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

            return BuildEndpoint(endpointTemplateToUse, regionIdToUse, service.ServiceEndpointPrefix, realm.SecondLevelDomain);
        }

        public static string CreateEndpoint(Service service, Region region)
        {
            if (service == null || region == null)
            {
                throw new ArgumentNullException();
            }
            return CreateEndpoint(service, region.RegionId, region.Realm);
        }

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