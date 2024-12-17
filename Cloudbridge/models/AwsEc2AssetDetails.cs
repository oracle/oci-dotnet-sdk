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


namespace Oci.CloudbridgeService.Models
{
    /// <summary>
    /// AWS EC2 type of asset.
    /// </summary>
    public class AwsEc2AssetDetails 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Compute is required.")]
        [JsonProperty(PropertyName = "compute")]
        public ComputeProperties Compute { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Vm is required.")]
        [JsonProperty(PropertyName = "vm")]
        public VmProperties Vm { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AwsEc2 is required.")]
        [JsonProperty(PropertyName = "awsEc2")]
        public AwsEc2Properties AwsEc2 { get; set; }
        
        [JsonProperty(PropertyName = "awsEc2Cost")]
        public MonthlyCostSummary AwsEc2Cost { get; set; }
        
        [JsonProperty(PropertyName = "attachedEbsVolumesCost")]
        public MonthlyCostSummary AttachedEbsVolumesCost { get; set; }
        
    }
}
