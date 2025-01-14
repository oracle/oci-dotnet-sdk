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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The information about the OCI Dataflow task.
    /// </summary>
    public class TaskSummaryFromOCIDataflowTask : TaskSummary
    {
        
        [JsonProperty(PropertyName = "dataflowApplication")]
        public DataflowApplication DataflowApplication { get; set; }
        
        [JsonProperty(PropertyName = "driverShapeDetails")]
        public ShapeDetails DriverShapeDetails { get; set; }
        
        [JsonProperty(PropertyName = "executorShapeDetails")]
        public ShapeDetails ExecutorShapeDetails { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "OCI_DATAFLOW_TASK";
    }
}
