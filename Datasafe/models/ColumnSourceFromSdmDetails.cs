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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Details of the sensitive data model that's used as the source of masking columns..
    /// </summary>
    public class ColumnSourceFromSdmDetails : ColumnSourceDetails
    {
        
        /// <value>
        /// The OCID of the sensitive data model that's used as the source of masking columns.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SensitiveDataModelId is required.")]
        [JsonProperty(PropertyName = "sensitiveDataModelId")]
        public string SensitiveDataModelId { get; set; }
        
        [JsonProperty(PropertyName = "columnSource")]
        private readonly string columnSource = "SENSITIVE_DATA_MODEL";
    }
}
