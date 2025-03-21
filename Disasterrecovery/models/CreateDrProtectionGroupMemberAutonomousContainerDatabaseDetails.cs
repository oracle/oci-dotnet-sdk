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


namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// Create properties for an Autonomous Container Database member.
    /// </summary>
    public class CreateDrProtectionGroupMemberAutonomousContainerDatabaseDetails : CreateDrProtectionGroupMemberDetails
    {
        
        /// <value>
        /// The type of connection strings used to connect to an Autonomous Container Database snapshot standby created during a DR Drill operation.
        /// See https://docs.oracle.com/en/cloud/paas/autonomous-database/dedicated/adbcl/index.html for information about these service types.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectionStringType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AutonomousContainerDatabaseSnapshotStandbyConnectionStringType> ConnectionStringType { get; set; }
        
        [JsonProperty(PropertyName = "memberType")]
        private readonly string memberType = "AUTONOMOUS_CONTAINER_DATABASE";
    }
}
