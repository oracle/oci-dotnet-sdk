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


namespace Oci.LicensemanagerService.Models
{
    /// <summary>
    /// Error information corresponding to each column that was required but was invalid.
    /// </summary>
    public class BulkUploadCellInfo 
    {
        
        /// <value>
        /// Column index as in the given bulk upload file.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ColumnIndex is required.")]
        [JsonProperty(PropertyName = "columnIndex")]
        public string ColumnIndex { get; set; }
        
        /// <value>
        /// Error information corresponding to a particular column.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ErrorInfo is required.")]
        [JsonProperty(PropertyName = "errorInfo")]
        public string ErrorInfo { get; set; }
        
    }
}
