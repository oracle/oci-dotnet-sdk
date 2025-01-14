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


namespace Oci.JmsService.Models
{
    /// <summary>
    /// Details of the request to start a Java migration analysis. The analysis requires the managed instance OCID, application installation key,
    /// source JDK version, and target JDK version of each selected application.
    /// 
    /// </summary>
    public class RequestJavaMigrationAnalysesDetails 
    {
        
        /// <value>
        /// An array of migration analysis requests.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Targets is required.")]
        [JsonProperty(PropertyName = "targets")]
        public System.Collections.Generic.List<JavaMigrationAnalysisTarget> Targets { get; set; }
        
    }
}
