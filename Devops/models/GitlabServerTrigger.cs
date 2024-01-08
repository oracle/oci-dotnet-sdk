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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Trigger specific to GitLab self-hosted server.
    /// </summary>
    public class GitlabServerTrigger : Trigger
    {
        
        /// <value>
        /// The endpoint that listens to trigger events.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TriggerUrl is required.")]
        [JsonProperty(PropertyName = "triggerUrl")]
        public string TriggerUrl { get; set; }
        
        [JsonProperty(PropertyName = "triggerSource")]
        private readonly string triggerSource = "GITLAB_SERVER";
    }
}
