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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Details of copy object.
    /// </summary>
    public class CreateCopyObjectRequestDetails 
    {
        
        /// <value>
        /// The workspace id of the source from where we need to copy object.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceWorkspaceId is required.")]
        [JsonProperty(PropertyName = "sourceWorkspaceId")]
        public string SourceWorkspaceId { get; set; }
        
        /// <value>
        /// The list of the objects to be copied.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectKeys is required.")]
        [JsonProperty(PropertyName = "objectKeys")]
        public System.Collections.Generic.List<string> ObjectKeys { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CopyConflictResolution is required.")]
        [JsonProperty(PropertyName = "copyConflictResolution")]
        public CopyConflictResolution CopyConflictResolution { get; set; }
        
    }
}
