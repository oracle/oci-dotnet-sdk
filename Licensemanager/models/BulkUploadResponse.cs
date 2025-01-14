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
    /// The bulk upload response.
    /// </summary>
    public class BulkUploadResponse 
    {
        
        /// <value>
        /// The number of license records which were supported.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalSupportedRecords is required.")]
        [JsonProperty(PropertyName = "totalSupportedRecords")]
        public System.Nullable<int> TotalSupportedRecords { get; set; }
        
        /// <value>
        /// The number of supported license records that were uploaded successfully.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalSupportedRecordsSaved is required.")]
        [JsonProperty(PropertyName = "totalSupportedRecordsSaved")]
        public System.Nullable<int> TotalSupportedRecordsSaved { get; set; }
        
        /// <value>
        /// The number of supported license records that were valid but not uploaded since they were duplicates.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalSupportedDuplicateRecords is required.")]
        [JsonProperty(PropertyName = "totalSupportedDuplicateRecords")]
        public System.Nullable<int> TotalSupportedDuplicateRecords { get; set; }
        
        /// <value>
        /// The number of supported license records that were valid but failed with errors during upload.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalSupportedFailedLicenseRecords is required.")]
        [JsonProperty(PropertyName = "totalSupportedFailedLicenseRecords")]
        public System.Nullable<int> TotalSupportedFailedLicenseRecords { get; set; }
        
        /// <value>
        /// The number of supported license records that could not be uploaded since they were invalid.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalSupportedInvalidRecords is required.")]
        [JsonProperty(PropertyName = "totalSupportedInvalidRecords")]
        public System.Nullable<int> TotalSupportedInvalidRecords { get; set; }
        
        /// <value>
        /// Detailed error information corresponding to each supported but invalid row for the uploaded file.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ValidationErrorInfo is required.")]
        [JsonProperty(PropertyName = "validationErrorInfo")]
        public System.Collections.Generic.List<BulkUploadValidationErrorInfo> ValidationErrorInfo { get; set; }
        
        /// <value>
        /// Error information corresponding to the supported records which are valid but could not be created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FailedLicenseRecordInfo is required.")]
        [JsonProperty(PropertyName = "failedLicenseRecordInfo")]
        public System.Collections.Generic.List<BulkUploadFailedRecordInfo> FailedLicenseRecordInfo { get; set; }
        
        /// <value>
        /// Response message for bulk upload.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Message is required.")]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
    }
}
