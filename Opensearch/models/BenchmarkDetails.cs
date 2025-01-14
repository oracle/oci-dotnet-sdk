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


namespace Oci.OpensearchService.Models
{
    /// <summary>
    /// Benchmark test configuration detail.
    /// </summary>
    public class BenchmarkDetails 
    {
                ///
        /// <value>
        /// Execution Length of Perf Test (default set to STANDARD)
        /// </value>
        ///
        public enum PerfTestLengthEnum {
            [EnumMember(Value = "STANDARD")]
            Standard,
            [EnumMember(Value = "LONG")]
            Long
        };

        /// <value>
        /// Execution Length of Perf Test (default set to STANDARD)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PerfTestLength is required.")]
        [JsonProperty(PropertyName = "perfTestLength")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PerfTestLengthEnum> PerfTestLength { get; set; }
        
        /// <value>
        /// Control Cluster Id Information
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ControlClusterId is required.")]
        [JsonProperty(PropertyName = "controlClusterId")]
        public string ControlClusterId { get; set; }
        
        /// <value>
        /// Required Test Cluster Id needed to run perf test
        /// </value>
        [JsonProperty(PropertyName = "test1ClusterId")]
        public string Test1ClusterId { get; set; }
        
        /// <value>
        /// Optional Test Cluster Id needed to run perf test
        /// </value>
        [JsonProperty(PropertyName = "test2ClusterId")]
        public string Test2ClusterId { get; set; }
        
    }
}
