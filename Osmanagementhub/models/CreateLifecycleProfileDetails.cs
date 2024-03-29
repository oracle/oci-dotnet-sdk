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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Description of a lifecycle registration profile to be created.
    /// </summary>
    public class CreateLifecycleProfileDetails : CreateProfileDetails
    {
        
        /// <value>
        /// The OCID of the lifecycle stage from which the registration profile will inherit its software source.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleStageId is required.")]
        [JsonProperty(PropertyName = "lifecycleStageId")]
        public string LifecycleStageId { get; set; }
        
        [JsonProperty(PropertyName = "profileType")]
        private readonly string profileType = "LIFECYCLE";
    }
}
