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
    /// Stage Exadata Fleet Update Action details.
    /// 
    /// </summary>
    public class StageAction : FsuAction
    {
        
        /// <value>
        /// OCID identifier for the Exadata Fleet Update Cycle the Action will be part of.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FsuCycleId is required.")]
        [JsonProperty(PropertyName = "fsuCycleId")]
        public string FsuCycleId { get; set; }
        
        /// <value>
        /// OCID identifier for the Exadata Fleet Update Action.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "relatedFsuActionId")]
        public string RelatedFsuActionId { get; set; }
        
        [JsonProperty(PropertyName = "scheduleDetails")]
        public ScheduleDetails ScheduleDetails { get; set; }
        
        [JsonProperty(PropertyName = "progress")]
        public FsuActionProgressDetails Progress { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "STAGE";
    }
}
