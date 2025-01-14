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


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// Logging configuration for resource.
    /// 
    /// </summary>
    public class JobLogConfigurationDetails 
    {
        
        /// <value>
        /// If customer logging is enabled for job runs.
        /// </value>
        [JsonProperty(PropertyName = "enableLogging")]
        public System.Nullable<bool> EnableLogging { get; set; }
        
        /// <value>
        /// If automatic on-behalf-of log object creation is enabled for job runs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "enableAutoLogCreation")]
        public System.Nullable<bool> EnableAutoLogCreation { get; set; }
        
        /// <value>
        /// The log group id for where log objects are for job runs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "logGroupId")]
        public string LogGroupId { get; set; }
        
        /// <value>
        /// The log id the job run will push logs too.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "logId")]
        public string LogId { get; set; }
        
    }
}
