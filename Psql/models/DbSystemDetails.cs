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
    /// Information about the database system associated with a backup.
    /// </summary>
    public class DbSystemDetails 
    {
        
        /// <value>
        /// Type of the database system.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SystemType is required.")]
        [JsonProperty(PropertyName = "systemType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DbSystem.SystemTypeEnum> SystemType { get; set; }
        
        /// <value>
        /// The major and minor versions of the database system software.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbVersion is required.")]
        [JsonProperty(PropertyName = "dbVersion")]
        public string DbVersion { get; set; }
        
        /// <value>
        /// OCID of the configuration that was applied on the source dbSystem at the time when backup was taken.
        /// </value>
        [JsonProperty(PropertyName = "configId")]
        public string ConfigId { get; set; }
        
    }
}
