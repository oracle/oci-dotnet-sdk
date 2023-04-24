/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using Oci.Common.Internal;

namespace Oci.Common.Utils
{
    /// <summary>Utility class to process Realm Specific Endpoint Templates.</summary>
    public class RealmSpecificEndpointTemplateUtils
    {

        private static readonly string OCI_REALM_SPECIFIC_SERVICE_ENDPOINT_TEMPLATE_ENABLED_ENV_VAR = "OCI_REALM_SPECIFIC_SERVICE_ENDPOINT_TEMPLATE_ENABLED";
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static bool IsRealmSpecificEndpointTemplateEnabledByDefault()
        {
            string isEnabled = Environment.GetEnvironmentVariable(OCI_REALM_SPECIFIC_SERVICE_ENDPOINT_TEMPLATE_ENABLED_ENV_VAR);
            if (!string.IsNullOrEmpty(isEnabled))
            {
                try
                {
                    return bool.Parse(isEnabled);
                }
                catch (FormatException)
                {
                    logger.Warn($"Please use either true/false for the environment variable {OCI_REALM_SPECIFIC_SERVICE_ENDPOINT_TEMPLATE_ENABLED_ENV_VAR}");
                }
            }
            return false;
        }

        public static string GetRealmSpecificEndpointTemplate(bool IsRealmSpecificEndpointTemplateEnabled, string regionId, Service service)
        {
            if (string.IsNullOrWhiteSpace(regionId))
            {
                throw new ArgumentNullException("Cannot determine the realm since regionId is null or blank. GetRealmSpecificEndpointTemplate() can only be used if regionId is set.");
            }
            try
            {
                Realm realm = Region.FromRegionId(regionId).Realm;
                if (IsRealmSpecificEndpointTemplateEnabled && service.GetServiceEndpointTemplateForRealmDictionary() == null)
                {
                    IsRealmSpecificEndpointTemplateEnabled = false;
                    logger.Warn($"Realm-specific endpoint template not defined for realm {realm.RealmId}, using non-realm-specific endpoint template instead.");
                }
                String endpointTemplateToUse;
                if (IsRealmSpecificEndpointTemplateEnabled)
                {
                    endpointTemplateToUse = EndpointBuilder.GetRealmSpecificEndpointTemplate(service, regionId, realm);
                }
                else
                {
                    endpointTemplateToUse = EndpointBuilder.GetServiceEndpointTemplateToUse(service, regionId, realm);
                }
                logger.Debug("Setting endpoint template to: {}", endpointTemplateToUse);
                return endpointTemplateToUse;
            }
            catch (Exception)
            {
                string defaultEndpointTemplate = Region.FormatDefaultRegionEndpoint(service, regionId);
                logger.Warn($"Cannot determine the realm for unknown regionId: {regionId}, falling back to default endpoint format: {defaultEndpointTemplate}");
                return defaultEndpointTemplate;
            }
        }
    }
}