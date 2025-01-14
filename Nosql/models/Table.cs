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


namespace Oci.NosqlService.Models
{
    /// <summary>
    /// Complete metadata about a table.
    /// </summary>
    public class Table 
    {
        
        /// <value>
        /// Unique identifier that is immutable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Human-friendly table name, immutable.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Compartment Identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The time the the table was created. An RFC3339 formatted
        /// datetime string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the the table's metadata was last updated. An
        /// RFC3339 formatted datetime string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        [JsonProperty(PropertyName = "tableLimits")]
        public TableLimits TableLimits { get; set; }
                ///
        /// <value>
        /// The state of a table.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "INACTIVE")]
            Inactive
        };

        /// <value>
        /// The state of a table.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// True if this table can be reclaimed after an idle period.
        /// </value>
        [JsonProperty(PropertyName = "isAutoReclaimable")]
        public System.Nullable<bool> IsAutoReclaimable { get; set; }
        
        /// <value>
        /// If lifecycleState is INACTIVE, indicates when
        /// this table will be automatically removed.
        /// An RFC3339 formatted datetime string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeOfExpiration")]
        public System.Nullable<System.DateTime> TimeOfExpiration { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        [JsonProperty(PropertyName = "schema")]
        public Schema Schema { get; set; }
        
        /// <value>
        /// A DDL statement representing the schema.
        /// </value>
        [JsonProperty(PropertyName = "ddlStatement")]
        public string DdlStatement { get; set; }
                ///
        /// <value>
        /// The current state of this table's schema. Available states are
        /// MUTABLE - The schema can be changed. The table is not eligible for replication.
        /// FROZEN - The schema is immutable. The table is eligible for replication.
        /// 
        /// </value>
        ///
        public enum SchemaStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "MUTABLE")]
            Mutable,
            [EnumMember(Value = "FROZEN")]
            Frozen
        };

        /// <value>
        /// The current state of this table's schema. Available states are
        /// MUTABLE - The schema can be changed. The table is not eligible for replication.
        /// FROZEN - The schema is immutable. The table is eligible for replication.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "schemaState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SchemaStateEnum> SchemaState { get; set; }
        
        /// <value>
        /// True if this table is currently a member of a replication set.
        /// </value>
        [JsonProperty(PropertyName = "isMultiRegion")]
        public System.Nullable<bool> IsMultiRegion { get; set; }
        
        /// <value>
        /// If this table is in a replication set, this value represents
        /// the progress of the initialization of the replica's data.  A
        /// value of 100 indicates that initialization has completed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "localReplicaInitializationInPercent")]
        public System.Nullable<int> LocalReplicaInitializationInPercent { get; set; }
        
        /// <value>
        /// An array of Replica listing this table's replicas, if any
        /// </value>
        [JsonProperty(PropertyName = "replicas")]
        public System.Collections.Generic.List<Replica> Replicas { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined
        /// name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and
        /// scoped to a namespace.  Example: {&quot;foo-namespace&quot;:{&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Read-only system tag. These predefined keys are scoped to
        /// namespaces.  At present the only supported namespace is
        /// `\"orcl-cloud\"`; and the only key in that namespace is
        /// `\"free-tier-retained\"`.
        /// Example: {&quot;orcl-cloud&quot;&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
