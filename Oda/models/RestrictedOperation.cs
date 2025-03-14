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


namespace Oci.OdaService.Models
{
    /// <summary>
    /// Summary of a restricted operation for a Digital Assistant instance.
    /// </summary>
    public class RestrictedOperation 
    {
        
        /// <value>
        /// Name of the restricted operation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperationName is required.")]
        [JsonProperty(PropertyName = "operationName")]
        public string OperationName { get; set; }
        
        /// <value>
        /// Name of the service restricting the operation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RestrictingService is required.")]
        [JsonProperty(PropertyName = "restrictingService")]
        public string RestrictingService { get; set; }
        
    }
}
