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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// The redundancy status of the DRG. For more information, see
    /// [Redundancy Remedies](https://docs.cloud.oracle.com/iaas/Content/Network/Troubleshoot/drgredundancy.htm).
    /// 
    /// </summary>
    public class DrgRedundancyStatus 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the DRG.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
                ///
        /// <value>
        /// The redundancy status of the DRG.
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NOT_AVAILABLE")]
            NotAvailable,
            [EnumMember(Value = "REDUNDANT")]
            Redundant,
            [EnumMember(Value = "NOT_REDUNDANT_SINGLE_IPSEC")]
            NotRedundantSingleIpsec,
            [EnumMember(Value = "NOT_REDUNDANT_SINGLE_VIRTUALCIRCUIT")]
            NotRedundantSingleVirtualcircuit,
            [EnumMember(Value = "NOT_REDUNDANT_MULTIPLE_IPSECS")]
            NotRedundantMultipleIpsecs,
            [EnumMember(Value = "NOT_REDUNDANT_MULTIPLE_VIRTUALCIRCUITS")]
            NotRedundantMultipleVirtualcircuits,
            [EnumMember(Value = "NOT_REDUNDANT_MIX_CONNECTIONS")]
            NotRedundantMixConnections,
            [EnumMember(Value = "NOT_REDUNDANT_NO_CONNECTION")]
            NotRedundantNoConnection
        };

        /// <value>
        /// The redundancy status of the DRG.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
    }
}
