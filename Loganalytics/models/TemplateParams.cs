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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Template key value params which can store template details like macro name and its parameter.
    /// </summary>
    public class TemplateParams 
    {
        
        /// <value>
        /// Contains macro parameter's names.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KeyField is required.")]
        [JsonProperty(PropertyName = "keyField")]
        public string KeyField { get; set; }
        
        /// <value>
        /// Contains macro parameter's value.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ValueField is required.")]
        [JsonProperty(PropertyName = "valueField")]
        public string ValueField { get; set; }
        
    }
}
