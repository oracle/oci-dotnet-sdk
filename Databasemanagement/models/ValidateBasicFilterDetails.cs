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
    /// Validate the basic filter criteria provided by the user.
    /// It takes either credentialDetails or databaseCredential. It's recommended to provide databaseCredential
    /// 
    /// </summary>
    public class ValidateBasicFilterDetails 
    {
        
        [JsonProperty(PropertyName = "credentialDetails")]
        public SqlTuningSetAdminCredentialDetails CredentialDetails { get; set; }
        
        [JsonProperty(PropertyName = "databaseCredential")]
        public DatabaseCredentialDetails DatabaseCredential { get; set; }
        
        /// <value>
        /// The owner of the Sql tuning set.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Owner is required.")]
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }
        
        /// <value>
        /// The name of the Sql tuning set.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Specifies the Sql predicate to filter the Sql from the Sql tuning set defined on attributes of the SQLSET_ROW.
        /// User could use any combination of the following columns with appropriate values as Sql predicate
        /// Refer to the documentation https://docs.oracle.com/en/database/oracle/oracle-database/18/arpls/DBMS_SQLTUNE.html#GUID-1F4AFB03-7B29-46FC-B3F2-CB01EC36326C
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BasicFilter is required.")]
        [JsonProperty(PropertyName = "basicFilter")]
        public string BasicFilter { get; set; }
        
    }
}
