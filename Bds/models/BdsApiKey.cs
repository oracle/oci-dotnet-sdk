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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// The API key information.
    /// </summary>
    public class BdsApiKey 
    {
        
        /// <value>
        /// Identifier of the user's API key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The user OCID for which this API key was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UserId is required.")]
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }
        
        /// <value>
        /// User friendly identifier used to uniquely differentiate between different API keys.
        /// Only ASCII alphanumeric characters with no spaces allowed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KeyAlias is required.")]
        [JsonProperty(PropertyName = "keyAlias")]
        public string KeyAlias { get; set; }
        
        /// <value>
        /// The name of the region to establish the Object Storage endpoint. Example us-phoenix-1 .
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefaultRegion is required.")]
        [JsonProperty(PropertyName = "defaultRegion")]
        public string DefaultRegion { get; set; }
        
        /// <value>
        /// The OCID of your tenancy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TenantId is required.")]
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }
        
        /// <value>
        /// The fingerprint that corresponds to the public API key requested.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Fingerprint is required.")]
        [JsonProperty(PropertyName = "fingerprint")]
        public string Fingerprint { get; set; }
        
        /// <value>
        /// The full path and file name of the private key used for authentication. This location will be automatically selected
        /// on the BDS local file system.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Pemfilepath is required.")]
        [JsonProperty(PropertyName = "pemfilepath")]
        public string Pemfilepath { get; set; }
        
        /// <value>
        /// The time the API key was created, shown as an RFC 3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
                ///
        /// <value>
        /// The state of the key.
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
        /// The state of the key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Identity domain OCID ,where user is present. For default domain ,this field will be optional.
        /// </value>
        [JsonProperty(PropertyName = "domainOcid")]
        public string DomainOcid { get; set; }
        
    }
}
