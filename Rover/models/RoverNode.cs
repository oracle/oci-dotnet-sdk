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


namespace Oci.RoverService.Models
{
    /// <summary>
    /// Information about a RoverNode.
    /// </summary>
    public class RoverNode 
    {
        
        /// <value>
        /// The OCID of RoverNode.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The cluster ID if the node is part of a cluster.
        /// </value>
        [JsonProperty(PropertyName = "clusterId")]
        public string ClusterId { get; set; }
        
        /// <value>
        /// The OCID of the compartment containing the RoverNode.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The type of node indicating if it belongs to a cluster
        /// </value>
        [JsonProperty(PropertyName = "nodeType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<NodeType> NodeType { get; set; }
        
        /// <value>
        /// The shape of the node.
        /// </value>
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// The type of enclosure rover node is shipped in.
        /// </value>
        [JsonProperty(PropertyName = "enclosureType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<EnclosureType> EnclosureType { get; set; }
        
        /// <value>
        /// Serial number of the node.
        /// </value>
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The time the the RoverNode was created. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The current state of the RoverNode.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// A property that can contain details on the lifecycle.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleStateDetails")]
        public string LifecycleStateDetails { get; set; }
        
        [JsonProperty(PropertyName = "customerShippingAddress")]
        public ShippingAddress CustomerShippingAddress { get; set; }
        
        /// <value>
        /// List of existing workloads that should be provisioned on the node.
        /// </value>
        [JsonProperty(PropertyName = "nodeWorkloads")]
        public System.Collections.Generic.List<RoverWorkload> NodeWorkloads { get; set; }
        
        /// <value>
        /// Date and time when customer received tne node.
        /// </value>
        [JsonProperty(PropertyName = "timeCustomerReceieved")]
        public System.Nullable<System.DateTime> TimeCustomerReceieved { get; set; }
        
        /// <value>
        /// Date and time when customer returned the node.
        /// </value>
        [JsonProperty(PropertyName = "timeCustomerReturned")]
        public System.Nullable<System.DateTime> TimeCustomerReturned { get; set; }
        
        /// <value>
        /// Tracking information for device shipping.
        /// </value>
        [JsonProperty(PropertyName = "deliveryTrackingInfo")]
        public string DeliveryTrackingInfo { get; set; }
        
        /// <value>
        /// Root password for the rover node.
        /// </value>
        [JsonProperty(PropertyName = "superUserPassword")]
        public string SuperUserPassword { get; set; }
        
        /// <value>
        /// Password to unlock the rover node.
        /// </value>
        [JsonProperty(PropertyName = "unlockPassphrase")]
        public string UnlockPassphrase { get; set; }
        
        /// <value>
        /// Name of point of contact for this order if customer is picking up.
        /// </value>
        [JsonProperty(PropertyName = "pointOfContact")]
        public string PointOfContact { get; set; }
        
        /// <value>
        /// Phone number of point of contact for this order if customer is picking up.
        /// </value>
        [JsonProperty(PropertyName = "pointOfContactPhoneNumber")]
        public string PointOfContactPhoneNumber { get; set; }
                ///
        /// <value>
        /// Preference for device delivery.
        /// </value>
        ///
        public enum ShippingPreferenceEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ORACLE_SHIPPED")]
            OracleShipped,
            [EnumMember(Value = "CUSTOMER_PICKUP")]
            CustomerPickup
        };

        /// <value>
        /// Preference for device delivery.
        /// </value>
        [JsonProperty(PropertyName = "shippingPreference")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ShippingPreferenceEnum> ShippingPreference { get; set; }
        
        /// <value>
        /// Shipping vendor of choice for orace to customer shipping.
        /// </value>
        [JsonProperty(PropertyName = "shippingVendor")]
        public string ShippingVendor { get; set; }
        
        /// <value>
        /// Expected date when customer wants to pickup the device if they chose customer pickup.
        /// </value>
        [JsonProperty(PropertyName = "timePickupExpected")]
        public System.Nullable<System.DateTime> TimePickupExpected { get; set; }
        
        /// <value>
        /// Start time for the window to pickup the device from customer.
        /// </value>
        [JsonProperty(PropertyName = "timeReturnWindowStarts")]
        public System.Nullable<System.DateTime> TimeReturnWindowStarts { get; set; }
        
        /// <value>
        /// Tracking Url for the shipped RoverNode.
        /// </value>
        [JsonProperty(PropertyName = "oracleShippingTrackingUrl")]
        public string OracleShippingTrackingUrl { get; set; }
        
        /// <value>
        /// End time for the window to pickup the device from customer.
        /// </value>
        [JsonProperty(PropertyName = "timeReturnWindowEnds")]
        public System.Nullable<System.DateTime> TimeReturnWindowEnds { get; set; }
        
        /// <value>
        /// Uri to download return shipping label.
        /// </value>
        [JsonProperty(PropertyName = "returnShippingLabelUri")]
        public string ReturnShippingLabelUri { get; set; }
        
        /// <value>
        /// The flag indicating that customer requests data to be imported to OCI upon Rover node return.
        /// </value>
        [JsonProperty(PropertyName = "isImportRequested")]
        public System.Nullable<bool> IsImportRequested { get; set; }
        
        /// <value>
        /// An OCID of a compartment where data will be imported to upon Rover node return.
        /// </value>
        [JsonProperty(PropertyName = "importCompartmentId")]
        public string ImportCompartmentId { get; set; }
        
        /// <value>
        /// Name of a bucket where files from NFS share will be imported to upon Rover node return.
        /// </value>
        [JsonProperty(PropertyName = "importFileBucket")]
        public string ImportFileBucket { get; set; }
        
        /// <value>
        /// Validation code returned by data validation tool. Required for return shipping label generation if data import was requested.
        /// </value>
        [JsonProperty(PropertyName = "dataValidationCode")]
        public string DataValidationCode { get; set; }
        
        /// <value>
        /// The public key of the resource principal
        /// </value>
        [JsonProperty(PropertyName = "publicKey")]
        public string PublicKey { get; set; }
        
        /// <value>
        /// The link to pre-authenticated request for a bucket where image workloads are moved.
        /// </value>
        [JsonProperty(PropertyName = "imageExportPar")]
        public string ImageExportPar { get; set; }
        
        /// <value>
        /// Customer provided master key ID to encrypt secret information. If not provided, Rover's master key will be used for encryption.
        /// </value>
        [JsonProperty(PropertyName = "masterKeyId")]
        public string MasterKeyId { get; set; }
        
        /// <value>
        /// The certificateAuthorityId of subordinate/intermediate certificate authority.
        /// </value>
        [JsonProperty(PropertyName = "certificateAuthorityId")]
        public string CertificateAuthorityId { get; set; }
        
        /// <value>
        /// The time after which leaf certificate will invalid.
        /// </value>
        [JsonProperty(PropertyName = "timeCertValidityEnd")]
        public System.Nullable<System.DateTime> TimeCertValidityEnd { get; set; }
        
        /// <value>
        /// The common name for the leaf certificate.
        /// </value>
        [JsonProperty(PropertyName = "commonName")]
        public string CommonName { get; set; }
        
        /// <value>
        /// The compartmentId of the leaf certificate.
        /// </value>
        [JsonProperty(PropertyName = "certCompartmentId")]
        public string CertCompartmentId { get; set; }
        
        /// <value>
        /// The version number of the leaf certificate.
        /// </value>
        [JsonProperty(PropertyName = "certificateVersionNumber")]
        public string CertificateVersionNumber { get; set; }
        
        /// <value>
        /// The id of the leaf certificate.
        /// </value>
        [JsonProperty(PropertyName = "certificateId")]
        public string CertificateId { get; set; }
        
        /// <value>
        /// key algorithm for issuing leaf certificate.
        /// </value>
        [JsonProperty(PropertyName = "certKeyAlgorithm")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CertKeyAlgorithm> CertKeyAlgorithm { get; set; }
        
        /// <value>
        /// signature algorithm for issuing leaf certificate.
        /// </value>
        [JsonProperty(PropertyName = "certSignatureAlgorithm")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<CertSignatureAlgorithm> CertSignatureAlgorithm { get; set; }
        
        /// <value>
        /// The tags associated with tagSlug.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tags")]
        public string Tags { get; set; }
        
        /// <value>
        /// The freeform tags associated with this resource, if any. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The defined tags associated with this resource, if any. Each key is predefined and scoped to namespaces.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// The system tags associated with this resource, if any. The system tags are set by Oracle cloud infrastructure services. Each key is predefined and scoped to namespaces.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {orcl-cloud: {free-tier-retain: true}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
