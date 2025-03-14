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

namespace Oci.MediaservicesService.Models
{
    /// <summary>
    /// Information to run the MediaWorkflow.
    /// </summary>
    [JsonConverter(typeof(CreateMediaWorkflowJobDetailsModelConverter))]
    public class CreateMediaWorkflowJobDetails 
    {
                ///
        /// <value>
        /// Discriminate identification of a workflow by name versus a workflow by ID.
        /// </value>
        ///
        public enum WorkflowIdentifierTypeEnum {
            [EnumMember(Value = "ID")]
            Id,
            [EnumMember(Value = "NAME")]
            Name
        };

        
        /// <value>
        /// Configurations to be applied to this run of the workflow.
        /// </value>
        [JsonProperty(PropertyName = "mediaWorkflowConfigurationIds")]
        public System.Collections.Generic.List<string> MediaWorkflowConfigurationIds { get; set; }
        
        /// <value>
        /// ID of the compartment in which the job should be created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Name of the Media Workflow Job. Does not have to be unique. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Parameters that override parameters specified in MediaWorkflowTaskDeclarations, the MediaWorkflow,
        /// the MediaWorkflow's MediaWorkflowConfigurations and the MediaWorkflowConfigurations of this
        /// MediaWorkflowJob. The parameters are given as JSON. The top level and 2nd level elements must be
        /// JSON objects (vs arrays, scalars, etc). The top level keys refer to a task's key and the 2nd level
        /// keys refer to a parameter's name.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.Dictionary<string, System.Object> Parameters { get; set; }
        
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
        
        /// <value>
        /// Locks associated with this resource.
        /// </value>
        [JsonProperty(PropertyName = "locks")]
        public System.Collections.Generic.List<ResourceLock> Locks { get; set; }
        
    }

    public class CreateMediaWorkflowJobDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateMediaWorkflowJobDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateMediaWorkflowJobDetails);
            var discriminator = jsonObject["workflowIdentifierType"].Value<string>();
            switch (discriminator)
            {
                case "NAME":
                    obj = new CreateMediaWorkflowJobByNameDetails();
                    break;
                case "ID":
                    obj = new CreateMediaWorkflowJobByIdDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
