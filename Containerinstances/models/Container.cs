/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ContainerinstancesService.Models
{
    /// <summary>
    /// A single container on a Container Instance.
    /// <br/>
    /// If this Container is DELETED, the record will remain visible for a short period
    /// of time before being permanently removed.
    /// 
    /// </summary>
    public class Container 
    {
        
        /// <value>
        /// Unique identifier that is immutable on creation
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Display name for the Container. Can be renamed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Compartment Identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
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
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
        /// <value>
        /// Availability Domain where the Container's Instance is running.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// Fault Domain where the Container's Instance is running.
        /// </value>
        [JsonProperty(PropertyName = "faultDomain")]
        public string FaultDomain { get; set; }
                ///
        /// <value>
        /// The current state of the Container.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the Container.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. For example, can be used to provide
        /// actionable information for a resource in Failed state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The exit code of the container process if it has stopped executing.
        /// </value>
        [JsonProperty(PropertyName = "exitCode")]
        public System.Nullable<int> ExitCode { get; set; }
        
        /// <value>
        /// Time at which the container last terminated. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeTerminated")]
        public System.Nullable<System.DateTime> TimeTerminated { get; set; }
        
        /// <value>
        /// The time the the Container was created. An RFC3339 formatted datetime string
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the Container was updated. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The identifier of the Container Instance on which this container is running.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ContainerInstanceId is required.")]
        [JsonProperty(PropertyName = "containerInstanceId")]
        public string ContainerInstanceId { get; set; }
        
        /// <value>
        /// The container image information. Currently only support public docker registry. Can be either image name,
        /// e.g `containerImage`, image name with version, e.g `containerImage:v1` or complete docker image Url e.g
        /// `docker.io/library/containerImage:latest`.
        /// If no registry is provided, will default the registry to public docker hub `docker.io/library`.
        /// The registry used for container image must be reachable over the Container Instance's VNIC.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ImageUrl is required.")]
        [JsonProperty(PropertyName = "imageUrl")]
        public string ImageUrl { get; set; }
        
        /// <value>
        /// This command will override the container's entrypoint process. 
        /// If not specified, the existing entrypoint process defined in the image will be used.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "command")]
        public System.Collections.Generic.List<string> Command { get; set; }
        
        /// <value>
        /// A list of string arguments for a Container's entrypoint process.
        /// <br/>
        /// Many containers use an entrypoint process pointing to a shell,
        /// for example /bin/bash. For such containers, this argument list
        /// can also be used to specify the main command in the container process.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "arguments")]
        public System.Collections.Generic.List<string> Arguments { get; set; }
        
        /// <value>
        /// A list of additional configurable container capabilities
        /// 
        /// </value>
        [JsonProperty(PropertyName = "additionalCapabilities", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<ContainerCapability> AdditionalCapabilities { get; set; }
        
        /// <value>
        /// The working directory within the Container's filesystem for
        /// the Container process. If this is not present, the default
        /// working directory from the image will be used.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "workingDirectory")]
        public string WorkingDirectory { get; set; }
        
        /// <value>
        /// A map of additional environment variables to set in the environment of the container's
        /// entrypoint process. These variables are in addition to any variables already defined
        /// in the container's image.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "environmentVariables")]
        public System.Collections.Generic.Dictionary<string, string> EnvironmentVariables { get; set; }
        
        /// <value>
        /// List of the volume mounts.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "volumeMounts")]
        public System.Collections.Generic.List<VolumeMount> VolumeMounts { get; set; }
        
        /// <value>
        /// List of container health checks
        /// </value>
        [JsonProperty(PropertyName = "healthChecks")]
        public System.Collections.Generic.List<ContainerHealthCheck> HealthChecks { get; set; }
        
        /// <value>
        /// Determines if the Container will have access to the Container Instance Resource Principal. 
        /// This method utilizes resource principal version 2.2. Please refer to 
        /// https://docs.oracle.com/en-us/iaas/Content/API/Concepts/sdk_authentication_methods.htm#sdk_authentication_methods_resource_principal 
        /// for detailed explanation of how to leverage the exposed resource principal elements.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isResourcePrincipalDisabled")]
        public System.Nullable<bool> IsResourcePrincipalDisabled { get; set; }
        
        [JsonProperty(PropertyName = "resourceConfig")]
        public ContainerResourceConfig ResourceConfig { get; set; }
        
        /// <value>
        /// The number of container restart attempts. A restart may be attempted after a health check failure or a container exit, based on the restart policy.
        /// </value>
        [JsonProperty(PropertyName = "containerRestartAttemptCount")]
        public System.Nullable<int> ContainerRestartAttemptCount { get; set; }
        
    }
}
