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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The summary of user role grant paths.
    /// </summary>
    public class RoleGrantPathSummary 
    {
        
        /// <value>
        /// The unique key of a role grant.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// Grantee is the user who can access the table.
        /// </value>
        [JsonProperty(PropertyName = "grantee")]
        public string Grantee { get; set; }
        
        /// <value>
        /// The name of the role.
        /// </value>
        [JsonProperty(PropertyName = "grantedRole")]
        public string GrantedRole { get; set; }
        
        /// <value>
        /// The grant depth level of the indirect grant.
        /// An indirectly granted role/privilege is granted to the user through another role.
        /// The depth level indicates how deep a privilege is within the grant hierarchy.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "depthLevel")]
        public System.Nullable<int> DepthLevel { get; set; }
        
    }
}
