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


namespace Oci.OpensearchService.Models
{
    /// <summary>
    /// Information about the source OpenSearch cluster to restore the cluster backup from.
    /// </summary>
    public class RestoreOpensearchClusterBackupDetails 
    {
        
        /// <value>
        /// The name of the source OpenSearch cluster for the cluster backup.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClusterId is required.")]
        [JsonProperty(PropertyName = "clusterId")]
        public string ClusterId { get; set; }
        
    }
}
