/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
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
    /// The request to start a SQL tuning task.
    /// </summary>
    public class StartSqlTuningTaskDetails 
    {
        
        /// <value>
        /// The name of the SQL tuning task. The name is unique per user in a database, and it is case-sensitive.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TaskName is required.")]
        [JsonProperty(PropertyName = "taskName")]
        public string TaskName { get; set; }
        
        /// <value>
        /// The description of the SQL tuning task.
        /// </value>
        [JsonProperty(PropertyName = "taskDescription")]
        public string TaskDescription { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CredentialDetails is required.")]
        [JsonProperty(PropertyName = "credentialDetails")]
        public SqlTuningTaskCredentialDetails CredentialDetails { get; set; }
        
        /// <value>
        /// The time limit for running the SQL tuning task.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalTimeLimitInMinutes is required.")]
        [JsonProperty(PropertyName = "totalTimeLimitInMinutes")]
        public System.Nullable<int> TotalTimeLimitInMinutes { get; set; }
                ///
        /// <value>
        /// The scope for the SQL tuning task. For LIMITED scope, the SQL profile recommendation
        /// is excluded, so the task is executed faster. For COMPREHENSIVE scope, the SQL profile recommendation
        /// is included.
        /// 
        /// </value>
        ///
        public enum ScopeEnum {
            [EnumMember(Value = "LIMITED")]
            Limited,
            [EnumMember(Value = "COMPREHENSIVE")]
            Comprehensive
        };

        /// <value>
        /// The scope for the SQL tuning task. For LIMITED scope, the SQL profile recommendation
        /// is excluded, so the task is executed faster. For COMPREHENSIVE scope, the SQL profile recommendation
        /// is included.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Scope is required.")]
        [JsonProperty(PropertyName = "scope")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ScopeEnum> Scope { get; set; }
        
        /// <value>
        /// The time limit per SQL statement (in minutes). This is for a task with the COMPREHENSIVE scope.
        /// The time limit per SQL statement should not be more than the total time limit.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "statementTimeLimitInMinutes")]
        public System.Nullable<int> StatementTimeLimitInMinutes { get; set; }
        
        /// <value>
        /// The array of the details of SQL statement on which tuning is performed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlDetails is required.")]
        [JsonProperty(PropertyName = "sqlDetails")]
        public System.Collections.Generic.List<SqlTuningTaskSqlDetail> SqlDetails { get; set; }
        
        /// <value>
        /// The start time of the period in which SQL statements are running.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeStarted is required.")]
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The end time of the period in which SQL statements are running.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeEnded is required.")]
        [JsonProperty(PropertyName = "timeEnded")]
        public System.Nullable<System.DateTime> TimeEnded { get; set; }
        
    }
}