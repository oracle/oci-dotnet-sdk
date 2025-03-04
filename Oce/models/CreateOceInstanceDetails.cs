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


namespace Oci.OceService.Models
{
    /// <summary>
    /// The information about new OceInstance.
    /// </summary>
    public class CreateOceInstanceDetails 
    {
        
        /// <value>
        /// OceInstance description
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Compartment Identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// OceInstance Name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Tenancy Identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TenancyId is required.")]
        [JsonProperty(PropertyName = "tenancyId")]
        public string TenancyId { get; set; }
        
        /// <value>
        /// Identity Cloud Service access token identifying a stripe and service administrator user
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IdcsAccessToken is required.")]
        [JsonProperty(PropertyName = "idcsAccessToken")]
        public string IdcsAccessToken { get; set; }
        
        [JsonProperty(PropertyName = "identityStripe")]
        public IdentityStripeDetails IdentityStripe { get; set; }
        
        /// <value>
        /// Tenancy Name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TenancyName is required.")]
        [JsonProperty(PropertyName = "tenancyName")]
        public string TenancyName { get; set; }
                ///
        /// <value>
        /// Instance type based on its usage
        /// </value>
        ///
        public enum InstanceUsageTypeEnum {
            [EnumMember(Value = "PRIMARY")]
            Primary,
            [EnumMember(Value = "NONPRIMARY")]
            Nonprimary
        };

        /// <value>
        /// Instance type based on its usage
        /// </value>
        [JsonProperty(PropertyName = "instanceUsageType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<InstanceUsageTypeEnum> InstanceUsageType { get; set; }
        
        /// <value>
        /// a list of add-on features for the ocm instance
        /// </value>
        [JsonProperty(PropertyName = "addOnFeatures")]
        public System.Collections.Generic.List<string> AddOnFeatures { get; set; }
        
        /// <value>
        /// Object Storage Namespace of Tenancy
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectStorageNamespace is required.")]
        [JsonProperty(PropertyName = "objectStorageNamespace")]
        public string ObjectStorageNamespace { get; set; }
        
        /// <value>
        /// Admin Email for Notification
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AdminEmail is required.")]
        [JsonProperty(PropertyName = "adminEmail")]
        public string AdminEmail { get; set; }
        
        /// <value>
        /// Upgrade schedule type representing service to be upgraded immediately whenever latest version is released
        /// or delay upgrade of the service to previous released version
        /// 
        /// </value>
        [JsonProperty(PropertyName = "upgradeSchedule")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OceInstance.UpgradeScheduleEnum> UpgradeSchedule { get; set; }
        
        /// <value>
        /// Web Application Firewall(WAF) primary domain
        /// </value>
        [JsonProperty(PropertyName = "wafPrimaryDomain")]
        public string WafPrimaryDomain { get; set; }
                ///
        /// <value>
        /// Flag indicating whether the instance access is private or public
        /// </value>
        ///
        public enum InstanceAccessTypeEnum {
            [EnumMember(Value = "PUBLIC")]
            Public,
            [EnumMember(Value = "PRIVATE")]
            Private
        };

        /// <value>
        /// Flag indicating whether the instance access is private or public
        /// </value>
        [JsonProperty(PropertyName = "instanceAccessType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<InstanceAccessTypeEnum> InstanceAccessType { get; set; }
        
        /// <value>
        /// Flag indicating whether the instance license is new cloud or bring your own license
        /// </value>
        [JsonProperty(PropertyName = "instanceLicenseType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseType> InstanceLicenseType { get; set; }
        
        /// <value>
        /// disaster recovery paired ragion name
        /// </value>
        [JsonProperty(PropertyName = "drRegion")]
        public string DrRegion { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
