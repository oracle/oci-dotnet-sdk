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
    /// The object-bounding polygon box.
    /// </summary>
    public class BoundingPolygon 
    {
        
        /// <value>
        /// An array of normalized points defining the polygon's perimeter, with an implicit segment between subsequent points and between the first and last point.
        /// Rectangles are defined with four points. For example, `[{\"x\": 0, \"y\": 0}, {\"x\": 1, \"y\": 0}, {\"x\": 1, \"y\": 0.5}, {\"x\": 0, \"y\": 0.5}]` represents the top half of an image.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NormalizedVertices is required.")]
        [JsonProperty(PropertyName = "normalizedVertices")]
        public System.Collections.Generic.List<NormalizedVertex> NormalizedVertices { get; set; }
        
    }
}
