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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// MySQL Migration resource
    /// </summary>
    public class MySqlMigration : Migration
    {
        
        [JsonProperty(PropertyName = "dataTransferMediumDetails")]
        public MySqlDataTransferMediumDetails DataTransferMediumDetails { get; set; }
        
        [JsonProperty(PropertyName = "initialLoadSettings")]
        public MySqlInitialLoadSettings InitialLoadSettings { get; set; }
        
        [JsonProperty(PropertyName = "advisorSettings")]
        public MySqlAdvisorSettings AdvisorSettings { get; set; }
        
        [JsonProperty(PropertyName = "hubDetails")]
        public GoldenGateHubDetails HubDetails { get; set; }
        
        [JsonProperty(PropertyName = "ggsDetails")]
        public MySqlGgsDeploymentDetails GgsDetails { get; set; }
        
        [JsonProperty(PropertyName = "databaseCombination")]
        private readonly string databaseCombination = "MYSQL";
    }
}
