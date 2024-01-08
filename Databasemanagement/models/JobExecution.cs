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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details of a job execution.
    /// </summary>
    public class JobExecution 
    {
        
        /// <value>
        /// The identifier of the job execution.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The name of the job execution.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment in which the parent job resides.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database Group where the parent job has to be executed.
        /// </value>
        [JsonProperty(PropertyName = "managedDatabaseGroupId")]
        public string ManagedDatabaseGroupId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database associated with the job execution.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManagedDatabaseId is required.")]
        [JsonProperty(PropertyName = "managedDatabaseId")]
        public string ManagedDatabaseId { get; set; }
        
        /// <value>
        /// The name of the Managed Database associated with the job execution.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ManagedDatabaseName is required.")]
        [JsonProperty(PropertyName = "managedDatabaseName")]
        public string ManagedDatabaseName { get; set; }
        
        /// <value>
        /// The type of Oracle Database installation.
        /// </value>
        [JsonProperty(PropertyName = "databaseType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DatabaseType> DatabaseType { get; set; }
        
        /// <value>
        /// The subtype of the Oracle Database. Indicates whether the database is a Container Database, Pluggable Database, or a Non-container Database.
        /// </value>
        [JsonProperty(PropertyName = "databaseSubType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DatabaseSubType> DatabaseSubType { get; set; }
        
        /// <value>
        /// A list of the supported infrastructure that can be used to deploy the database.
        /// </value>
        [JsonProperty(PropertyName = "deploymentType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DeploymentType> DeploymentType { get; set; }
        
        /// <value>
        /// Indicates whether the Oracle Database is part of a cluster.
        /// </value>
        [JsonProperty(PropertyName = "isCluster")]
        public System.Nullable<bool> IsCluster { get; set; }
        
        /// <value>
        /// The workload type of the Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "workloadType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<WorkloadType> WorkloadType { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the parent job.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JobId is required.")]
        [JsonProperty(PropertyName = "jobId")]
        public string JobId { get; set; }
        
        /// <value>
        /// The name of the parent job.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JobName is required.")]
        [JsonProperty(PropertyName = "jobName")]
        public string JobName { get; set; }
        
        /// <value>
        /// The identifier of the associated job run.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JobRunId is required.")]
        [JsonProperty(PropertyName = "jobRunId")]
        public string JobRunId { get; set; }
                ///
        /// <value>
        /// The status of the job execution.
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress
        };

        /// <value>
        /// The status of the job execution.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The error message that is returned if the job execution fails. Null is returned if the job is
        /// still running or if the job execution is successful.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }
        
        [JsonProperty(PropertyName = "resultDetails")]
        public JobExecutionResultDetails ResultDetails { get; set; }
        
        /// <value>
        /// The date and time when the job execution was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time when the job execution completed.
        /// </value>
        [JsonProperty(PropertyName = "timeCompleted")]
        public System.Nullable<System.DateTime> TimeCompleted { get; set; }
        
        /// <value>
        /// The database user name used to execute the SQL job.
        /// </value>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }
        
        /// <value>
        /// The SQL text executed as part of the job.
        /// </value>
        [JsonProperty(PropertyName = "sqlText")]
        public string SqlText { get; set; }
        
        [JsonProperty(PropertyName = "inBinds")]
        public JobInBindsDetails InBinds { get; set; }
        
        [JsonProperty(PropertyName = "outBinds")]
        public JobOutBindsDetails OutBinds { get; set; }
        
        [JsonProperty(PropertyName = "scheduleDetails")]
        public JobScheduleDetails ScheduleDetails { get; set; }
        
    }
}
