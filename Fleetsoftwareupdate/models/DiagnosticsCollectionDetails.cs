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


namespace Oci.FleetsoftwareupdateService.Models
{
    /// <summary>
    /// Details to configure diagnostics collection for targets affected by this Exadata Fleet Update Maintenance Cycle.
    /// 
    /// </summary>
    public class DiagnosticsCollectionDetails 
    {
        
        /// <value>
        /// Enable incident logs and trace collection. 
        /// Allow Oracle to collect incident logs and traces to enable fault diagnosis and issue resolution according to the selected mode.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "logCollectionMode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DataCollectionModes> LogCollectionMode { get; set; }
        
    }
}
