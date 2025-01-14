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
using Newtonsoft.Json.Linq;

namespace Oci.NetworkfirewallService.Models
{
    /// <summary>
    /// Tunnel Inspection Rule used in the firewall policy rules.
    /// Tunnel Inspection Rule determines whether tunnel inspection is applied on the traffic based on attributes
    /// such as  Tunnel Inspect protocol, the source and destination IP addresses.
    /// 
    /// </summary>
    [JsonConverter(typeof(TunnelInspectionRuleModelConverter))]
    public class TunnelInspectionRule 
    {
        
        /// <value>
        /// Name for the Tunnel Inspection Rule, must be unique within the policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        
        /// <value>
        /// Types of Inspect Action on the Traffic flow.
        /// <br/>
        ///   * INSPECT - Inspect the traffic.
        ///   * INSPECT_AND_CAPTURE_LOG - Inspect and capture logs for the traffic.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<InspectActionType> Action { get; set; }
        
        /// <value>
        /// The priority order in which this rule should be evaluated
        /// </value>
        [JsonProperty(PropertyName = "priorityOrder")]
        public System.Nullable<long> PriorityOrder { get; set; }
        
        [JsonProperty(PropertyName = "position")]
        public RulePosition Position { get; set; }
        
        /// <value>
        /// OCID of the Network Firewall Policy this Tunnel Inspection Rule belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ParentResourceId is required.")]
        [JsonProperty(PropertyName = "parentResourceId")]
        public string ParentResourceId { get; set; }
        
    }

    public class TunnelInspectionRuleModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(TunnelInspectionRule);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(TunnelInspectionRule);
            var discriminator = jsonObject["protocol"].Value<string>();
            switch (discriminator)
            {
                case "VXLAN":
                    obj = new VxlanInspectionRule();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under TunnelInspectionRule! Returning null value.");
            }
            return obj;
        }
    }
}
