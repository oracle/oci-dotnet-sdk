/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// The criteria for searching associated monitored resources.
    /// </summary>
    public class SearchAssociatedResourcesDetails 
    {
        
        /// <value>
        /// Compartment Identifier [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A filter to return associated resources that match resources of type.
        /// Either resourceId or resourceType should be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }
        
        /// <value>
        /// Monitored resource identifier for which the associated resources should be fetched.
        /// Either resourceId or resourceType should be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// The field which determines the depth of hierarchy while searching for associated resources.
        /// Possible values - 0 for all levels. And positive number to indicate different levels.
        /// Default value is 1, which indicates 1st level associations.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "limitLevel")]
        public System.Nullable<int> LimitLevel { get; set; }
        
        /// <value>
        /// Association types filter to be searched for finding associated resources.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "associationTypes")]
        public System.Collections.Generic.List<string> AssociationTypes { get; set; }
        
    }
}
