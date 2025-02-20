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


namespace Oci.WafService.Models
{
    /// <summary>
    /// Module that allows inspection of HTTP response properties and to return a defined HTTP response.
    /// </summary>
    public class ResponseAccessControl 
    {
        
        /// <value>
        /// Ordered list of AccessControlRules. Rules are executed in order of appearance in this array.
        /// </value>
        [JsonProperty(PropertyName = "rules")]
        public System.Collections.Generic.List<AccessControlRule> Rules { get; set; }
        
    }
}
