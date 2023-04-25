/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Oci.Common
{
    /// <summary>Class representing a service definition.</summary>
    public class Service
    {
        [Required(ErrorMessage = "ServiceName is required.")]
        public string ServiceName { get; set; }
        [Required(ErrorMessage = "ServiceEndpointPrefix is required.")]
        public string ServiceEndpointPrefix { get; set; }
        public string ServiceEndpointTemplate { get; set; }
        public string EndpointServiceName { get; set; }
        private readonly Dictionary<string, string> REALM_SPECIFIC_ENDPOINT_TEMPLATE_DICTIONARY = new Dictionary<string, string>();

        /// <summary>Returns a string showing service information.</summary>
        /// <returns>A string containing service name, endpoint prfix, and endpoint template.</returns>
        public override string ToString()
        {
            return $"ServiceName: {ServiceName}; ServiceEndpointPrefix: {ServiceEndpointPrefix}; ServiceEndpointTemplate: {ServiceEndpointTemplate}; EndpointServiceName: {EndpointServiceName}";
        }

        /// <summary>Checks if the given service is the same.</summary>
        /// <param name="service">The service to check</param>
        /// <returns>True is the given service contains the same information; false if not.</returns>
        public bool Equals(Service service)
        {
            if (ServiceName.Equals(service.ServiceName) && ServiceEndpointPrefix.Equals(service.ServiceEndpointPrefix) && ServiceEndpointTemplate.Equals(service.ServiceEndpointTemplate) && EndpointServiceName.Equals(service.EndpointServiceName))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// This method adds service endpoint templates for the realm to a dictionary
        /// </summary>
        /// <param name="realmId">The Realm Id for which the Service endpoint template is defined in spec</param>
        /// <param name="endpoint">The service endpoint to use for this Realm Id</param>
        ///
        public void AddServiceEndpointTemplateForRealm(string realmId, string endpoint)
        {
            REALM_SPECIFIC_ENDPOINT_TEMPLATE_DICTIONARY.Add(realmId, endpoint);
        }

        /// <summary>
        /// This method returns the dictionary of Realm Id to service Endpoints to use for Requests if defined by the service in their spec.
        /// </summary>
        /// <returns>A dic</returns>
        public Dictionary<string, string> GetServiceEndpointTemplateForRealmDictionary()
        {
            return REALM_SPECIFIC_ENDPOINT_TEMPLATE_DICTIONARY;
        }
    }
}
