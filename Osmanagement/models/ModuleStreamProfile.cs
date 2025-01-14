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


namespace Oci.OsmanagementService.Models
{
    /// <summary>
    /// A module stream profile provided by a software source
    /// </summary>
    public class ModuleStreamProfile 
    {
        
        /// <value>
        /// The name of the module that contains the stream profile
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModuleName is required.")]
        [JsonProperty(PropertyName = "moduleName")]
        public string ModuleName { get; set; }
        
        /// <value>
        /// The name of the stream that contains the profile
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StreamName is required.")]
        [JsonProperty(PropertyName = "streamName")]
        public string StreamName { get; set; }
        
        /// <value>
        /// The name of the profile
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProfileName is required.")]
        [JsonProperty(PropertyName = "profileName")]
        public string ProfileName { get; set; }
        
        /// <value>
        /// Indicates if this profile is the default for its module stream.
        /// </value>
        [JsonProperty(PropertyName = "isDefault")]
        public System.Nullable<bool> IsDefault { get; set; }
        
        /// <value>
        /// A description of the contents of the module stream profile
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// A list of packages that constitute the profile.  Each element
        /// in the list is the name of a package.  The name is suitable to
        /// use as an argument to other OS Management APIs that interact
        /// directly with packages.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Packages is required.")]
        [JsonProperty(PropertyName = "packages")]
        public System.Collections.Generic.List<string> Packages { get; set; }
        
    }
}
