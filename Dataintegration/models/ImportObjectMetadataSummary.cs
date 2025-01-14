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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Details of the objects to imported.
    /// </summary>
    public class ImportObjectMetadataSummary 
    {
        
        /// <value>
        /// Old key of the object
        /// </value>
        [JsonProperty(PropertyName = "oldKey")]
        public string OldKey { get; set; }
        
        /// <value>
        /// New key of the object
        /// </value>
        [JsonProperty(PropertyName = "newKey")]
        public string NewKey { get; set; }
        
        /// <value>
        /// Name of the object
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Object identifier
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        /// <value>
        /// Object type
        /// </value>
        [JsonProperty(PropertyName = "objectType")]
        public string ObjectType { get; set; }
        
        /// <value>
        /// Object version
        /// </value>
        [JsonProperty(PropertyName = "objectVersion")]
        public string ObjectVersion { get; set; }
        
        /// <value>
        /// Aggregator key
        /// </value>
        [JsonProperty(PropertyName = "aggregatorKey")]
        public string AggregatorKey { get; set; }
        
        /// <value>
        /// Object name path
        /// </value>
        [JsonProperty(PropertyName = "namePath")]
        public string NamePath { get; set; }
        
        /// <value>
        /// time at which this object was last updated.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdatedInMillis")]
        public System.Nullable<long> TimeUpdatedInMillis { get; set; }
                ///
        /// <value>
        /// Object resolution action
        /// </value>
        ///
        public enum ResolutionActionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATED")]
            Created,
            [EnumMember(Value = "RETAINED")]
            Retained,
            [EnumMember(Value = "DUPLICATED")]
            Duplicated,
            [EnumMember(Value = "REPLACED")]
            Replaced,
            [EnumMember(Value = "EXCLUDED")]
            Excluded
        };

        /// <value>
        /// Object resolution action
        /// </value>
        [JsonProperty(PropertyName = "resolutionAction")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResolutionActionEnum> ResolutionAction { get; set; }
        
    }
}
