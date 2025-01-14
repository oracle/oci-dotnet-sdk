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


namespace Oci.AilanguageService.Models
{
    /// <summary>
    /// Mask PII entities with the given masking character.
    /// </summary>
    public class PiiEntityMask : PiiEntityMasking
    {
        
        /// <value>
        /// Masking character. By default, the character is an asterisk (*)
        /// </value>
        [JsonProperty(PropertyName = "maskingCharacter")]
        public string MaskingCharacter { get; set; }
        
        /// <value>
        /// Number of characters to leave unmasked. By default, the whole entity is masked.
        /// </value>
        [JsonProperty(PropertyName = "leaveCharactersUnmasked")]
        public System.Nullable<int> LeaveCharactersUnmasked { get; set; }
        
        /// <value>
        /// Unmask from the end. By default, the whole entity is masked. This field works in concert with
        /// leaveCharactersUnmasked. For example, leaveCharactersUnmasked is 3 and isUnmaskedFromEnd is true,
        /// then if the entity is India the masked entity/result is **dia.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isUnmaskedFromEnd")]
        public System.Nullable<bool> IsUnmaskedFromEnd { get; set; }
        
        [JsonProperty(PropertyName = "mode")]
        private readonly string mode = "MASK";
    }
}
