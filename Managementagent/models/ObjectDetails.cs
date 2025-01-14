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


namespace Oci.ManagementagentService.Models
{
    /// <summary>
    /// Details of the Objectstorage object
    /// </summary>
    public class ObjectDetails 
    {
        
        /// <value>
        /// Objectstorage namespace reference providing the original location of this object
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectNamespace is required.")]
        [JsonProperty(PropertyName = "objectNamespace")]
        public string ObjectNamespace { get; set; }
        
        /// <value>
        /// Objectstorage bucket reference providing the original location of this object
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectBucket is required.")]
        [JsonProperty(PropertyName = "objectBucket")]
        public string ObjectBucket { get; set; }
        
        /// <value>
        /// Objectstorage object name reference providing the original location of this object
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectName is required.")]
        [JsonProperty(PropertyName = "objectName")]
        public string ObjectName { get; set; }
        
        /// <value>
        /// Object storage URL for download
        /// </value>
        [JsonProperty(PropertyName = "objectUrl")]
        public string ObjectUrl { get; set; }
        
        /// <value>
        /// Object content SHA256 Hash
        /// </value>
        [JsonProperty(PropertyName = "checksum")]
        public string Checksum { get; set; }
        
    }
}
