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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Defines the rules or criteria based on which the scope for job definition is circumscribed.
    /// </summary>
    public class JobDefinitionScope 
    {
        
        /// <value>
        /// Name of the folder or schema for this metadata harvest.
        /// </value>
        [JsonProperty(PropertyName = "folderName")]
        public string FolderName { get; set; }
        
        /// <value>
        /// Name of the entity for this metadata harvest.
        /// </value>
        [JsonProperty(PropertyName = "entityName")]
        public string EntityName { get; set; }
        
        /// <value>
        /// Filter rules with regular expression to specify folder names for this metadata harvest.
        /// </value>
        [JsonProperty(PropertyName = "folderNameFilter")]
        public string FolderNameFilter { get; set; }
        
        /// <value>
        /// Filter rules with regular expression to specify entity names for this metadata harvest.
        /// </value>
        [JsonProperty(PropertyName = "entityNameFilter")]
        public string EntityNameFilter { get; set; }
        
        /// <value>
        /// Specify if sample data to be extracted as part of this harvest.
        /// </value>
        [JsonProperty(PropertyName = "isSampleDataExtracted")]
        public System.Nullable<bool> IsSampleDataExtracted { get; set; }
        
        /// <value>
        /// Specify the sample data size in MB, specified as number of rows, for this metadata harvest.
        /// </value>
        [JsonProperty(PropertyName = "sampleDataSizeInMBs")]
        public System.Nullable<int> SampleDataSizeInMBs { get; set; }
        
    }
}
