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


namespace Oci.FilestorageService.Models
{
    /// <summary>
    /// Validate keytabs request details.
    /// </summary>
    public class ValidateKeyTabsDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the mount target whose keytabs are to be validated.
        /// </value>
        [JsonProperty(PropertyName = "mountTargetId")]
        public string MountTargetId { get; set; }
        
        [JsonProperty(PropertyName = "keyTabSecretDetails")]
        public KeyTabSecretDetails KeyTabSecretDetails { get; set; }
        
    }
}
