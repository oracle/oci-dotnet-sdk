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

namespace Oci.CloudmigrationsService.Models
{
    /// <summary>
    /// Description of the target asset.
    /// </summary>
    [JsonConverter(typeof(TargetAssetModelConverter))]
    public class TargetAsset 
    {
        
        /// <value>
        /// Unique identifier that is immutable on creation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
                ///
        /// <value>
        /// The current state of the target asset.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "NEEDS_ATTENTION")]
            NeedsAttention,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the target asset.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. For example, it can be used to provide actionable information for a resource in Failed state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// OCID of the associated migration plan.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MigrationPlanId is required.")]
        [JsonProperty(PropertyName = "migrationPlanId")]
        public string MigrationPlanId { get; set; }
        
        /// <value>
        /// Compartment identifier
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Created resource identifier
        /// </value>
        [JsonProperty(PropertyName = "createdResourceId")]
        public string CreatedResourceId { get; set; }
                ///
        /// <value>
        /// The type of target asset.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "INSTANCE")]
            Instance
        };

        
        /// <value>
        /// A boolean indicating whether the asset should be migrated.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsExcludedFromExecution is required.")]
        [JsonProperty(PropertyName = "isExcludedFromExecution")]
        public System.Nullable<bool> IsExcludedFromExecution { get; set; }
        
        /// <value>
        /// Messages about the compatibility issues.
        /// </value>
        [JsonProperty(PropertyName = "compatibilityMessages")]
        public System.Collections.Generic.List<CompatibilityMessage> CompatibilityMessages { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EstimatedCost is required.")]
        [JsonProperty(PropertyName = "estimatedCost")]
        public CostEstimation EstimatedCost { get; set; }
        
        /// <value>
        /// The time when the target asset was created. An RFC3339 formatted datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time when the target asset was updated. An RFC3339 formatted datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The time when the assessment was done. An RFC3339 formatted datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeAssessed is required.")]
        [JsonProperty(PropertyName = "timeAssessed")]
        public System.Nullable<System.DateTime> TimeAssessed { get; set; }
        
        [JsonProperty(PropertyName = "migrationAsset")]
        public MigrationAsset MigrationAsset { get; set; }
        
    }

    public class TargetAssetModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(TargetAsset);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(TargetAsset);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "INSTANCE":
                    obj = new VmTargetAsset();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under TargetAsset! Returning null value.");
            }
            return obj;
        }
    }
}
