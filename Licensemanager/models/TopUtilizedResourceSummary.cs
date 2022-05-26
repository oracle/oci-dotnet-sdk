/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.LicensemanagerService.Models
{
    /// <summary>
    /// A summary of a top utlized resource.
    /// 
    /// </summary>
    public class TopUtilizedResourceSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceId is required.")]
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// Resource canonical name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceName is required.")]
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; set; }
        
        /// <value>
        /// The compartment [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) that contains the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceCompartmentId is required.")]
        [JsonProperty(PropertyName = "resourceCompartmentId")]
        public string ResourceCompartmentId { get; set; }
        
        /// <value>
        /// The display name of the compartment that contains the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceCompartmentName is required.")]
        [JsonProperty(PropertyName = "resourceCompartmentName")]
        public string ResourceCompartmentName { get; set; }
        
        /// <value>
        /// Number of license units consumed by the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalUnits is required.")]
        [JsonProperty(PropertyName = "totalUnits")]
        public System.Double TotalUnits { get; set; }
        
        /// <value>
        /// The resource unit.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UnitType is required.")]
        [JsonProperty(PropertyName = "unitType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ResourceUnit> UnitType { get; set; }
        
    }
}