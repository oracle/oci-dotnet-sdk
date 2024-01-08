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


namespace Oci.ThreatintelligenceService.Models
{
    /// <summary>
    /// Summary of a data signature observed on a network or host that indicates a potential security threat.
    /// </summary>
    public class IndicatorSummary 
    {
        
        /// <value>
        /// The OCID of the indicator.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The type of indicator.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<IndicatorType> Type { get; set; }
        
        /// <value>
        /// The indicator data value.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// An integer from 0 to 100 that represents how certain we are that the indicator is malicious and a potential threat if it is detected communicating with your cloud resources. This confidence value is aggregated from the confidence in the threat types, attributes, and relationships to create an overall value for the indicator.
        /// </value>
        [JsonProperty(PropertyName = "confidence")]
        public System.Nullable<int> Confidence { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains this indicator.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Characteristics of the threat indicator based on previous observations or behavior. May include related tactics, techniques, and procedures.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ThreatTypes is required.")]
        [JsonProperty(PropertyName = "threatTypes")]
        public System.Collections.Generic.List<string> ThreatTypes { get; set; }
        
        /// <value>
        /// A map of attributes with additional information about the indicator.
        /// Each attribute has a name (string), value (string), and attribution (supporting data).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Attributes is required.")]
        [JsonProperty(PropertyName = "attributes")]
        public System.Collections.Generic.List<IndicatorAttributeSummary> Attributes { get; set; }
        
        /// <value>
        /// The state of the indicator. It will always be `ACTIVE`.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The date and time that the indicator was first detected. An RFC3339 formatted string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time that this indicator was last updated by the system.  Updates can include new reports or regular updates in confidence. The value is the same as `timeCreated` for a new indicator. An RFC3339 formatted string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The date and time that this indicator was last seen. The value is the same as `timeCreated` for a new indicator. An RFC3339 formatted string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeLastSeen is required.")]
        [JsonProperty(PropertyName = "timeLastSeen")]
        public System.Nullable<System.DateTime> TimeLastSeen { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Geodata is required.")]
        [JsonProperty(PropertyName = "geodata")]
        public GeodataDetails Geodata { get; set; }
        
    }
}
