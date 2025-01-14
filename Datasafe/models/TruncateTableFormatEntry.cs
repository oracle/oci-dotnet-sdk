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
    /// The Truncate Table masking format drops all the rows in a table. If one of the
    /// columns in a table is masked using Truncate Table, the entire table is truncated,
    /// so no other masking format can be used for any of the other columns in that table.
    /// If a table is being truncated, it cannot be referred to by a foreign key constraint
    /// or a dependent column. To learn more, check Truncate Table in the Data Safe documentation. 
    /// 
    /// </summary>
    public class TruncateTableFormatEntry : FormatEntry
    {
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "TRUNCATE_TABLE";
    }
}
