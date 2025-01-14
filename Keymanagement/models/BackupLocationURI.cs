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


namespace Oci.KeymanagementService.Models
{
    /// <summary>
    /// PreAuthenticated object storage URI to upload or download the backup
    /// </summary>
    public class BackupLocationURI : BackupLocation
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Uri is required.")]
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
        
        [JsonProperty(PropertyName = "destination")]
        private readonly string destination = "PRE_AUTHENTICATED_REQUEST_URI";
    }
}
