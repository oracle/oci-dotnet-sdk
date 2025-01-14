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


namespace Oci.VnmonitoringService.Models
{
    
    public class PortRange 
    {
        
        /// <value>
        /// The maximum port number, which must not be less than the minimum port number. To specify
        /// a single port number, set both the min and max to the same value.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Max is required.")]
        [JsonProperty(PropertyName = "max")]
        public System.Nullable<int> Max { get; set; }
        
        /// <value>
        /// The minimum port number, which must not be greater than the maximum port number.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Min is required.")]
        [JsonProperty(PropertyName = "min")]
        public System.Nullable<int> Min { get; set; }
        
    }
}
