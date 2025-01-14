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


namespace Oci.ApmtracesService.Models
{
    /// <summary>
    /// Response of a bulk attribute activation operation.
    /// 
    /// </summary>
    public class BulkActivationStatus 
    {
        
        /// <value>
        /// We preserve the order of the attribute items from the bulk activation request in this collection.  The ith object in this collection represents the
        /// bulk activation operation status of the ith object in the BulkActivateAttributeDetails object from the Bulk Activation request.  If the
        /// bulk activation operation results in a processing error or a validation error, the operationStatus property in the  BulkActivationMetadata object will
        /// contain the appropriate bulk error status for the bulk operation.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AttributeStatuses is required.")]
        [JsonProperty(PropertyName = "attributeStatuses")]
        public System.Collections.Generic.List<AttributeResponse> AttributeStatuses { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BulkActivationMetadata is required.")]
        [JsonProperty(PropertyName = "bulkActivationMetadata")]
        public BulkActivationMetadata BulkActivationMetadata { get; set; }
        
    }
}
