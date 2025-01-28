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

namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// Create properties for a member in a DR protection group.
    /// </summary>
    [JsonConverter(typeof(CreateDrProtectionGroupMemberDetailsModelConverter))]
    public class CreateDrProtectionGroupMemberDetails 
    {
        
        /// <value>
        /// The OCID of the member.
        /// <br/>
        /// Example: ocid1.instance.oc1..uniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MemberId is required.")]
        [JsonProperty(PropertyName = "memberId")]
        public string MemberId { get; set; }
        
        
    }

    public class CreateDrProtectionGroupMemberDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateDrProtectionGroupMemberDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateDrProtectionGroupMemberDetails);
            var discriminator = jsonObject["memberType"].Value<string>();
            switch (discriminator)
            {
                case "COMPUTE_INSTANCE_MOVABLE":
                    obj = new CreateDrProtectionGroupMemberComputeInstanceMovableDetails();
                    break;
                case "AUTONOMOUS_CONTAINER_DATABASE":
                    obj = new CreateDrProtectionGroupMemberAutonomousContainerDatabaseDetails();
                    break;
                case "COMPUTE_INSTANCE_NON_MOVABLE":
                    obj = new CreateDrProtectionGroupMemberComputeInstanceNonMovableDetails();
                    break;
                case "COMPUTE_INSTANCE":
                    obj = new CreateDrProtectionGroupMemberComputeInstanceDetails();
                    break;
                case "DATABASE":
                    obj = new CreateDrProtectionGroupMemberDatabaseDetails();
                    break;
                case "AUTONOMOUS_DATABASE":
                    obj = new CreateDrProtectionGroupMemberAutonomousDatabaseDetails();
                    break;
                case "NETWORK_LOAD_BALANCER":
                    obj = new CreateDrProtectionGroupMemberNetworkLoadBalancerDetails();
                    break;
                case "VOLUME_GROUP":
                    obj = new CreateDrProtectionGroupMemberVolumeGroupDetails();
                    break;
                case "OKE_CLUSTER":
                    obj = new CreateDrProtectionGroupMemberOkeClusterDetails();
                    break;
                case "FILE_SYSTEM":
                    obj = new CreateDrProtectionGroupMemberFileSystemDetails();
                    break;
                case "OBJECT_STORAGE_BUCKET":
                    obj = new CreateDrProtectionGroupMemberObjectStorageBucketDetails();
                    break;
                case "LOAD_BALANCER":
                    obj = new CreateDrProtectionGroupMemberLoadBalancerDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
