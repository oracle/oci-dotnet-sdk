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


namespace Oci.MarketplacepublisherService.Models
{
    /// <summary>
    /// OPN membership information
    /// </summary>
    public class OpnMembership 
    {
        
        /// <value>
        /// OPN membership start date. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// OPN membership end date. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
                ///
        /// <value>
        /// OPN status
        /// </value>
        ///
        public enum OpnStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "RENEWAL_IN_PROGRESS")]
            RenewalInProgress
        };

        /// <value>
        /// OPN status
        /// </value>
        [JsonProperty(PropertyName = "opnStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OpnStatusEnum> OpnStatus { get; set; }
        
        /// <value>
        /// OPN Number number
        /// </value>
        [JsonProperty(PropertyName = "opnNumber")]
        public string OpnNumber { get; set; }
        
        /// <value>
        /// OPN membership type
        /// </value>
        [JsonProperty(PropertyName = "opnMembershipType")]
        public string OpnMembershipType { get; set; }
        
    }
}
