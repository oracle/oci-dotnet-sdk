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


namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// Invoke Oracle function step details.
    /// 
    /// </summary>
    public class InvokeFunctionStep : DrPlanUserDefinedStep
    {
        
        /// <value>
        /// The OCID of function to be invoked.
        /// <br/>
        /// Example: ocid1.fnfunc.oc1..uniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FunctionId is required.")]
        [JsonProperty(PropertyName = "functionId")]
        public string FunctionId { get; set; }
        
        /// <value>
        /// The region in which the function is deployed.
        /// <br/>
        /// Example: us-ashburn-1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FunctionRegion is required.")]
        [JsonProperty(PropertyName = "functionRegion")]
        public string FunctionRegion { get; set; }
        
        /// <value>
        /// The request body for the function.
        /// <br/>
        /// Example: { &quot;FnParam1&quot;, &quot;FnParam2&quot; }
        /// </value>
        [JsonProperty(PropertyName = "requestBody")]
        public string RequestBody { get; set; }
        
        [JsonProperty(PropertyName = "stepType")]
        private readonly string stepType = "INVOKE_FUNCTION";
    }
}
