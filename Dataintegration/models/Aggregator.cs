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
    /// The information about the aggregator operator. The aggregate operator performs calculations, like sum or count, on all rows or a group of rows to create new, derivative attributes.
    /// </summary>
    public class Aggregator : Operator
    {
        
        [JsonProperty(PropertyName = "groupByColumns")]
        public DynamicProxyField GroupByColumns { get; set; }
        
        [JsonProperty(PropertyName = "materializedGroupByColumns")]
        public MaterializedDynamicField MaterializedGroupByColumns { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "AGGREGATOR_OPERATOR";
    }
}
