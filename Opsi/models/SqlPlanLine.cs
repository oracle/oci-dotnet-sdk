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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// SQL Plan Line type object.
    /// </summary>
    public class SqlPlanLine 
    {
        
        /// <value>
        /// Version
        /// Example: 1
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public System.Nullable<float> Version { get; set; }
        
        /// <value>
        /// Unique SQL_ID for a SQL Statement.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SqlIdentifier is required.")]
        [JsonProperty(PropertyName = "sqlIdentifier")]
        public string SqlIdentifier { get; set; }
        
        /// <value>
        /// Plan hash value for the SQL Execution Plan
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlanHash is required.")]
        [JsonProperty(PropertyName = "planHash")]
        public System.Nullable<long> PlanHash { get; set; }
        
        /// <value>
        /// Force matching signature
        /// Example: &quot;18067345456756876713&quot;
        /// </value>
        [JsonProperty(PropertyName = "forceMatchingSignature")]
        public string ForceMatchingSignature { get; set; }
        
        /// <value>
        /// Generation time stamp
        /// Example: &quot;2020-05-05T02:10:00.000Z&quot;
        /// </value>
        [JsonProperty(PropertyName = "timeGenerated")]
        public System.Nullable<System.DateTime> TimeGenerated { get; set; }
        
        /// <value>
        /// Collection time stamp
        /// Example: &quot;2020-05-06T00:00:00.000Z&quot;
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCollected is required.")]
        [JsonProperty(PropertyName = "timeCollected")]
        public System.Nullable<System.DateTime> TimeCollected { get; set; }
        
        /// <value>
        /// Operation
        /// Example: &quot;SELECT STATEMENT&quot;
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Operation is required.")]
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }
        
        /// <value>
        /// Remark
        /// Example: &quot;&quot;
        /// </value>
        [JsonProperty(PropertyName = "remark")]
        public string Remark { get; set; }
        
        /// <value>
        /// Options
        /// Example: &quot;RANGE SCAN&quot;
        /// </value>
        [JsonProperty(PropertyName = "options")]
        public string Options { get; set; }
        
        /// <value>
        /// Object Node
        /// Example: &quot;Q4000&quot;
        /// </value>
        [JsonProperty(PropertyName = "objectNode")]
        public string ObjectNode { get; set; }
        
        /// <value>
        /// Object Owner
        /// Example: &quot;TENANT_A#SCHEMA&quot;
        /// </value>
        [JsonProperty(PropertyName = "objectOwner")]
        public string ObjectOwner { get; set; }
        
        /// <value>
        /// Object Name
        /// Example: &quot;PLAN_LINES_PK&quot;
        /// </value>
        [JsonProperty(PropertyName = "objectName")]
        public string ObjectName { get; set; }
        
        /// <value>
        /// Object Alias
        /// Example: &quot;PLAN_LINES@SEL$1&quot;
        /// </value>
        [JsonProperty(PropertyName = "objectAlias")]
        public string ObjectAlias { get; set; }
        
        /// <value>
        /// Object Instance
        /// Example: 37472
        /// </value>
        [JsonProperty(PropertyName = "objectInstance")]
        public System.Nullable<long> ObjectInstance { get; set; }
        
        /// <value>
        /// Object Type
        /// Example: &quot;INDEX (UNIQUE)&quot;
        /// </value>
        [JsonProperty(PropertyName = "objectType")]
        public string ObjectType { get; set; }
        
        /// <value>
        /// Optimizer
        /// Example: &quot;CLUSTER&quot;
        /// </value>
        [JsonProperty(PropertyName = "optimizer")]
        public string Optimizer { get; set; }
        
        /// <value>
        /// Search Columns
        /// Example: 3
        /// </value>
        [JsonProperty(PropertyName = "searchColumns")]
        public System.Nullable<long> SearchColumns { get; set; }
        
        /// <value>
        /// Identifier
        /// Example: 3
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Identifier is required.")]
        [JsonProperty(PropertyName = "identifier")]
        public System.Nullable<long> Identifier { get; set; }
        
        /// <value>
        /// Parent Identifier
        /// Example: 2
        /// </value>
        [JsonProperty(PropertyName = "parentIdentifier")]
        public System.Nullable<long> ParentIdentifier { get; set; }
        
        /// <value>
        /// Depth
        /// Example: 3
        /// </value>
        [JsonProperty(PropertyName = "depth")]
        public System.Nullable<long> Depth { get; set; }
        
        /// <value>
        /// Position
        /// Example: 1
        /// </value>
        [JsonProperty(PropertyName = "position")]
        public System.Nullable<long> Position { get; set; }
        
        /// <value>
        /// Cost
        /// Example: 1
        /// </value>
        [JsonProperty(PropertyName = "cost")]
        public System.Nullable<long> Cost { get; set; }
        
        /// <value>
        /// Cardinality
        /// Example: 1
        /// </value>
        [JsonProperty(PropertyName = "cardinality")]
        public System.Nullable<long> Cardinality { get; set; }
        
        /// <value>
        /// Bytes
        /// Example: 150
        /// </value>
        [JsonProperty(PropertyName = "bytes")]
        public System.Nullable<long> Bytes { get; set; }
        
        /// <value>
        /// Other
        /// Example: 
        /// </value>
        [JsonProperty(PropertyName = "other")]
        public string Other { get; set; }
        
        /// <value>
        /// Other Tag
        /// Example: &quot;PARALLEL_COMBINED_WITH_PARENT&quot;
        /// </value>
        [JsonProperty(PropertyName = "otherTag")]
        public string OtherTag { get; set; }
        
        /// <value>
        /// Partition start
        /// Example: 1
        /// </value>
        [JsonProperty(PropertyName = "partitionStart")]
        public string PartitionStart { get; set; }
        
        /// <value>
        /// Partition stop
        /// Example: 2
        /// </value>
        [JsonProperty(PropertyName = "partitionStop")]
        public string PartitionStop { get; set; }
        
        /// <value>
        /// Partition identifier
        /// Example: 8
        /// </value>
        [JsonProperty(PropertyName = "partitionIdentifier")]
        public System.Nullable<long> PartitionIdentifier { get; set; }
        
        /// <value>
        /// Distribution
        /// Example: &quot;QC (RANDOM)&quot;
        /// </value>
        [JsonProperty(PropertyName = "distribution")]
        public string Distribution { get; set; }
        
        /// <value>
        /// CPU cost
        /// Example: 7321
        /// </value>
        [JsonProperty(PropertyName = "cpuCost")]
        public System.Nullable<long> CpuCost { get; set; }
        
        /// <value>
        /// IO cost
        /// Example: 1
        /// </value>
        [JsonProperty(PropertyName = "ioCost")]
        public System.Nullable<long> IoCost { get; set; }
        
        /// <value>
        /// Time space
        /// Example: 15614000
        /// </value>
        [JsonProperty(PropertyName = "tempSpace")]
        public System.Nullable<long> TempSpace { get; set; }
        
        /// <value>
        /// Access predicates
        /// Example: &quot;\\&quot;RESOURCE_ID\\&quot;=:1 AND \\&quot;QUERY_ID\\&quot;=:2&quot;
        /// </value>
        [JsonProperty(PropertyName = "accessPredicates")]
        public string AccessPredicates { get; set; }
        
        /// <value>
        /// Filter predicates
        /// Example: &quot;(INTERNAL_FUNCTION(\\&quot;J\\&quot;.\\&quot;DATABASE_ROLE\\&quot;) OR (\\&quot;J\\&quot;.\\&quot;DATABASE_ROLE\\&quot; IS NULL AND SYS_CONTEXT('userenv','database_role')='PRIMARY'))&quot;
        /// </value>
        [JsonProperty(PropertyName = "filterPredicates")]
        public string FilterPredicates { get; set; }
        
        /// <value>
        /// Projection
        /// Example: &quot;COUNT(*)[22]&quot;
        /// </value>
        [JsonProperty(PropertyName = "projection")]
        public string Projection { get; set; }
        
        /// <value>
        /// Qblock Name
        /// Example: &quot;SEL$1&quot;
        /// </value>
        [JsonProperty(PropertyName = "qblockName")]
        public string QblockName { get; set; }
        
        /// <value>
        /// Total elapsed time
        /// Example: 1.2
        /// </value>
        [JsonProperty(PropertyName = "elapsedTimeInSec")]
        public System.Nullable<float> ElapsedTimeInSec { get; set; }
        
        /// <value>
        /// Other SQL
        /// Example: &quot;<other_xml><info type=\\&quot;db_version\\&quot;>18.0.0.0</info><info type=\\&quot;parse_schema\\&quot;><![CDATA[\\&quot;SYS\\&quot;]]></info><info type=\\&quot;plan_hash_full\\&quot;>483892784</info><info type=\\&quot;plan_hash\\&quot;>2709293936</info><info type=\\&quot;plan_hash_2\\&quot;>483892784</info><outline_data><hint><![CDATA[IGNORE_OPTIM_EMBEDDED_HINTS]]></hint><hint><![CDATA[OPTIMIZER_FEATURES_ENABLE('18.1.0')]]></hint><hint><![CDATA[DB_VERSION('18.1.0')]]></hint><hint><![CDATA[OPT_PARAM('_b_tree_bitmap_plans' 'false')]]></hint><hint><![CDATA[OPT_PARAM('_optim_peek_user_binds' 'false')]]></hint><hint><![CDATA[OPT_PARAM('result_cache_mode' 'FORCE')]]></hint><hint><![CDATA[OPT_PARAM('_fix_control' '20648883:0 27745220:1 30001331:1 30142527:1 30539126:1')]]></hint><hint><![CDATA[OUTLINE_LEAF(@\\&quot;SEL$1\\&quot;)]]></hint><hint><![CDATA[INDEX(@\\&quot;SEL$1\\&quot; \\&quot;USER$\\&quot;@\\&quot;SEL$1\\&quot; \\&quot;I_USER#\\&quot;)]]></hint></outline_data></other_xml>&quot;
        /// </value>
        [JsonProperty(PropertyName = "otherXML")]
        public string OtherXML { get; set; }
        
    }
}
