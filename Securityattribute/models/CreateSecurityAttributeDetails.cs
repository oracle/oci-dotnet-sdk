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


namespace Oci.SecurityattributeService.Models
{
    /// <summary>
    /// Details of the security attribute to be created for a specific security attribute namespace.
    /// 
    /// </summary>
    public class CreateSecurityAttributeDetails 
    {
        
        /// <value>
        /// The name you assign to the security attribute during creation. This is the security attribute key.
        /// The name must be unique within the namespace and cannot be changed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The description you assign to the security attribute during creation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        [JsonProperty(PropertyName = "validator")]
        public BaseSecurityAttributeValidator Validator { get; set; }
        
    }
}