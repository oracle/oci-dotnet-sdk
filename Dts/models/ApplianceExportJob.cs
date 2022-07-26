/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
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
    
    public class ApplianceExportJob 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        [JsonProperty(PropertyName = "bucketName")]
        public string BucketName { get; set; }
        
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        [JsonProperty(PropertyName = "creationTime")]
        public System.Nullable<System.DateTime> CreationTime { get; set; }
                ///
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INPROGRESS")]
            Inprogress,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "CANCELLED")]
            Cancelled,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A property that can contain details on the lifecycle.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleStateDetails")]
        public string LifecycleStateDetails { get; set; }
        
        /// <value>
        /// Serial Number of the Appliance associated with this Export Job.
        /// </value>
        [JsonProperty(PropertyName = "applianceSerialNumber")]
        public string ApplianceSerialNumber { get; set; }
        
        /// <value>
        /// Passphrase associated with the Appliance.
        /// </value>
        [JsonProperty(PropertyName = "applianceDecryptionPassphrase")]
        public string ApplianceDecryptionPassphrase { get; set; }
        
        /// <value>
        /// Shipping Vendor selected to ship the Appliance associated with this job.
        /// </value>
        [JsonProperty(PropertyName = "applianceDeliveryVendor")]
        public string ApplianceDeliveryVendor { get; set; }
        
        /// <value>
        /// Tracking number associated with the shipment while shipping the Appliance to Customer.
        /// </value>
        [JsonProperty(PropertyName = "applianceDeliveryTrackingNumber")]
        public string ApplianceDeliveryTrackingNumber { get; set; }
        
        /// <value>
        /// Tracking number associated with the shipment while shipping the Appliance back to Oracle.
        /// </value>
        [JsonProperty(PropertyName = "applianceReturnDeliveryTrackingNumber")]
        public string ApplianceReturnDeliveryTrackingNumber { get; set; }
        
        /// <value>
        /// Unique number associated with the security tie used to seal the Appliance case.
        /// </value>
        [JsonProperty(PropertyName = "sendingSecurityTie")]
        public string SendingSecurityTie { get; set; }
        
        /// <value>
        /// Unique number associated with the return security tie used to seal the Appliance case.
        /// </value>
        [JsonProperty(PropertyName = "receivingSecurityTie")]
        public string ReceivingSecurityTie { get; set; }
        
        /// <value>
        /// List of objects with names matching this prefix would be part of this export job.
        /// </value>
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }
        
        /// <value>
        /// The name of the first object in the range of objects that are expected to be part of this export job.
        /// </value>
        [JsonProperty(PropertyName = "rangeStart")]
        public string RangeStart { get; set; }
        
        /// <value>
        /// The name of the last object in the range of objects that are expected to be part of this export job.
        /// </value>
        [JsonProperty(PropertyName = "rangeEnd")]
        public string RangeEnd { get; set; }
        
        /// <value>
        /// Total number of objects that are exported in this job.
        /// </value>
        [JsonProperty(PropertyName = "numberOfObjects")]
        public string NumberOfObjects { get; set; }
        
        /// <value>
        /// Total size of objects in Bytes that are exported in this job.
        /// </value>
        [JsonProperty(PropertyName = "totalSizeInBytes")]
        public string TotalSizeInBytes { get; set; }
        
        /// <value>
        /// First object in the list of objects that are exported in this job.
        /// </value>
        [JsonProperty(PropertyName = "firstObject")]
        public string FirstObject { get; set; }
        
        /// <value>
        /// Last object in the list of objects that are exported in this job.
        /// </value>
        [JsonProperty(PropertyName = "lastObject")]
        public string LastObject { get; set; }
        
        /// <value>
        /// First object from which the next potential export job could start.
        /// </value>
        [JsonProperty(PropertyName = "nextObject")]
        public string NextObject { get; set; }
        
        /// <value>
        /// Url of the Manifest File associated with this export job.
        /// </value>
        [JsonProperty(PropertyName = "manifestFile")]
        public string ManifestFile { get; set; }
        
        /// <value>
        /// md5 digest of the manifest file.
        /// </value>
        [JsonProperty(PropertyName = "manifestMd5")]
        public string ManifestMd5 { get; set; }
        
        /// <value>
        /// Polices to grant Data Transfer Service to access objects in the Bucket
        /// </value>
        [JsonProperty(PropertyName = "bucketAccessPolicies")]
        public System.Collections.Generic.List<string> BucketAccessPolicies { get; set; }
        
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
        
        [JsonProperty(PropertyName = "customerShippingAddress")]
        public ShippingAddress CustomerShippingAddress { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
