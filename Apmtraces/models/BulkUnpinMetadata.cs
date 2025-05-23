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
    /// Metadata about the bulk unpin operation.  The bulk unpin operation is atomic and binary.  If the processing of any of the attributes
    /// in the bulk unpin request results in a processing or validation error, then none of the attributes in the request are unpinned.
    /// 
    /// </summary>
    public class BulkUnpinMetadata 
    {
                ///
        /// <value>
        /// Operation status of the bulk unpin operation.
        /// SUCCESS - The bulk unpin operation has succeeded and all the attributes in the bulk unpin request have been unpinned by this operation.
        /// The following are error statuses for the bulk unpin operation.
        /// EMPTY_ATTRIBUTE_LIST - The bulk unpin request object was empty and did not contain any attributes to be unpinned.
        /// INVALID_BULK_REQUEST - The bulk request contains invalid attribute(s), or attribute(s) that resulted in a validation error, or an attribute that resulted
        /// in a processing error.
        /// 
        /// </value>
        ///
        public enum OperationStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SUCCESS")]
            Success,
            [EnumMember(Value = "EMPTY_ATTRIBUTE_LIST")]
            EmptyAttributeList,
            [EnumMember(Value = "INVALID_BULK_REQUEST")]
            InvalidBulkRequest
        };

        /// <value>
        /// Operation status of the bulk unpin operation.
        /// SUCCESS - The bulk unpin operation has succeeded and all the attributes in the bulk unpin request have been unpinned by this operation.
        /// The following are error statuses for the bulk unpin operation.
        /// EMPTY_ATTRIBUTE_LIST - The bulk unpin request object was empty and did not contain any attributes to be unpinned.
        /// INVALID_BULK_REQUEST - The bulk request contains invalid attribute(s), or attribute(s) that resulted in a validation error, or an attribute that resulted
        /// in a processing error.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperationStatus is required.")]
        [JsonProperty(PropertyName = "operationStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OperationStatusEnum> OperationStatus { get; set; }
                ///
        /// <value>
        /// Type of operation.
        /// 
        /// </value>
        ///
        public enum OperationTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "UNPIN")]
            Unpin
        };

        /// <value>
        /// Type of operation.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperationType is required.")]
        [JsonProperty(PropertyName = "operationType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OperationTypeEnum> OperationType { get; set; }
        
        /// <value>
        /// Total number attributes (both string and numeric) in TRACES namespace that were unpinned.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AttributesUnpinned is required.")]
        [JsonProperty(PropertyName = "attributesUnpinned")]
        public System.Nullable<int> AttributesUnpinned { get; set; }
        
        /// <value>
        /// Total number attributes (both string and numeric) in SYNTHETIC namespace that were unpinned.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "syntheticAttributesUnpinned")]
        public System.Nullable<int> SyntheticAttributesUnpinned { get; set; }
        
    }
}
