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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Migration tablespace settings valid for TARGET_DEFAULTS_REMAP target type. The service will compute the targetType
    /// that corresponds to the targetDatabaseConnectionId type, and set the corresponding default values. When target type is ADB_S,
    /// ADB_D or NON_ADB the default will be set to remap feature ADB_S_REMAP, ADB_D_REMAP or NON_ADB_REMAP.
    /// 
    /// </summary>
    public class UpdateTargetDefaultsRemapTablespaceDetails : UpdateTargetTypeTablespaceDetails
    {
        
        [JsonProperty(PropertyName = "targetType")]
        private readonly string targetType = "TARGET_DEFAULTS_REMAP";
    }
}
