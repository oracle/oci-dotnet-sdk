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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// LogAnalyticsMetaFunctionArgument
    /// </summary>
    public class LogAnalyticsMetaFunctionArgument 
    {
        
        /// <value>
        /// The override output fields.
        /// </value>
        [JsonProperty(PropertyName = "isOverrideOutputFields")]
        public System.Nullable<bool> IsOverrideOutputFields { get; set; }
        
        /// <value>
        /// The argument display name.
        /// </value>
        [JsonProperty(PropertyName = "argumentDisplayName")]
        public string ArgumentDisplayName { get; set; }
        
        /// <value>
        /// The argument example.
        /// </value>
        [JsonProperty(PropertyName = "argumentExample")]
        public string ArgumentExample { get; set; }
        
        /// <value>
        /// The argument service.
        /// </value>
        [JsonProperty(PropertyName = "argumentService")]
        public string ArgumentService { get; set; }
        
        /// <value>
        /// The argument data type.
        /// </value>
        [JsonProperty(PropertyName = "argumentDataType")]
        public string ArgumentDataType { get; set; }
        
        /// <value>
        /// The argument description.
        /// </value>
        [JsonProperty(PropertyName = "argumentDescription")]
        public string ArgumentDescription { get; set; }
        
        /// <value>
        /// The argument name.
        /// </value>
        [JsonProperty(PropertyName = "argumentName")]
        public string ArgumentName { get; set; }
        
        /// <value>
        /// The argument order.
        /// </value>
        [JsonProperty(PropertyName = "argumentOrder")]
        public System.Nullable<long> ArgumentOrder { get; set; }
        
        /// <value>
        /// The argument type.
        /// </value>
        [JsonProperty(PropertyName = "argumentType")]
        public System.Nullable<long> ArgumentType { get; set; }
        
        /// <value>
        /// The argument unique identifier.
        /// </value>
        [JsonProperty(PropertyName = "argumentId")]
        public System.Nullable<long> ArgumentId { get; set; }
        
        /// <value>
        /// The lookup column.
        /// </value>
        [JsonProperty(PropertyName = "argumentLookupColumn")]
        public string ArgumentLookupColumn { get; set; }
        
        /// <value>
        /// The lookup column position.
        /// </value>
        [JsonProperty(PropertyName = "argumentLookupColumnPosition")]
        public System.Nullable<long> ArgumentLookupColumnPosition { get; set; }
        
        /// <value>
        /// The argument value.
        /// </value>
        [JsonProperty(PropertyName = "argumentValue")]
        public string ArgumentValue { get; set; }
        
        /// <value>
        /// The argument unique identifier as a string.
        /// </value>
        [JsonProperty(PropertyName = "argumentReference")]
        public string ArgumentReference { get; set; }
        
    }
}
