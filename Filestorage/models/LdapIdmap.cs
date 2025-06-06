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


namespace Oci.FilestorageService.Models
{
    /// <summary>
    /// Mount target details about the LDAP ID mapping configuration.
    /// 
    /// </summary>
    public class LdapIdmap 
    {
                ///
        /// <value>
        /// Schema type of the LDAP account.
        /// </value>
        ///
        public enum SchemaTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "RFC2307")]
            Rfc2307
        };

        /// <value>
        /// Schema type of the LDAP account.
        /// </value>
        [JsonProperty(PropertyName = "schemaType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SchemaTypeEnum> SchemaType { get; set; }
        
        /// <value>
        /// The amount of time that the mount target should allow an entry to persist in its cache before attempting to refresh the entry.
        /// </value>
        [JsonProperty(PropertyName = "cacheRefreshIntervalSeconds")]
        public System.Nullable<int> CacheRefreshIntervalSeconds { get; set; }
        
        /// <value>
        /// The maximum amount of time the mount target is allowed to use a cached entry.
        /// </value>
        [JsonProperty(PropertyName = "cacheLifetimeSeconds")]
        public System.Nullable<int> CacheLifetimeSeconds { get; set; }
        
        /// <value>
        /// The amount of time that a mount target will maintain information that a user is not found in the ID mapping configuration.
        /// </value>
        [JsonProperty(PropertyName = "negativeCacheLifetimeSeconds")]
        public System.Nullable<int> NegativeCacheLifetimeSeconds { get; set; }
        
        /// <value>
        /// All LDAP searches are recursive starting at this user.
        /// <br/>
        /// Example: CN=User,DC=domain,DC=com
        /// </value>
        [JsonProperty(PropertyName = "userSearchBase")]
        public string UserSearchBase { get; set; }
        
        /// <value>
        /// All LDAP searches are recursive starting at this group.
        /// <br/>
        /// Example: CN=Group,DC=domain,DC=com
        /// </value>
        [JsonProperty(PropertyName = "groupSearchBase")]
        public string GroupSearchBase { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the first connector to use to communicate with the LDAP server.
        /// </value>
        [JsonProperty(PropertyName = "outboundConnector1Id")]
        public string OutboundConnector1Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the second connector to use to communicate with the LDAP server.
        /// </value>
        [JsonProperty(PropertyName = "outboundConnector2Id")]
        public string OutboundConnector2Id { get; set; }
        
    }
}
