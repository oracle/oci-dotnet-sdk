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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The resource represents the state of a specific entry type deployment on a target.
    /// 
    /// </summary>
    public class SecurityPolicyEntryStateSummary 
    {
        
        /// <value>
        /// Unique id of the security policy entry state.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the security policy entry associated.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecurityPolicyEntryId is required.")]
        [JsonProperty(PropertyName = "securityPolicyEntryId")]
        public string SecurityPolicyEntryId { get; set; }
        
        /// <value>
        /// The OCID of the security policy deployment associated.
        /// </value>
        [JsonProperty(PropertyName = "securityPolicyDeploymentId")]
        public string SecurityPolicyDeploymentId { get; set; }
        
        /// <value>
        /// The current deployment status of the security policy deployment and the security policy entry associated.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeploymentStatus is required.")]
        [JsonProperty(PropertyName = "deploymentStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SecurityPolicyEntryStateDeploymentStatus> DeploymentStatus { get; set; }
        
    }
}
