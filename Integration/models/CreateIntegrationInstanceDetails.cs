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


namespace Oci.IntegrationService.Models
{
    /// <summary>
    /// The information about new IntegrationInstance.
    /// Some properties may not be applicable to specific integration types,
    /// see [Differences in Instance Management](https://www.oracle.com/pls/topic/lookup?ctx=en/cloud/paas/application-integration&id=INTOO-GUID-931B5E33-4FE6-4997-93E5-8748516F46AA__GUID-176E43D5-4116-4828-8120-B929DF2A6B5E)
    /// for details.
    /// 
    /// </summary>
    public class CreateIntegrationInstanceDetails 
    {
        
        /// <value>
        /// Integration Instance Identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Compartment Identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// Standard or Enterprise type,
        /// Oracle Integration Generation 2 uses ENTERPRISE and STANDARD,
        /// Oracle Integration 3 uses ENTERPRISEX and STANDARDX
        /// 
        /// </value>
        ///
        public enum IntegrationInstanceTypeEnum {
            [EnumMember(Value = "STANDARD")]
            Standard,
            [EnumMember(Value = "ENTERPRISE")]
            Enterprise,
            [EnumMember(Value = "STANDARDX")]
            Standardx,
            [EnumMember(Value = "ENTERPRISEX")]
            Enterprisex,
            [EnumMember(Value = "HEALTHCARE")]
            Healthcare
        };

        /// <value>
        /// Standard or Enterprise type,
        /// Oracle Integration Generation 2 uses ENTERPRISE and STANDARD,
        /// Oracle Integration 3 uses ENTERPRISEX and STANDARDX
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IntegrationInstanceType is required.")]
        [JsonProperty(PropertyName = "integrationInstanceType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<IntegrationInstanceTypeEnum> IntegrationInstanceType { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name,
        /// type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to
        /// namespaces.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Bring your own license.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsByol is required.")]
        [JsonProperty(PropertyName = "isByol")]
        public System.Nullable<bool> IsByol { get; set; }
        
        /// <value>
        /// IDCS Authentication token. This is required for all realms with IDCS. Its optional as its not required for non IDCS realms.
        /// </value>
        [JsonProperty(PropertyName = "idcsAt")]
        public string IdcsAt { get; set; }
        
        /// <value>
        /// The number of configured message packs
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MessagePacks is required.")]
        [JsonProperty(PropertyName = "messagePacks")]
        public System.Nullable<int> MessagePacks { get; set; }
        
        /// <value>
        /// Visual Builder is enabled or not.
        /// </value>
        [JsonProperty(PropertyName = "isVisualBuilderEnabled")]
        public System.Nullable<bool> IsVisualBuilderEnabled { get; set; }
        
        [JsonProperty(PropertyName = "customEndpoint")]
        public CreateCustomEndpointDetails CustomEndpoint { get; set; }
        
        /// <value>
        /// A list of alternate custom endpoints to be used for the integration instance URL
        /// (contact Oracle for alternateCustomEndpoints availability for a specific instance).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "alternateCustomEndpoints")]
        public System.Collections.Generic.List<CreateCustomEndpointDetails> AlternateCustomEndpoints { get; set; }
                ///
        /// <value>
        /// Optional parameter specifying which entitlement to use for billing purposes. Only required if the account possesses more than one entitlement.
        /// </value>
        ///
        public enum ConsumptionModelEnum {
            [EnumMember(Value = "UCM")]
            Ucm,
            [EnumMember(Value = "GOV")]
            Gov,
            [EnumMember(Value = "OIC4SAAS")]
            Oic4Saas
        };

        /// <value>
        /// Optional parameter specifying which entitlement to use for billing purposes. Only required if the account possesses more than one entitlement.
        /// </value>
        [JsonProperty(PropertyName = "consumptionModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ConsumptionModelEnum> ConsumptionModel { get; set; }
        
        /// <value>
        /// The file server is enabled or not.
        /// </value>
        [JsonProperty(PropertyName = "isFileServerEnabled")]
        public System.Nullable<bool> IsFileServerEnabled { get; set; }
        
        /// <value>
        /// Is Disaster Recovery enabled or not.
        /// </value>
        [JsonProperty(PropertyName = "isDisasterRecoveryEnabled")]
        public System.Nullable<bool> IsDisasterRecoveryEnabled { get; set; }
        
        [JsonProperty(PropertyName = "networkEndpointDetails")]
        public NetworkEndpointDetails NetworkEndpointDetails { get; set; }
                ///
        /// <value>
        /// Shape
        /// </value>
        ///
        public enum ShapeEnum {
            [EnumMember(Value = "DEVELOPMENT")]
            Development,
            [EnumMember(Value = "PRODUCTION")]
            Production
        };

        /// <value>
        /// Shape
        /// </value>
        [JsonProperty(PropertyName = "shape")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ShapeEnum> Shape { get; set; }
        
        /// <value>
        /// The OCID of the identity domain, that will be used to determine the
        /// corresponding Idcs Stripe and create an Idcs application within the stripe.
        /// This parameter is mutually exclusive with parameter: idcsAt, i.e only one of
        /// two parameters should be specified.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "domainId")]
        public string DomainId { get; set; }
        
    }
}
