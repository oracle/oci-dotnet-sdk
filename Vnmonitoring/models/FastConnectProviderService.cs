/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// A service offering from a supported provider. For more information,
    /// see [FastConnect Overview](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/fastconnect.htm).
    /// 
    /// </summary>
    public class FastConnectProviderService 
    {
        
        /// <value>
        /// The location of the provider's website or portal. This portal is where you can get information
        /// about the provider service, create a virtual circuit connection from the provider to Oracle
        /// Cloud Infrastructure, and retrieve your provider service key for that virtual circuit connection.
        /// <br/>
        /// Example: https://example.com
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the service offered by the provider.
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
        /// Who is responsible for managing the private peering BGP information.
        /// 
        /// </value>
        ///
        public enum PrivatePeeringBgpManagementEnum {
            [EnumMember(Value = "CUSTOMER_MANAGED")]
            CustomerManaged,
            [EnumMember(Value = "PROVIDER_MANAGED")]
            ProviderManaged,
            [EnumMember(Value = "ORACLE_MANAGED")]
            OracleManaged
        };

        /// <value>
        /// Who is responsible for managing the private peering BGP information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PrivatePeeringBgpManagement is required.")]
        [JsonProperty(PropertyName = "privatePeeringBgpManagement")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PrivatePeeringBgpManagementEnum> PrivatePeeringBgpManagement { get; set; }
        
        /// <value>
        /// The name of the provider.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProviderName is required.")]
        [JsonProperty(PropertyName = "providerName")]
        public string ProviderName { get; set; }
        
        /// <value>
        /// The name of the service offered by the provider.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProviderServiceName is required.")]
        [JsonProperty(PropertyName = "providerServiceName")]
        public string ProviderServiceName { get; set; }
                ///
        /// <value>
        /// Who is responsible for managing the public peering BGP information.
        /// 
        /// </value>
        ///
        public enum PublicPeeringBgpManagementEnum {
            [EnumMember(Value = "CUSTOMER_MANAGED")]
            CustomerManaged,
            [EnumMember(Value = "PROVIDER_MANAGED")]
            ProviderManaged,
            [EnumMember(Value = "ORACLE_MANAGED")]
            OracleManaged
        };

        /// <value>
        /// Who is responsible for managing the public peering BGP information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PublicPeeringBgpManagement is required.")]
        [JsonProperty(PropertyName = "publicPeeringBgpManagement")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PublicPeeringBgpManagementEnum> PublicPeeringBgpManagement { get; set; }
                ///
        ///
        public enum SupportedVirtualCircuitTypesEnum {
            [EnumMember(Value = "PUBLIC")]
            Public,
            [EnumMember(Value = "PRIVATE")]
            Private
        };

        /// <value>
        /// An array of virtual circuit types supported by this service.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "supportedVirtualCircuitTypes", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<SupportedVirtualCircuitTypesEnum> SupportedVirtualCircuitTypes { get; set; }
                ///
        /// <value>
        /// Who is responsible for managing the ASN information for the network at the other end
        /// of the connection from Oracle.
        /// 
        /// </value>
        ///
        public enum CustomerAsnManagementEnum {
            [EnumMember(Value = "CUSTOMER_MANAGED")]
            CustomerManaged,
            [EnumMember(Value = "PROVIDER_MANAGED")]
            ProviderManaged,
            [EnumMember(Value = "ORACLE_MANAGED")]
            OracleManaged
        };

        /// <value>
        /// Who is responsible for managing the ASN information for the network at the other end
        /// of the connection from Oracle.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CustomerAsnManagement is required.")]
        [JsonProperty(PropertyName = "customerAsnManagement")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CustomerAsnManagementEnum> CustomerAsnManagement { get; set; }
                ///
        /// <value>
        /// Who is responsible for managing the provider service key.
        /// 
        /// </value>
        ///
        public enum ProviderServiceKeyManagementEnum {
            [EnumMember(Value = "CUSTOMER_MANAGED")]
            CustomerManaged,
            [EnumMember(Value = "PROVIDER_MANAGED")]
            ProviderManaged,
            [EnumMember(Value = "ORACLE_MANAGED")]
            OracleManaged
        };

        /// <value>
        /// Who is responsible for managing the provider service key.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProviderServiceKeyManagement is required.")]
        [JsonProperty(PropertyName = "providerServiceKeyManagement")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ProviderServiceKeyManagementEnum> ProviderServiceKeyManagement { get; set; }
                ///
        /// <value>
        /// Who is responsible for managing the virtual circuit bandwidth.
        /// 
        /// </value>
        ///
        public enum BandwithShapeManagementEnum {
            [EnumMember(Value = "CUSTOMER_MANAGED")]
            CustomerManaged,
            [EnumMember(Value = "PROVIDER_MANAGED")]
            ProviderManaged,
            [EnumMember(Value = "ORACLE_MANAGED")]
            OracleManaged
        };

        /// <value>
        /// Who is responsible for managing the virtual circuit bandwidth.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BandwithShapeManagement is required.")]
        [JsonProperty(PropertyName = "bandwithShapeManagement")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<BandwithShapeManagementEnum> BandwithShapeManagement { get; set; }
        
        /// <value>
        /// Total number of cross-connect or cross-connect groups required for the virtual circuit.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RequiredTotalCrossConnects is required.")]
        [JsonProperty(PropertyName = "requiredTotalCrossConnects")]
        public System.Nullable<int> RequiredTotalCrossConnects { get; set; }
                ///
        /// <value>
        /// Provider service type.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "LAYER2")]
            Layer2,
            [EnumMember(Value = "LAYER3")]
            Layer3
        };

        /// <value>
        /// Provider service type.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
    }
}
