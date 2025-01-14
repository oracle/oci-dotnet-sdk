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


namespace Oci.CapacitymanagementService.Models
{
    /// <summary>
    /// An operation that inserts a value into an array, shifting array items as necessary and handling NOT_FOUND exceptions by creating the implied containing structure.
    /// 
    /// </summary>
    public class PatchInsertInstruction : PatchInstruction
    {
        
        /// <value>
        /// A value to be inserted into the target.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public System.Object Value { get; set; }
        
        /// <value>
        /// A selection to be evaluated against the array for identifying a particular reference item within it, with the same format and semantics as `selection`.
        /// </value>
        [JsonProperty(PropertyName = "selectedItem")]
        public string SelectedItem { get; set; }
                ///
        /// <value>
        /// Where to insert the value, relative to the first item matched by `selectedItem`.
        /// If `selectedItem` is unspecified, then \"BEFORE\" specifies insertion at the first position in an array and \"AFTER\" specifies insertion at the last position.
        /// If `selectedItem` is specified but results in an empty selection, then both values specify insertion at the last position.
        /// 
        /// </value>
        ///
        public enum PositionEnum {
            [EnumMember(Value = "BEFORE")]
            Before,
            [EnumMember(Value = "AFTER")]
            After
        };

        /// <value>
        /// Where to insert the value, relative to the first item matched by `selectedItem`.
        /// If `selectedItem` is unspecified, then \"BEFORE\" specifies insertion at the first position in an array and \"AFTER\" specifies insertion at the last position.
        /// If `selectedItem` is specified but results in an empty selection, then both values specify insertion at the last position.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "position")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PositionEnum> Position { get; set; }
        
        [JsonProperty(PropertyName = "operation")]
        private readonly string operation = "INSERT";
    }
}
