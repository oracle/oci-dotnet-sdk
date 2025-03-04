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


namespace Oci.GenerativeaiagentruntimeService.Models
{
    /// <summary>
    /// The OCI Object Storage that contains the data files.
    /// 
    /// </summary>
    public class OciObjectStorageSourceLocation : SourceLocation
    {
        
        /// <value>
        /// The URL of the OCI Object Storage data source.
        /// </value>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        
        [JsonProperty(PropertyName = "sourceLocationType")]
        private readonly string sourceLocationType = "OCI_OBJECT_STORAGE";
    }
}
