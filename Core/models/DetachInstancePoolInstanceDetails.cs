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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// An instance that is to be detached from an instance pool.
    /// 
    /// </summary>
    public class DetachInstancePoolInstanceDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceId is required.")]
        [JsonProperty(PropertyName = "instanceId")]
        public string InstanceId { get; set; }
        
        /// <value>
        /// Whether to decrease the size of the instance pool when the instance is detached. If `true`, the
        /// pool size is decreased. If `false`, the pool will provision a new, replacement instance
        /// using the pool's instance configuration as a template. Default is `true`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDecrementSize")]
        public System.Nullable<bool> IsDecrementSize { get; set; }
        
        /// <value>
        /// Whether to permanently terminate (delete) the instance and its attached boot volume
        /// when detaching it from the instance pool. Default is `false`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAutoTerminate")]
        public System.Nullable<bool> IsAutoTerminate { get; set; }
        
    }
}
