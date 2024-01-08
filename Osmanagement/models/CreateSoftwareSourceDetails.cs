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


namespace Oci.OsmanagementService.Models
{
    /// <summary>
    /// Description of a software source to be created on the management system
    /// </summary>
    public class CreateSoftwareSourceDetails 
    {
        
        /// <value>
        /// OCID for the Compartment
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// User friendly name for the software source
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Information specified by the user about the software source
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The architecture type supported by the Software Source
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ArchType is required.")]
        [JsonProperty(PropertyName = "archType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ArchTypes> ArchType { get; set; }
        
        /// <value>
        /// Name of the person maintaining this software source
        /// </value>
        [JsonProperty(PropertyName = "maintainerName")]
        public string MaintainerName { get; set; }
        
        /// <value>
        /// Email address of the person maintaining this software source
        /// </value>
        [JsonProperty(PropertyName = "maintainerEmail")]
        public string MaintainerEmail { get; set; }
        
        /// <value>
        /// Phone number of the person maintaining this software source
        /// </value>
        [JsonProperty(PropertyName = "maintainerPhone")]
        public string MaintainerPhone { get; set; }
        
        /// <value>
        /// The yum repository checksum type used by this software source
        /// </value>
        [JsonProperty(PropertyName = "checksumType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ChecksumTypes> ChecksumType { get; set; }
        
        /// <value>
        /// OCID for the parent software source, if there is one
        /// </value>
        [JsonProperty(PropertyName = "parentId")]
        public string ParentId { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
