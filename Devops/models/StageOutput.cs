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
using Newtonsoft.Json.Linq;

namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Details of the generated artifact or report.
    /// </summary>
    [JsonConverter(typeof(StageOutputModelConverter))]
    public class StageOutput 
    {
                ///
        /// <value>
        /// Type of output generated.
        /// </value>
        ///
        public enum OutputTypeEnum {
            [EnumMember(Value = "ARTIFACT")]
            Artifact,
            [EnumMember(Value = "TEST_REPORT")]
            TestReport
        };

        
        /// <value>
        /// Name of stage step at which this output is generated.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StepName is required.")]
        [JsonProperty(PropertyName = "stepName")]
        public string StepName { get; set; }
        
    }

    public class StageOutputModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(StageOutput);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(StageOutput);
            var discriminator = jsonObject["outputType"].Value<string>();
            switch (discriminator)
            {
                case "TEST_REPORT":
                    obj = new TestReportOutput();
                    break;
                case "ARTIFACT":
                    obj = new GenericArtifacts();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
