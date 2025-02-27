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

namespace Oci.CoreService.Models
{
    /// <summary>
    /// Creation details for an instance configuration.
    /// 
    /// </summary>
    [JsonConverter(typeof(CreateInstanceConfigurationBaseModelConverter))]
    public class CreateInstanceConfigurationBase 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment
        /// containing the instance configuration.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
                ///
        /// <value>
        /// The source of the instance configuration. An instance configuration defines the
        /// settings to use when creating Compute instances, including details
        /// such as the base image, shape, and metadata. You can also specify the associated resources for the
        /// instance, such as block volume attachments and network configuration.
        /// <br/>
        /// When you create an instance configuration using an existing instance as a template, the instance
        /// configuration does not include any information from the source instance's boot volume, such as installed
        /// applications, binaries, and files on the instance. It also does not include the contents of
        /// any block volumes that are attached to the instance.
        /// <br/>
        /// To create an instance configuration that includes the custom setup from an instance's boot volume, you
        /// must first create a custom image from the instance (see {@link #createImage(CreateImageRequest) createImage}).
        /// Then, use the custom image to launch a new instance
        /// (see {@link #launchInstance(LaunchInstanceRequest) launchInstance}). Finally, create the instance
        /// configuration based on the instance that you created from the custom image.
        /// <br/>
        /// To include block volume contents with an instance configuration, first create a backup of the attached block volumes
        /// (see {@link #createVolumeBackup(CreateVolumeBackupRequest) createVolumeBackup}). Then, create the instance
        /// configuration by specifying the list of settings, using
        /// {@link #instanceConfigurationVolumeSourceFromVolumeBackupDetails(InstanceConfigurationVolumeSourceFromVolumeBackupDetailsRequest) instanceConfigurationVolumeSourceFromVolumeBackupDetails}
        /// to include the block volume backups in the list of settings.
        /// <br/>
        /// The following values are supported:
        /// <br/>
        /// * `NONE`: Creates an instance configuration using the list of settings that you specify.
        /// * `INSTANCE`: Creates an instance configuration using an existing instance as a template.
        /// 
        /// </value>
        ///
        public enum SourceEnum {
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "INSTANCE")]
            Instance
        };

        
    }

    public class CreateInstanceConfigurationBaseModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateInstanceConfigurationBase);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateInstanceConfigurationBase);
            var discriminator = jsonObject["source"].Value<string>();
            switch (discriminator)
            {
                case "NONE":
                    obj = new CreateInstanceConfigurationDetails();
                    break;
                case "INSTANCE":
                    obj = new CreateInstanceConfigurationFromInstanceDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
