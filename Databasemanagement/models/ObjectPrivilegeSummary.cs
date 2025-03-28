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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// A summary of object privileges.
    /// </summary>
    public class ObjectPrivilegeSummary 
    {
        
        /// <value>
        /// The name of the privilege on the object.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The type of object.
        /// </value>
        [JsonProperty(PropertyName = "schemaType")]
        public string SchemaType { get; set; }
        
        /// <value>
        /// The owner of the object.
        /// </value>
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }
        
        /// <value>
        /// The name of the user who granted the object privilege.
        /// </value>
        [JsonProperty(PropertyName = "grantor")]
        public string Grantor { get; set; }
                ///
        /// <value>
        /// Indicates whether the privilege is granted with the HIERARCHY OPTION (YES) or not (NO).
        /// </value>
        ///
        public enum HierarchyEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "YES")]
            Yes,
            [EnumMember(Value = "NO")]
            No
        };

        /// <value>
        /// Indicates whether the privilege is granted with the HIERARCHY OPTION (YES) or not (NO).
        /// </value>
        [JsonProperty(PropertyName = "hierarchy")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<HierarchyEnum> Hierarchy { get; set; }
        
        /// <value>
        /// The name of the object. The object can be any object, including tables, packages, indexes, sequences, and so on.
        /// </value>
        [JsonProperty(PropertyName = "object")]
        public string Object { get; set; }
                ///
        /// <value>
        /// Indicates whether the privilege is granted with the GRANT OPTION (YES) or not (NO).
        /// </value>
        ///
        public enum GrantOptionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "YES")]
            Yes,
            [EnumMember(Value = "NO")]
            No
        };

        /// <value>
        /// Indicates whether the privilege is granted with the GRANT OPTION (YES) or not (NO).
        /// </value>
        [JsonProperty(PropertyName = "grantOption")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<GrantOptionEnum> GrantOption { get; set; }
                ///
        /// <value>
        /// Indicates how the object privilege was granted. Possible values:
        /// YES if the role is granted commonly (CONTAINER=ALL is used)
        /// NO if the role is granted locally (CONTAINER=ALL is not used)
        /// 
        /// </value>
        ///
        public enum CommonEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "YES")]
            Yes,
            [EnumMember(Value = "NO")]
            No
        };

        /// <value>
        /// Indicates how the object privilege was granted. Possible values:
        /// YES if the role is granted commonly (CONTAINER=ALL is used)
        /// NO if the role is granted locally (CONTAINER=ALL is not used)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "common")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CommonEnum> Common { get; set; }
                ///
        /// <value>
        /// Indicates whether the granted privilege is inherited from another container (YES) or not (NO).
        /// </value>
        ///
        public enum InheritedEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "YES")]
            Yes,
            [EnumMember(Value = "NO")]
            No
        };

        /// <value>
        /// Indicates whether the granted privilege is inherited from another container (YES) or not (NO).
        /// </value>
        [JsonProperty(PropertyName = "inherited")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<InheritedEnum> Inherited { get; set; }
        
    }
}
