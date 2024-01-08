/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The connection details and the discovery options for the Exadata discovery.
    /// </summary>
    public class DiscoverExternalExadataInfrastructureDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// The type of discovery.
        /// </value>
        ///
        public enum DiscoveryTypeEnum {
            [EnumMember(Value = "NEW")]
            New,
            [EnumMember(Value = "OVERRIDE")]
            Override
        };

        /// <value>
        /// The type of discovery.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DiscoveryType is required.")]
        [JsonProperty(PropertyName = "discoveryType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DiscoveryTypeEnum> DiscoveryType { get; set; }
        
        /// <value>
        /// The list of the DB system identifiers.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbSystemIds is required.")]
        [JsonProperty(PropertyName = "dbSystemIds")]
        public System.Collections.Generic.List<string> DbSystemIds { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Exadata infrastructure. This is applicable for rediscovery only.
        /// </value>
        [JsonProperty(PropertyName = "exadataInfrastructureId")]
        public string ExadataInfrastructureId { get; set; }
        
    }
}
