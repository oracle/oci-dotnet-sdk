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


namespace Oci.ContainerinstancesService.Models
{
    /// <summary>
    /// A single container on a container instance.
    /// <br/>
    /// If you delete a container, the record remains visible for a short period
    /// of time before being permanently removed.
    /// 
    /// </summary>
    public class Container 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the container.
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
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the container.
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
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}.
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}.
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
        /// <value>
        /// The availability domain where the container instance that hosts the container runs.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The fault domain of the container instance that hosts the container runs.
        /// </value>
        [JsonProperty(PropertyName = "faultDomain")]
        public string FaultDomain { get; set; }
                ///
        /// <value>
        /// The current state of the container.
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
        /// The current state of the container.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A message that describes the current state of the container in more detail. Can be used to provide
        /// actionable information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The exit code of the container process when it stopped running.
        /// </value>
        [JsonProperty(PropertyName = "exitCode")]
        public System.Nullable<int> ExitCode { get; set; }
        
        /// <value>
        /// The time when the container last deleted (terminated), in the format defined by [RFC 3339](https://tools.ietf.org/rfc/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "timeTerminated")]
        public System.Nullable<System.DateTime> TimeTerminated { get; set; }
        
        /// <value>
        /// The time the container was created, in the format defined by [RFC 3339](https://tools.ietf.org/rfc/rfc3339).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the container was updated, in the format defined by [RFC 3339](https://tools.ietf.org/rfc/rfc3339).
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the container instance that the container is running on.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ContainerInstanceId is required.")]
        [JsonProperty(PropertyName = "containerInstanceId")]
        public string ContainerInstanceId { get; set; }
        
        /// <value>
        /// The container image information. Currently only supports public Docker registry.
        /// <br/>
        /// You can provide either the image name (containerImage), image name with version (containerImagev1), or complete Docker image URL
        /// `docker.io/library/containerImage:latest`.
        /// <br/>
        /// If you do not provide a registry, the registry defaults to public Docker hub `docker.io/library`.
        /// The registry used for the container image must be reachable over the VNIC of the container instance.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ImageUrl is required.")]
        [JsonProperty(PropertyName = "imageUrl")]
        public string ImageUrl { get; set; }
        
        /// <value>
        /// This command overrides ENTRYPOINT process of the container.
        /// If you do not specify this command, the existing ENTRYPOINT process defined in the image is the default.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "command")]
        public System.Collections.Generic.List<string> Command { get; set; }
        
        /// <value>
        /// A list of string arguments for the ENTRYPOINT process of the container.
        /// <br/>
        /// Many containers use an ENTRYPOINT process pointing to a shell
        /// `/bin/bash`. For those containers, you can use the argument list to specify the main command in the container process.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "arguments")]
        public System.Collections.Generic.List<string> Arguments { get; set; }
        
        /// <value>
        /// The working directory within the container's filesystem for
        /// the container process. If not specified, the default
        /// working directory from the image is used.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "workingDirectory")]
        public string WorkingDirectory { get; set; }
        
        /// <value>
        /// A map of additional environment variables to set in the environment of the
        /// ENTRYPOINT process of the container. These variables are in addition to any variables already defined
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
        /// Determines if the container will have access to the container instance resource principal.
        /// <br/>
        /// This method utilizes resource principal version 2.2. For more information on how to use the exposed resource principal elements, see
        /// https://docs.oracle.com/en-us/iaas/Content/API/Concepts/sdk_authentication_methods.htm#sdk_authentication_methods_resource_principal.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isResourcePrincipalDisabled")]
        public System.Nullable<bool> IsResourcePrincipalDisabled { get; set; }
        
        [JsonProperty(PropertyName = "resourceConfig")]
        public ContainerResourceConfig ResourceConfig { get; set; }
        
        /// <value>
        /// The number of container restart attempts. Depending on the restart policy, a restart might be attempted after a health check failure or a container exit.
        /// </value>
        [JsonProperty(PropertyName = "containerRestartAttemptCount")]
        public System.Nullable<int> ContainerRestartAttemptCount { get; set; }
        
        [JsonProperty(PropertyName = "securityContext")]
        public SecurityContext SecurityContext { get; set; }
        
    }
}
