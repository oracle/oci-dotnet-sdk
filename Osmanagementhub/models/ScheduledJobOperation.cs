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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Defines an operation that is performed by a scheduled job.
    /// </summary>
    public class ScheduledJobOperation 
    {
        
        /// <value>
        /// The type of operation this scheduled job performs.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperationType is required.")]
        [JsonProperty(PropertyName = "operationType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OperationTypes> OperationType { get; set; }
        
        /// <value>
        /// The names of the target packages. This parameter only applies when the scheduled job is for installing, updating, or removing packages.
        /// </value>
        [JsonProperty(PropertyName = "packageNames")]
        public System.Collections.Generic.List<string> PackageNames { get; set; }
        
        /// <value>
        /// Unique identifier for the Windows update. This parameter only applies if the scheduled job is for installing Windows updates.
        /// Note that this is not an OCID, but is a unique identifier assigned by Microsoft.
        /// For Example: '6981d463-cd91-4a26-b7c4-ea4ded9183ed'.
        /// </value>
        [JsonProperty(PropertyName = "windowsUpdateNames")]
        public System.Collections.Generic.List<string> WindowsUpdateNames { get; set; }
        
        [JsonProperty(PropertyName = "manageModuleStreamsDetails")]
        public ManageModuleStreamsInScheduledJobDetails ManageModuleStreamsDetails { get; set; }
        
        [JsonProperty(PropertyName = "switchModuleStreamsDetails")]
        public ModuleStreamDetails SwitchModuleStreamsDetails { get; set; }
        
        /// <value>
        /// The software source [OCIDs](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm). 
        /// This parameter only applies when the scheduled job is for attaching or detaching software sources.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "softwareSourceIds")]
        public System.Collections.Generic.List<string> SoftwareSourceIds { get; set; }
        
        /// <value>
        /// The number of minutes the service waits for the reboot to complete. If the instance doesn't reboot within the 
        /// timeout, the service marks the reboot job as failed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rebootTimeoutInMins")]
        public System.Nullable<int> RebootTimeoutInMins { get; set; }
        
    }
}
