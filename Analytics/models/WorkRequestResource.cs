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


namespace Oci.AnalyticsService.Models
{
    
    public class WorkRequestResource 
    {
        
        /// <value>
        /// The way in which this resource was affected by this work request.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActionResult is required.")]
        [JsonProperty(PropertyName = "actionResult")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<WorkRequestActionResult> ActionResult { get; set; }
        
        /// <value>
        /// The type of the resource the work request is affecting.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceType is required.")]
        [JsonProperty(PropertyName = "resourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<WorkRequestResourceType> ResourceType { get; set; }
        
        /// <value>
        /// The OCID of the resource the work request is affecting.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Identifier is required.")]
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        /// <value>
        /// The URI of the affected resource.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceUri is required.")]
        [JsonProperty(PropertyName = "resourceUri")]
        public string ResourceUri { get; set; }
        
        /// <value>
        /// Additional metadata of the resource.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }
        
    }
}
