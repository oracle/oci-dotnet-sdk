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


namespace Oci.GenerativeaiagentService.Models
{
    /// <summary>
    /// The details of OCI Search with OpenSearch data source information.
    /// 
    /// </summary>
    public class OciObjectStorageDataSourceConfig : DataSourceConfig
    {
        
        /// <value>
        /// The locations of data items in Object Storage, can either be an object (File) or a prefix (folder).
        /// </value>
        [JsonProperty(PropertyName = "objectStoragePrefixes")]
        public System.Collections.Generic.List<ObjectStoragePrefix> ObjectStoragePrefixes { get; set; }
        
        [JsonProperty(PropertyName = "dataSourceConfigType")]
        private readonly string dataSourceConfigType = "OCI_OBJECT_STORAGE";
    }
}
