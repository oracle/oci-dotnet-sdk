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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// Result of the connectivity test performed on a pipeline's assigned connection.
    /// 
    /// </summary>
    public class TestPipelineConnectionResult 
    {
                ///
        /// <value>
        /// Type of result, either Succeeded, Failed, or Timed out.
        /// 
        /// </value>
        ///
        public enum ResultTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "TIMED_OUT")]
            TimedOut
        };

        /// <value>
        /// Type of result, either Succeeded, Failed, or Timed out.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResultType is required.")]
        [JsonProperty(PropertyName = "resultType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ResultTypeEnum> ResultType { get; set; }
        
        [JsonProperty(PropertyName = "error")]
        public TestPipelineConnectionError Error { get; set; }
        
    }
}