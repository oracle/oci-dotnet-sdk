/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

using Oci.Common.DeveloperToolConfigurations;
using Oci.Common.Auth;
using Oci.Common.Http;
using Oci.Common.Http.Signing;
using Oci.Common.Utils;

namespace Oci.Common
{
    /// <summary>An abstract class for a regional service client.</summary>
    public abstract class RegionalClientBase : ClientBase
    {
        protected new static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private string regionId;

        public RegionalClientBase(IBasicAuthenticationDetailsProvider authProvider) : base(authProvider)
        { }

        public RegionalClientBase(IBasicAuthenticationDetailsProvider authProvider, RequestSigner requestSigner) : base(authProvider, requestSigner)
        { }

        public RegionalClientBase(IBasicAuthenticationDetailsProvider authProvider, ClientConfiguration clientConfiguration) : base(authProvider, clientConfiguration)
        { }

        public RegionalClientBase(IBasicAuthenticationDetailsProvider authProvider, ClientConfiguration clientConfiguration, RequestSigner requestSigner) : base(authProvider, clientConfiguration, requestSigner)
        { }

        /// <summary>Set endpoint through region.</summary>
        /// <param name="region">The region used to set endpoint.</param>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void SetRegion(Region region)
        {
            this.regionId = region.RegionId;
            if (DeveloperToolConfiguration.UseOnlyDeveloperToolConfigurationRegions())
            {
                if (!Region.Values().Any(regionSchema => regionSchema.RegionId == regionId))
                {
                    throw new ArgumentException($"You're using the {DeveloperToolConfiguration.DeveloperToolConfigurationProvider} DeveloperTool configuration file, the region you're targeting is not declared in this config file. Please check if this is the correct region you're targeting or contact the {DeveloperToolConfiguration.DeveloperToolConfigurationProvider} cloud provider for help. If you want to target both OCI regions and DeveloperToolConfig regions, please set the OCI_ALLOW_ONLY_DEVELOPER_TOOL_CONFIGURATION_REGIONS env var to False.");
                }
            }
            string endpoint = region.GetEndpoint(this.service);
            if (endpoint.Contains("{"))
            {
                SetRealmSpecificEndpointTemplate(endpoint);
                endpoint = Regex.Replace(endpoint, @"{.*?}", "");
            }
            SetEndpoint(endpoint);
        }

        /// <summary>Set endpoint through regionId.</summary>
        /// <param name="region">The region id used to set endpoint.</param>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void SetRegion(string regionId)
        {
            regionId = regionId.ToLower(new CultureInfo("en"));
            this.regionId = regionId;
            try
            {
                Region regionToUse = Region.FromRegionId(regionId);
                SetRegion(regionToUse);
            }
            catch (ArgumentException)
            {
                logger.Info($"Unknown regionId {regionId}, falling back to default endpoint format");
                String endpoint = Region.FormatDefaultRegionEndpoint(this.service, regionId);
                SetEndpoint(endpoint);
            }
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void UseRealmSpecificEndpointTemplate(bool IsRealmSpecificEndpointTemplateEnabled)
        {
            SetRealmSpecificEndpointTemplate(RealmSpecificEndpointTemplateUtils.GetRealmSpecificEndpointTemplate(IsRealmSpecificEndpointTemplateEnabled, this.regionId, this.service));
        }

        /// <summary>
        /// Populate the parameters in the endpoint with its corresponding value and update the base endpoint. The value will be populated
        /// if the parameter in endpoint is a required request path parameter or a required request query parameter. If not, the parameter
        /// in the endpoint will be ignored and left blank.
        /// </summary>
        /// <param name="restClient">The RestClient in use</param>
        /// <param name="requiredParametersDictionary">Dictionary of parameter name as key and value set in request path or query parameter as value</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Uri PopulateServiceParametersInEndpointTemplate(RestClient client, Dictionary<string, object> requiredParametersDictionary)
        {
            string endpointTemplate = string.IsNullOrWhiteSpace(client.RealmSpecificEndpointTemplate) ? client.GetEndpoint().ToString() : client.RealmSpecificEndpointTemplate;
            if (!endpointTemplate.Contains("{"))
            {
                return client.GetEndpoint();
            }
            string[] parameters = parseEndpointForParameters(endpointTemplate);
            string updatedEndpoint = null;
            // If the endpoint template has parameters but there are no required parameters, then replace the parameters with empty string.
            if (parameters != null && parameters.Length > 0 && requiredParametersDictionary.Count == 0)
            {
                updatedEndpoint = Regex.Replace(endpointTemplate, @"{.*?}", "");
                return new Uri(updatedEndpoint);
            }
            updatedEndpoint = endpointTemplate;
            foreach (string parameter in parameters)
            {
                bool appendDot = false;
                string paramName;
                // If the parameter is defined with a "+Dot" string, it means we need to append a "." after populating the paramName value
                if (parameter.EndsWith("+Dot}"))
                {
                    appendDot = true;
                    paramName = parameter.Substring(1, parameter.IndexOf("+") - 1);
                }
                else
                {
                    paramName = parameter.Substring(1, parameter.Length - 2);
                }

                if (requiredParametersDictionary.ContainsKey(paramName))
                {
                    if (requiredParametersDictionary[paramName] is string paramValue)
                    {
                        if (appendDot)
                        {
                            updatedEndpoint = updatedEndpoint.Replace(parameter, paramValue + ".");
                        }
                        else
                        {
                            updatedEndpoint = updatedEndpoint.Replace(parameter, paramValue);
                        }

                    }
                    else
                    {
                        logger.Debug($"The parameter for {paramName} cannot be populated since the value is not of type string");
                        updatedEndpoint = updatedEndpoint.Replace(parameter, "");
                        continue;
                    }

                }
                else
                {
                    updatedEndpoint = updatedEndpoint.Replace(parameter, "");
                }
            }
            return new Uri(updatedEndpoint);
        }

        /// <summary>
        /// This function extracts the parameters in the parameterized endpoint template. E.g. if endpoint is https://foo{param1+Dot}.bar{query1}.ocifake
        /// then this function returns a string array ["{param1+Dot}", "{query1}"]
        /// </summary>
        /// <param name="endpoint">Parameterized endpoint template</param>
        /// <returns>string array containing name of parameters</returns>
        public static string[] parseEndpointForParameters(string endpoint)
        {
            int startIndex = endpoint.IndexOf('{');
            int lengthToTrim = endpoint.LastIndexOf('}') - startIndex + 1;
            string trimmedEndpoint = endpoint.Substring(startIndex, lengthToTrim);
            return Regex.Matches(trimmedEndpoint, @"{(.*?)}").OfType<Match>().Select(m => m.Groups[0].Value).ToArray();
        }
    }
}
