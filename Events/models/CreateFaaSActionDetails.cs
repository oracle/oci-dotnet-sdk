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


namespace Oci.EventsService.Models
{
    /// <summary>
    /// Create an action that delivers to an Oracle Functions Service endpoint.
    /// </summary>
    public class CreateFaaSActionDetails : ActionDetails
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of a Function hosted by Oracle Functions Service.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "functionId")]
        public string FunctionId { get; set; }
        
        [JsonProperty(PropertyName = "actionType")]
        private readonly string actionType = "FAAS";
    }
}
