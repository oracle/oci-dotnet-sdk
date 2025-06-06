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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The connection details for the HDFS data asset.
    /// </summary>
    public class ConnectionFromHdfsDetails : ConnectionDetails
    {
        
        /// <value>
        /// The HDFS principal.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HdfsPrincipal is required.")]
        [JsonProperty(PropertyName = "hdfsPrincipal")]
        public string HdfsPrincipal { get; set; }
        
        /// <value>
        /// The HDFS Data Node principal.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataNodePrincipal is required.")]
        [JsonProperty(PropertyName = "dataNodePrincipal")]
        public string DataNodePrincipal { get; set; }
        
        /// <value>
        /// The HDFS Name Node principal.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NameNodePrincipal is required.")]
        [JsonProperty(PropertyName = "nameNodePrincipal")]
        public string NameNodePrincipal { get; set; }
        
        /// <value>
        /// HDFS Realm name.
        /// </value>
        [JsonProperty(PropertyName = "realm")]
        public string Realm { get; set; }
        
        /// <value>
        /// The HDFS Key Distribution Center.
        /// </value>
        [JsonProperty(PropertyName = "keyDistributionCenter")]
        public string KeyDistributionCenter { get; set; }
        
        [JsonProperty(PropertyName = "keyTabContent")]
        public SensitiveAttribute KeyTabContent { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "HDFS_CONNECTION";
    }
}
