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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Information about a data asset import operation.
    /// </summary>
    public class ImportDataAssetJobResult 
    {
        
        /// <value>
        /// The unique key of the data asset on which import is triggered.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataAssetKey is required.")]
        [JsonProperty(PropertyName = "dataAssetKey")]
        public string DataAssetKey { get; set; }
        
        /// <value>
        /// The unique key of the job definition resource that is used for the import.
        /// </value>
        [JsonProperty(PropertyName = "importJobDefinitionKey")]
        public string ImportJobDefinitionKey { get; set; }
        
        /// <value>
        /// The unique key of the job policy for the import.
        /// </value>
        [JsonProperty(PropertyName = "importJobKey")]
        public string ImportJobKey { get; set; }
        
        /// <value>
        /// The unique key of the parent job execution for which the log resource is created.
        /// </value>
        [JsonProperty(PropertyName = "importJobExecutionKey")]
        public string ImportJobExecutionKey { get; set; }
        
        /// <value>
        /// The status of the import job execution.
        /// </value>
        [JsonProperty(PropertyName = "importJobExecutionStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<JobExecutionState> ImportJobExecutionStatus { get; set; }
        
    }
}
