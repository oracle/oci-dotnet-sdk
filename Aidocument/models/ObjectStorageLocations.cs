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


namespace Oci.AidocumentService.Models
{
    /// <summary>
    /// A list of object locations in Object Storage.
    /// </summary>
    public class ObjectStorageLocations : InputLocation
    {
        
        /// <value>
        /// The list of ObjectLocations.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectLocations is required.")]
        [JsonProperty(PropertyName = "objectLocations")]
        public System.Collections.Generic.List<ObjectLocation> ObjectLocations { get; set; }
        
        [JsonProperty(PropertyName = "sourceType")]
        private readonly string sourceType = "OBJECT_STORAGE_LOCATIONS";
    }
}
