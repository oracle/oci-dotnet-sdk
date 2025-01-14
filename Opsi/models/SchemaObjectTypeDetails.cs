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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Schema object details
    /// </summary>
    public class SchemaObjectTypeDetails : RelatedObjectTypeDetails
    {
        
        /// <value>
        /// Object id (from RDBMS)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectId is required.")]
        [JsonProperty(PropertyName = "objectId")]
        public System.Nullable<int> ObjectId { get; set; }
        
        /// <value>
        /// Owner of object
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Owner is required.")]
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }
        
        /// <value>
        /// Name of object
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectName is required.")]
        [JsonProperty(PropertyName = "objectName")]
        public string ObjectName { get; set; }
        
        /// <value>
        /// Subobject name; for example, partition name
        /// </value>
        [JsonProperty(PropertyName = "subObjectName")]
        public string SubObjectName { get; set; }
        
        /// <value>
        /// Type of the object (such as TABLE, INDEX)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectType is required.")]
        [JsonProperty(PropertyName = "objectType")]
        public string ObjectType { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "SCHEMA_OBJECT";
    }
}
