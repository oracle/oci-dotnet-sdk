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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The Preserve Original Data masking format retains the original values in a column.
    /// It is useful in conditional masking when you want to preserve a subset of values 
    /// in a column and mask the remaining values using some other masking formats. To 
    /// learn more, check Preserve Original Data in the Data Safe documentation.
    /// 
    /// </summary>
    public class PreserveOriginalDataFormatEntry : FormatEntry
    {
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "PRESERVE_ORIGINAL_DATA";
    }
}
