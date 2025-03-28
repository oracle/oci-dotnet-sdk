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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Details for converting a non-container database to pluggable database.
    /// 
    /// </summary>
    public class ConvertToPdbDetails 
    {
                ///
        /// <value>
        /// The operations used to convert a non-container database to a pluggable database.
        /// - Use `PRECHECK` to run a pre-check operation on non-container database prior to converting it into a pluggable database.
        /// - Use `CONVERT` to convert a non-container database into a pluggable database.
        /// - Use `SYNC` if the non-container database was manually converted into a pluggable database using the dbcli command-line utility. Databases may need to be converted manually if the CONVERT action fails when converting a non-container database using the API.
        /// - Use `SYNC_ROLLBACK` if the conversion of a non-container database into a pluggable database was manually rolled back using the dbcli command line utility. Conversions may need to be manually rolled back if the CONVERT action fails when converting a non-container database using the API.
        /// 
        /// </value>
        ///
        public enum ActionEnum {
            [EnumMember(Value = "PRECHECK")]
            Precheck,
            [EnumMember(Value = "CONVERT")]
            Convert,
            [EnumMember(Value = "SYNC")]
            Sync,
            [EnumMember(Value = "SYNC_ROLLBACK")]
            SyncRollback
        };

        /// <value>
        /// The operations used to convert a non-container database to a pluggable database.
        /// - Use `PRECHECK` to run a pre-check operation on non-container database prior to converting it into a pluggable database.
        /// - Use `CONVERT` to convert a non-container database into a pluggable database.
        /// - Use `SYNC` if the non-container database was manually converted into a pluggable database using the dbcli command-line utility. Databases may need to be converted manually if the CONVERT action fails when converting a non-container database using the API.
        /// - Use `SYNC_ROLLBACK` if the conversion of a non-container database into a pluggable database was manually rolled back using the dbcli command line utility. Conversions may need to be manually rolled back if the CONVERT action fails when converting a non-container database using the API.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Action is required.")]
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ActionEnum> Action { get; set; }
        
        [JsonProperty(PropertyName = "convertToPdbTargetDetails")]
        public ConvertToPdbTargetBase ConvertToPdbTargetDetails { get; set; }
        
    }
}
