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


namespace Oci.FusionappsService.Models
{
    /// <summary>
    /// An access control rule condition that requires a match on the specified source VCN OCID.
    /// 
    /// </summary>
    public class SourceVcnIdCondition : RuleCondition
    {
        
        /// <value>
        /// The OCID of the originating VCN that an incoming packet must match.
        /// You can use this condition in conjunction with `SourceVcnIpAddressCondition`.
        /// **NOTE:** If you define this condition for a rule without a `SourceVcnIpAddressCondition`, this condition
        /// matches all incoming traffic in the specified VCN.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AttributeValue is required.")]
        [JsonProperty(PropertyName = "attributeValue")]
        public string AttributeValue { get; set; }
        
        [JsonProperty(PropertyName = "attributeName")]
        private readonly string attributeName = "SOURCE_VCN_ID";
    }
}
