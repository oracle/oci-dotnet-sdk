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


namespace Oci.ApmtracesService.Models
{
    /// <summary>
    /// Bulk request object containing the details of the attributes to be pinned.
    /// 
    /// </summary>
    public class BulkPinAttributeDetails 
    {
        
        /// <value>
        /// Collection of objects containing the details about individual attribute to be pinned.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "attributeDetails")]
        public System.Collections.Generic.List<BulkPinAttributeDetail> AttributeDetails { get; set; }
        
    }
}
