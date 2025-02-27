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


namespace Oci.OdaService.Models
{
    /// <summary>
    /// Details pertaining to a scan proxy instance created for a scan listener FQDN/IPs
    /// </summary>
    public class OdaPrivateEndpointScanProxy 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the ODA Private Endpoint Scan Proxy.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
                ///
        /// <value>
        /// Type indicating whether Scan listener is specified by its FQDN or list of IPs
        /// 
        /// </value>
        ///
        public enum ScanListenerTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "FQDN")]
            Fqdn,
            [EnumMember(Value = "IP")]
            Ip
        };

        /// <value>
        /// Type indicating whether Scan listener is specified by its FQDN or list of IPs
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScanListenerType is required.")]
        [JsonProperty(PropertyName = "scanListenerType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ScanListenerTypeEnum> ScanListenerType { get; set; }
                ///
        /// <value>
        /// The protocol used for communication between client, scanProxy and RAC's scan listeners
        /// 
        /// </value>
        ///
        public enum ProtocolEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "TCP")]
            Tcp
        };

        /// <value>
        /// The protocol used for communication between client, scanProxy and RAC's scan listeners
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Protocol is required.")]
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ProtocolEnum> Protocol { get; set; }
        
        /// <value>
        /// The FQDN/IPs and port information of customer's Real Application Cluster (RAC)'s SCAN listeners.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScanListenerInfos is required.")]
        [JsonProperty(PropertyName = "scanListenerInfos")]
        public System.Collections.Generic.List<ScanListenerInfo> ScanListenerInfos { get; set; }
                ///
        /// <value>
        /// The current state of the ODA Private Endpoint Scan Proxy.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the ODA Private Endpoint Scan Proxy.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// When the resource was created. A date-time string as described in [RFC 3339](https://tools.ietf.org/rfc/rfc3339), section 14.29.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
    }
}
