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


namespace Oci.PsqlService.Models
{
    /// <summary>
    /// An operation that recursively updates items of the selection, or adding the value if the selection is empty.
    /// If the value is not an object, it is used directly, otherwise each key-value member is used
    /// to create or update a member of the same name in the target and the same process is applied recursively for each object-typed value
    /// (similar to [RFC 7396](https://tools.ietf.org/html/rfc7396#section-2) JSON Merge Patch, except that null values are copied
    /// rather than transformed into deletions).
    /// NOT_FOUND exceptions are handled by creating the implied containing structure.
    /// To avoid referential errors if an item's descendant is also in the selection, items of the selection are processed in order of decreasing depth.
    /// 
    /// </summary>
    public class PatchMergeInstruction : PatchInstruction
    {
        
        /// <value>
        /// A value to be merged into the target.
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public System.Object Value { get; set; }
        
        [JsonProperty(PropertyName = "operation")]
        private readonly string operation = "MERGE";
    }
}
