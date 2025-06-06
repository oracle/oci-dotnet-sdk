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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// Details to change managed MySQL database management type.
    /// </summary>
    public class ChangeMysqlDatabaseManagementTypeDetails 
    {
        
        /// <value>
        /// The type of HeatWave management.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManagementType is required.")]
        [JsonProperty(PropertyName = "managementType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ManagedMySqlDatabase.HeatWaveManagementTypeEnum> ManagementType { get; set; }
                ///
        /// <value>
        /// The type of operation to perform: update managementType, enable or disable database management.
        /// 
        /// </value>
        ///
        public enum OperationEnum {
            [EnumMember(Value = "ENABLE_DBMGMT")]
            EnableDbmgmt,
            [EnumMember(Value = "UPDATE_DBMGMT_TYPE")]
            UpdateDbmgmtType,
            [EnumMember(Value = "DISABLE_DBMGMT")]
            DisableDbmgmt
        };

        /// <value>
        /// The type of operation to perform: update managementType, enable or disable database management.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "operation")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OperationEnum> Operation { get; set; }
        
    }
}
