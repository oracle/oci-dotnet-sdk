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


namespace Oci.PsqlService.Models
{
    /// <summary>
    /// An operation that \"puts\" values from elsewhere in the target, functionally equivalent to a single add and then a remove.
    /// The first item of the selection is replaced, or created if the selection is empty.
    /// NOT_FOUND exceptions in the selection are handled by creating the implied containing structure.
    /// This operation fails if the `from` selection yields any exceptions, or if an item is moved to any of its descendants.
    /// 
    /// </summary>
    public class PatchMoveInstruction : PatchInstruction
    {
        
        /// <value>
        /// The selection that is to be moved, with the same format and semantics as `selection`.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "From is required.")]
        [JsonProperty(PropertyName = "from")]
        public string From { get; set; }
                ///
        /// <value>
        /// Where to insert the value in an array, relative to the first item in the selection.
        /// If there is no such item, then \"BEFORE\" specifies insertion at the first position in an array and \"AFTER\" specifies insertion at the last position.
        /// If the first item in the selection is not the child of an array, then this field has no effect.
        /// 
        /// </value>
        ///
        public enum PositionEnum {
            [EnumMember(Value = "AT")]
            At,
            [EnumMember(Value = "BEFORE")]
            Before,
            [EnumMember(Value = "AFTER")]
            After
        };

        /// <value>
        /// Where to insert the value in an array, relative to the first item in the selection.
        /// If there is no such item, then \"BEFORE\" specifies insertion at the first position in an array and \"AFTER\" specifies insertion at the last position.
        /// If the first item in the selection is not the child of an array, then this field has no effect.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "position")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PositionEnum> Position { get; set; }
        
        [JsonProperty(PropertyName = "operation")]
        private readonly string operation = "MOVE";
    }
}
