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
    /// The information to be updated.
    /// </summary>
    [JsonConverter(typeof(UpdateHostInsightDetailsModelConverter))]
    public class UpdateHostInsightDetails 
    {
        
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }

    public class UpdateHostInsightDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(UpdateHostInsightDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(UpdateHostInsightDetails);
            var discriminator = jsonObject["entitySource"].Value<string>();
            switch (discriminator)
            {
                case "MACS_MANAGED_CLOUD_DB_HOST":
                    obj = new UpdateMacsManagedCloudDatabaseHostInsightDetails();
                    break;
                case "EM_MANAGED_EXTERNAL_HOST":
                    obj = new UpdateEmManagedExternalHostInsightDetails();
                    break;
                case "MACS_MANAGED_EXTERNAL_HOST":
                    obj = new UpdateMacsManagedExternalHostInsightDetails();
                    break;
                case "MACS_MANAGED_CLOUD_HOST":
                    obj = new UpdateMacsManagedCloudHostInsightDetails();
                    break;
                case "PE_COMANAGED_HOST":
                    obj = new UpdatePeComanagedHostInsightDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
