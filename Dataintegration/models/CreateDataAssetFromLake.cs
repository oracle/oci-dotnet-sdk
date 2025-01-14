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
    /// Details for the Lake data asset type.
    /// </summary>
    public class CreateDataAssetFromLake : CreateDataAssetDetails
    {
        
        /// <value>
        /// The Lake Ocid.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LakeId is required.")]
        [JsonProperty(PropertyName = "lakeId")]
        public string LakeId { get; set; }
        
        /// <value>
        /// The metastoreId for the specified Lake Resource.
        /// </value>
        [JsonProperty(PropertyName = "metastoreId")]
        public string MetastoreId { get; set; }
        
        /// <value>
        /// The lakeProxyEndpoint for the specified Lake Resource.
        /// </value>
        [JsonProperty(PropertyName = "lakeProxyEndpoint")]
        public string LakeProxyEndpoint { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefaultConnection is required.")]
        [JsonProperty(PropertyName = "defaultConnection")]
        public CreateConnectionFromLake DefaultConnection { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "LAKE_DATA_ASSET";
    }
}
