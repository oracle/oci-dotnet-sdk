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
    /// The properties of a member in a DR protection group.
    /// </summary>
    [JsonConverter(typeof(DrProtectionGroupMemberModelConverter))]
    public class DrProtectionGroupMember 
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

    public class DrProtectionGroupMemberModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(DrProtectionGroupMember);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(DrProtectionGroupMember);
            var discriminator = jsonObject["memberType"].Value<string>();
            switch (discriminator)
            {
                case "VOLUME_GROUP":
                    obj = new DrProtectionGroupMemberVolumeGroup();
                    break;
                case "NETWORK_LOAD_BALANCER":
                    obj = new DrProtectionGroupMemberNetworkLoadBalancer();
                    break;
                case "OBJECT_STORAGE_BUCKET":
                    obj = new DrProtectionGroupMemberObjectStorageBucket();
                    break;
                case "FILE_SYSTEM":
                    obj = new DrProtectionGroupMemberFileSystem();
                    break;
                case "COMPUTE_INSTANCE_MOVABLE":
                    obj = new DrProtectionGroupMemberComputeInstanceMovable();
                    break;
                case "AUTONOMOUS_DATABASE":
                    obj = new DrProtectionGroupMemberAutonomousDatabase();
                    break;
                case "LOAD_BALANCER":
                    obj = new DrProtectionGroupMemberLoadBalancer();
                    break;
                case "COMPUTE_INSTANCE":
                    obj = new DrProtectionGroupMemberComputeInstance();
                    break;
                case "COMPUTE_INSTANCE_NON_MOVABLE":
                    obj = new DrProtectionGroupMemberComputeInstanceNonMovable();
                    break;
                case "AUTONOMOUS_CONTAINER_DATABASE":
                    obj = new DrProtectionGroupMemberAutonomousContainerDatabase();
                    break;
                case "DATABASE":
                    obj = new DrProtectionGroupMemberDatabase();
                    break;
                case "OKE_CLUSTER":
                    obj = new DrProtectionGroupMemberOkeCluster();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under DrProtectionGroupMember! Returning null value.");
            }
            return obj;
        }
    }
}
