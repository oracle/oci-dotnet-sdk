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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// This is the configuration for data archiving in object storage
    /// </summary>
    public class ArchivingConfiguration 
    {
        
        /// <value>
        /// This is the duration data in active storage before data is archived, as described in
        /// https://en.wikipedia.org/wiki/ISO_8601#Durations.
        /// The largest supported unit is D, e.g. P365D (not P1Y) or P14D (not P2W).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "activeStorageDuration")]
        public string ActiveStorageDuration { get; set; }
        
        /// <value>
        /// This is the duration before archived data is deleted from object storage, as described in
        /// https://en.wikipedia.org/wiki/ISO_8601#Durations
        /// The largest supported unit is D, e.g. P365D (not P1Y) or P14D (not P2W).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "archivalStorageDuration")]
        public string ArchivalStorageDuration { get; set; }
        
    }
}
