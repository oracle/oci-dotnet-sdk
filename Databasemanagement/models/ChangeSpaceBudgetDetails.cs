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
    /// The details required to change the disk space limit for the SQL Management Base.
    /// It takes either credentials or databaseCredential. It's recommended to provide databaseCredential
    /// 
    /// </summary>
    public class ChangeSpaceBudgetDetails 
    {
        
        /// <value>
        /// The maximum percent of `SYSAUX` space that the SQL Management Base can use.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SpaceBudgetPercent is required.")]
        [JsonProperty(PropertyName = "spaceBudgetPercent")]
        public System.Double SpaceBudgetPercent { get; set; }
        
        [JsonProperty(PropertyName = "credentials")]
        public ManagedDatabaseCredential Credentials { get; set; }
        
        [JsonProperty(PropertyName = "databaseCredential")]
        public DatabaseCredentialDetails DatabaseCredential { get; set; }
        
    }
}
