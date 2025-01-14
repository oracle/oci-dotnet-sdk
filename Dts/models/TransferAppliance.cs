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


namespace Oci.DtsService.Models
{
    
    public class TransferAppliance 
    {
        
        /// <value>
        /// Unique alpha-numeric identifier for a transfer appliance auto generated during create.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Label is required.")]
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }
                ///
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "REQUESTED")]
            Requested,
            [EnumMember(Value = "ORACLE_PREPARING")]
            OraclePreparing,
            [EnumMember(Value = "SHIPPING")]
            Shipping,
            [EnumMember(Value = "DELIVERED")]
            Delivered,
            [EnumMember(Value = "PREPARING")]
            Preparing,
            [EnumMember(Value = "FINALIZED")]
            Finalized,
            [EnumMember(Value = "RETURN_LABEL_REQUESTED")]
            ReturnLabelRequested,
            [EnumMember(Value = "RETURN_LABEL_GENERATING")]
            ReturnLabelGenerating,
            [EnumMember(Value = "RETURN_LABEL_AVAILABLE")]
            ReturnLabelAvailable,
            [EnumMember(Value = "RETURN_DELAYED")]
            ReturnDelayed,
            [EnumMember(Value = "RETURN_SHIPPED")]
            ReturnShipped,
            [EnumMember(Value = "RETURN_SHIPPED_CANCELLED")]
            ReturnShippedCancelled,
            [EnumMember(Value = "ORACLE_RECEIVED")]
            OracleReceived,
            [EnumMember(Value = "ORACLE_RECEIVED_CANCELLED")]
            OracleReceivedCancelled,
            [EnumMember(Value = "PROCESSING")]
            Processing,
            [EnumMember(Value = "COMPLETE")]
            Complete,
            [EnumMember(Value = "CUSTOMER_NEVER_RECEIVED")]
            CustomerNeverReceived,
            [EnumMember(Value = "ORACLE_NEVER_RECEIVED")]
            OracleNeverReceived,
            [EnumMember(Value = "CUSTOMER_LOST")]
            CustomerLost,
            [EnumMember(Value = "CANCELLED")]
            Cancelled,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "REJECTED")]
            Rejected,
            [EnumMember(Value = "ERROR")]
            Error
        };

        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        [JsonProperty(PropertyName = "transferJobId")]
        public string TransferJobId { get; set; }
        
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; set; }
        
        [JsonProperty(PropertyName = "creationTime")]
        public System.Nullable<System.DateTime> CreationTime { get; set; }
        
        [JsonProperty(PropertyName = "customerReceivedTime")]
        public System.Nullable<System.DateTime> CustomerReceivedTime { get; set; }
        
        [JsonProperty(PropertyName = "customerReturnedTime")]
        public System.Nullable<System.DateTime> CustomerReturnedTime { get; set; }
        
        [JsonProperty(PropertyName = "nextBillingTime")]
        public System.Nullable<System.DateTime> NextBillingTime { get; set; }
        
        [JsonProperty(PropertyName = "deliverySecurityTieId")]
        public string DeliverySecurityTieId { get; set; }
        
        [JsonProperty(PropertyName = "returnSecurityTieId")]
        public string ReturnSecurityTieId { get; set; }
        
        [JsonProperty(PropertyName = "applianceDeliveryTrackingNumber")]
        public string ApplianceDeliveryTrackingNumber { get; set; }
        
        [JsonProperty(PropertyName = "applianceReturnDeliveryTrackingNumber")]
        public string ApplianceReturnDeliveryTrackingNumber { get; set; }
        
        [JsonProperty(PropertyName = "applianceDeliveryVendor")]
        public string ApplianceDeliveryVendor { get; set; }
        
        [JsonProperty(PropertyName = "customerShippingAddress")]
        public ShippingAddress CustomerShippingAddress { get; set; }
        
        [JsonProperty(PropertyName = "uploadStatusLogUri")]
        public string UploadStatusLogUri { get; set; }
        
        [JsonProperty(PropertyName = "returnShippingLabelUri")]
        public string ReturnShippingLabelUri { get; set; }
        
        /// <value>
        /// Expected return date from customer for the device, time portion should be zero.
        /// </value>
        [JsonProperty(PropertyName = "expectedReturnDate")]
        public System.Nullable<System.DateTime> ExpectedReturnDate { get; set; }
        
        /// <value>
        /// Start time for the window to pickup the device from customer.
        /// </value>
        [JsonProperty(PropertyName = "pickupWindowStartTime")]
        public System.Nullable<System.DateTime> PickupWindowStartTime { get; set; }
        
        /// <value>
        /// End time for the window to pickup the device from customer.
        /// </value>
        [JsonProperty(PropertyName = "pickupWindowEndTime")]
        public System.Nullable<System.DateTime> PickupWindowEndTime { get; set; }
        
        /// <value>
        /// Minimum storage capacity of the device, in terabytes. Valid options are 50, 95 and 150.
        /// </value>
        [JsonProperty(PropertyName = "minimumStorageCapacityInTerabytes")]
        public System.Nullable<int> MinimumStorageCapacityInTerabytes { get; set; }
        
    }
}
