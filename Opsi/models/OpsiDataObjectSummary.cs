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

namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Summary of an OPSI data object.
    /// </summary>
    [JsonConverter(typeof(OpsiDataObjectSummaryModelConverter))]
    public class OpsiDataObjectSummary 
    {
        
        /// <value>
        /// Unique identifier of OPSI data object.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Identifier is required.")]
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        
        /// <value>
        /// User-friendly name of OPSI data object.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description of OPSI data object.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Name of the data object, which can be used in data object queries just like how view names are used in a query.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Names of all the groups to which the data object belongs to.
        /// </value>
        [JsonProperty(PropertyName = "groupNames")]
        public System.Collections.Generic.List<string> GroupNames { get; set; }
        
    }

    public class OpsiDataObjectSummaryModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(OpsiDataObjectSummary);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(OpsiDataObjectSummary);
            var discriminator = jsonObject["dataObjectType"].Value<string>();
            switch (discriminator)
            {
                case "HOST_INSIGHTS_DATA_OBJECT":
                    obj = new HostInsightsDataObjectSummary();
                    break;
                case "DATABASE_INSIGHTS_DATA_OBJECT":
                    obj = new DatabaseInsightsDataObjectSummary();
                    break;
                case "EXADATA_INSIGHTS_DATA_OBJECT":
                    obj = new ExadataInsightsDataObjectSummary();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under OpsiDataObjectSummary! Returning null value.");
            }
            return obj;
        }
    }
}
