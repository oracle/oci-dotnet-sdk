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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Details to access Premigration Advisor report.
    /// 
    /// </summary>
    public class AdvisorReportLocationDetails 
    {
        
        [JsonProperty(PropertyName = "objectStorageDetails")]
        public AdvisorReportBucketDetails ObjectStorageDetails { get; set; }
        
        /// <value>
        /// File system path on the Source Database host where the Premigration Advisor report can be accessed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "locationInSource")]
        public string LocationInSource { get; set; }
        
    }
}
