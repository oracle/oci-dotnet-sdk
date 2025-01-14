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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// The meta-data specific on particular deployment type represented by deploymentType field.
    /// <br/>
    /// Deprecated properties: `sourceTechnologies` and `targetTechnologies` are not populated. They will be removed after September 15 2025.
    /// The list of supported source and target technologies can be accessed using the url provided in `supportedTechnologiesUrl` property.
    /// 
    /// </summary>
    public class DeploymentTypeSummary 
    {
        
        /// <value>
        /// The deployment category defines the broad separation of the deployment type into three categories.
        /// Currently the separation is 'DATA_REPLICATION', 'STREAM_ANALYTICS' and 'DATA_TRANSFORMS'.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Category is required.")]
        [JsonProperty(PropertyName = "category")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DeploymentCategory> Category { get; set; }
        
        /// <value>
        /// An object's Display Name.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The type of deployment, which can be any one of the Allowed values. 
        /// NOTE: Use of the value 'OGG' is maintained for backward compatibility purposes. 
        ///     Its use is discouraged in favor of 'DATABASE_ORACLE'.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeploymentType is required.")]
        [JsonProperty(PropertyName = "deploymentType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DeploymentType> DeploymentType { get; set; }
        
        /// <value>
        /// An array of connectionTypes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectionTypes", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<ConnectionType> ConnectionTypes { get; set; }
        
        /// <value>
        /// List of the supported technologies generally.  The value is a freeform text string generally consisting
        /// of a description of the technology and optionally the speific version(s) support.  For example,
        /// [ \"Oracle Database 19c\", \"Oracle Exadata\", \"OCI Streaming\" ]
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sourceTechnologies")]
        public System.Collections.Generic.List<string> SourceTechnologies { get; set; }
        
        /// <value>
        /// List of the supported technologies generally.  The value is a freeform text string generally consisting
        /// of a description of the technology and optionally the speific version(s) support.  For example,
        /// [ \"Oracle Database 19c\", \"Oracle Exadata\", \"OCI Streaming\" ]
        /// 
        /// </value>
        [JsonProperty(PropertyName = "targetTechnologies")]
        public System.Collections.Generic.List<string> TargetTechnologies { get; set; }
        
        /// <value>
        /// Version of OGG
        /// 
        /// </value>
        [JsonProperty(PropertyName = "oggVersion")]
        public string OggVersion { get; set; }
        
        /// <value>
        /// The URL to the webpage listing the supported technologies.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "supportedTechnologiesUrl")]
        public string SupportedTechnologiesUrl { get; set; }
        
        /// <value>
        /// The default admin username used by deployment.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "defaultUsername")]
        public string DefaultUsername { get; set; }
        
    }
}
