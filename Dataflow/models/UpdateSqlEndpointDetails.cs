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


namespace Oci.DataflowService.Models
{
    /// <summary>
    /// The information about all updatable parameters of a SQL Endpoint.
    /// </summary>
    public class UpdateSqlEndpointDetails 
    {
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The SQL Endpoint name, which can be changed.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The description of CreateSQLEndpointDetails.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The shape of the SQL Endpoint driver instance.
        /// </value>
        [JsonProperty(PropertyName = "driverShape")]
        public string DriverShape { get; set; }
        
        [JsonProperty(PropertyName = "driverShapeConfig")]
        public ShapeConfig DriverShapeConfig { get; set; }
        
        /// <value>
        /// The shape of the SQL Endpoint worker instance.
        /// </value>
        [JsonProperty(PropertyName = "executorShape")]
        public string ExecutorShape { get; set; }
        
        [JsonProperty(PropertyName = "executorShapeConfig")]
        public ShapeConfig ExecutorShapeConfig { get; set; }
        
        /// <value>
        /// The minimum number of executors.
        /// </value>
        [JsonProperty(PropertyName = "minExecutorCount")]
        public System.Nullable<int> MinExecutorCount { get; set; }
        
        /// <value>
        /// The maximum number of executors.
        /// </value>
        [JsonProperty(PropertyName = "maxExecutorCount")]
        public System.Nullable<int> MaxExecutorCount { get; set; }
        
        /// <value>
        /// Metastore OCID
        /// </value>
        [JsonProperty(PropertyName = "metastoreId")]
        public string MetastoreId { get; set; }
        
        /// <value>
        /// OCI lake OCID
        /// </value>
        [JsonProperty(PropertyName = "lakeId")]
        public string LakeId { get; set; }
        
        /// <value>
        /// The Spark configuration passed to the running process.
        /// See https://spark.apache.org/docs/latest/configuration.html#available-properties.
        /// Example: { &quot;spark.app.name&quot; : &quot;My App Name&quot;, &quot;spark.shuffle.io.maxRetries&quot; : &quot;4&quot; }Note: Not all Spark properties are permitted to be set.  Attempting to set a property that isnot allowed to be overwritten will cause a 400 status to be returned.
        /// </value>
        [JsonProperty(PropertyName = "sparkAdvancedConfigurations")]
        public System.Collections.Generic.Dictionary<string, string> SparkAdvancedConfigurations { get; set; }
        
    }
}
