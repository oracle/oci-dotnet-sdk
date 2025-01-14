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


namespace Oci.DatalabelingservicedataplaneService.Models
{
    /// <summary>
    /// The initial generate records configuration. It generates records from the dataset's source.
    /// </summary>
    public class InitialRecordGenerationConfiguration 
    {
        
        /// <value>
        /// The maximum number of records to generate.
        /// </value>
        [JsonProperty(PropertyName = "limit")]
        public System.Nullable<decimal> Limit { get; set; }
        
    }
}
