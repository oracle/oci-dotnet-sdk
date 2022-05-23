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


namespace Oci.OsmanagementService.Models
{
    /// <summary>
    /// A module stream provided by a software source
    /// </summary>
    public class ModuleStream 
    {
        
        /// <value>
        /// The name of the module that contains the stream
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModuleName is required.")]
        [JsonProperty(PropertyName = "moduleName")]
        public string ModuleName { get; set; }
        
        /// <value>
        /// The name of the stream
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StreamName is required.")]
        [JsonProperty(PropertyName = "streamName")]
        public string StreamName { get; set; }
        
        /// <value>
        /// Indicates if this stream is the default for its module.
        /// </value>
        [JsonProperty(PropertyName = "isDefault")]
        public System.Nullable<bool> IsDefault { get; set; }
        
        /// <value>
        /// The OCID of the software source that provides this module stream.
        /// </value>
        [JsonProperty(PropertyName = "softwareSourceId")]
        public string SoftwareSourceId { get; set; }
        
        /// <value>
        /// The architecture for which the packages in this module stream were built
        /// </value>
        [JsonProperty(PropertyName = "architecture")]
        public string Architecture { get; set; }
        
        /// <value>
        /// A description of the contents of the module stream
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// A list of profiles that are part of the stream.  Each element in
        /// the list is the name of a profile.  The name is suitable to use as
        /// an argument to other OS Management APIs that interact directly with
        /// module stream profiles.  However, it is not URL encoded.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "profiles")]
        public System.Collections.Generic.List<string> Profiles { get; set; }
        
        /// <value>
        /// A list of packages that are contained by the stream.  Each element
        /// in the list is the name of a package.  The name is suitable to use
        /// as an argument to other OS Management APIs that interact directly
        /// with packages.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "packages")]
        public System.Collections.Generic.List<string> Packages { get; set; }
        
    }
}
