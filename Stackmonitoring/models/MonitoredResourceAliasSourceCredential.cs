/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// Monitored Resource Alias Reference Source Credential
    /// </summary>
    public class MonitoredResourceAliasSourceCredential 
    {
        
        /// <value>
        /// The source type and source name combination,delimited with (.) separator. This refers to the pre-existing source which alias cred should point to. Ex. {source type}.{source name} and source type max char limit is 63.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Source is required.")]
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }
        
        /// <value>
        /// The name of the pre-existing source credential which alias cred should point to. This should refer to the pre-existing source attribute binded credential name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The name of the service owning the credential. Ex stack-monitoring or dbmgmt
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Service is required.")]
        [JsonProperty(PropertyName = "service")]
        public string Service { get; set; }
        
    }
}