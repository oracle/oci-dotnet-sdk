/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DataconnectivityService.Models
{
    /// <summary>
    /// Operation execution result for a single input set.
    /// </summary>
    public class OperationExecResult 
    {
                ///
        /// <value>
        /// Status of the operation job for particular set of input.
        /// </value>
        ///
        public enum ExecutionStatusEnum {
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "SUCCESS")]
            Success,
            [EnumMember(Value = "QUEUED")]
            Queued,
            [EnumMember(Value = "RUNNING")]
            Running
        };

        /// <value>
        /// Status of the operation job for particular set of input.
        /// </value>
        [JsonProperty(PropertyName = "executionStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ExecutionStatusEnum> ExecutionStatus { get; set; }
        
        /// <value>
        /// Error message if execution of operation is failed.
        /// </value>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }
        
        /// <value>
        /// Metrics of operation execution job.
        /// </value>
        [JsonProperty(PropertyName = "metrics")]
        public System.Object Metrics { get; set; }
        
        /// <value>
        /// List of emitted rows for each OUT/INOUT param.
        /// </value>
        [JsonProperty(PropertyName = "outputValues")]
        public System.Collections.Generic.List<System.Collections.Generic.List<System.Object>> OutputValues { get; set; }
        
        /// <value>
        /// True, if error message should be displayed on UI.
        /// </value>
        [JsonProperty(PropertyName = "isWhitelistedErrorMessage")]
        public System.Nullable<bool> IsWhitelistedErrorMessage { get; set; }
        
    }
}
