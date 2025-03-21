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


namespace Oci.IdentityService.Models
{
    /// <summary>
    /// A group created in an identity provider that can be mapped to a group in OCI
    /// 
    /// </summary>
    public class IdentityProviderGroupSummary 
    {
        
        /// <value>
        /// The OCID of the `IdentityProviderGroup`.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the `IdentityProvider` this group belongs to.
        /// </value>
        [JsonProperty(PropertyName = "identityProviderId")]
        public string IdentityProviderId { get; set; }
        
        /// <value>
        /// Display name of the group
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Display name of the group
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Identifier of the group in the identity provider
        /// </value>
        [JsonProperty(PropertyName = "externalIdentifier")]
        public string ExternalIdentifier { get; set; }
        
        /// <value>
        /// Date and time the `IdentityProviderGroup` was created, in the format defined by RFC3339.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Date and time the `IdentityProviderGroup` was last modified, in the format defined by RFC3339.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeModified")]
        public System.Nullable<System.DateTime> TimeModified { get; set; }
        
    }
}
