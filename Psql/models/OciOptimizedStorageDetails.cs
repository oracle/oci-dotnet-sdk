/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.PsqlService.Models
{
    /// <summary>
    /// Storage details of the OCI_OPTIMIZED_STORAGE DbSystem.
    /// </summary>
    public class OciOptimizedStorageDetails : StorageDetails
    {
        
        /// <value>
        /// DbSystem Performance Unit
        /// </value>
        [JsonProperty(PropertyName = "iops")]
        public System.Nullable<long> Iops { get; set; }
        
        [JsonProperty(PropertyName = "systemType")]
        private readonly string systemType = "OCI_OPTIMIZED_STORAGE";
    }
}