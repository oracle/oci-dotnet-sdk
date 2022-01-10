/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.ComponentModel.DataAnnotations;

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

        /// <summary>Returns a string showing service information.</summary>
        /// <returns>A string containing service name, endpoint prfix, and endpoint template.</returns>
        public override string ToString()
        {
            return $"ServiceName: {ServiceName}; ServiceEndpointPrefix: {ServiceEndpointPrefix}; ServiceEndpointTemplate: {ServiceEndpointTemplate}";
        }

        /// <summary>Checks if the given service is the same.</summary>
        /// <param name="service">The service to check</param>
        /// <returns>True is the given service contains the same information; false if not.</returns>
        public bool Equals(Service service)
        {
            if (ServiceName.Equals(service.ServiceName) && ServiceEndpointPrefix.Equals(service.ServiceEndpointPrefix) && ServiceEndpointTemplate.Equals(service.ServiceEndpointTemplate))
            {
                return true;
            }
            return false;
        }
    }
}
