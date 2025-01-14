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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// A DatabaseTableAccess is a resource corresponding to a row in database table access report. It contains
    /// information about user's privilege grants that enable table access for the user.
    /// It's a subresource of Security Policy Report resource and is always associated with a SecurityPolicyReport.
    /// 
    /// </summary>
    public class DatabaseTableAccessEntry 
    {
        
        /// <value>
        /// The unique key that identifies the table access report. It is numeric and unique within a security policy report.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// Grantee is the user who can access the table
        /// </value>
        [JsonProperty(PropertyName = "grantee")]
        public string Grantee { get; set; }
        
        /// <value>
        /// The type of the access the user has on the table, there can be one or more from SELECT, UPDATE, INSERT, OWNER or DELETE.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "accessType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AccessType> AccessType { get; set; }
        
        /// <value>
        /// The name of the schema the table belongs to.
        /// </value>
        [JsonProperty(PropertyName = "tableSchema")]
        public string TableSchema { get; set; }
        
        /// <value>
        /// The name of the database table the user has access to.
        /// </value>
        [JsonProperty(PropertyName = "tableName")]
        public string TableName { get; set; }
        
        /// <value>
        /// Type of the privilege user has, this includes System Privilege, Schema Privilege, Object Privilege, Column Privilege,
        /// Owner or Schema Privilege on a schema.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privilegeType")]
        public string PrivilegeType { get; set; }
        
        /// <value>
        /// The OCID of the of the  target database.
        /// </value>
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// Name of the privilege.
        /// </value>
        [JsonProperty(PropertyName = "privilege")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PrivilegeName> Privilege { get; set; }
        
        /// <value>
        /// Indicates whether the grantee can grant this privilege to other users. Privileges can be granted to a user or role with 
        /// GRANT_OPTION or ADMIN_OPTION
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privilegeGrantable")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PrivilegeGrantableOption> PrivilegeGrantable { get; set; }
        
        /// <value>
        /// This can be empty in case of direct grant, in case of indirect grant, this attribute displays the name of the 
        /// role which is granted to the user though which the user has access to the table.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "grantFromRole")]
        public string GrantFromRole { get; set; }
        
        /// <value>
        /// A non-null value in this field indicates the object through which user has access to table, possible values could
        /// be table or view.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "accessThroughObject")]
        public string AccessThroughObject { get; set; }
        
        /// <value>
        /// If there are column level privileges on a table or view.
        /// </value>
        [JsonProperty(PropertyName = "columnName")]
        public string ColumnName { get; set; }
        
        /// <value>
        /// The one who granted this privilege.
        /// </value>
        [JsonProperty(PropertyName = "grantor")]
        public string Grantor { get; set; }
        
        /// <value>
        /// Indicates whether the user has access to all the tables in the schema.
        /// </value>
        [JsonProperty(PropertyName = "areAllTablesAccessible")]
        public System.Nullable<bool> AreAllTablesAccessible { get; set; }
        
        /// <value>
        /// Indicates whether the access is constrained on a table via a view.
        /// </value>
        [JsonProperty(PropertyName = "isAccessConstrainedByView")]
        public System.Nullable<bool> IsAccessConstrainedByView { get; set; }
        
        /// <value>
        /// Indicates whether the table access is constrained via Oracle Label Security.
        /// </value>
        [JsonProperty(PropertyName = "isAccessConstrainedByLabelSecurity")]
        public System.Nullable<bool> IsAccessConstrainedByLabelSecurity { get; set; }
        
        /// <value>
        /// Indicates whether the table access is constrained via Oracle Database Vault.
        /// </value>
        [JsonProperty(PropertyName = "isAccessConstrainedByDatabaseVault")]
        public System.Nullable<bool> IsAccessConstrainedByDatabaseVault { get; set; }
        
        /// <value>
        /// Indicates whether the table access is constrained via Virtual Private Database.
        /// </value>
        [JsonProperty(PropertyName = "isAccessConstrainedByVirtualPrivateDatabase")]
        public System.Nullable<bool> IsAccessConstrainedByVirtualPrivateDatabase { get; set; }
        
        /// <value>
        /// Indicates whether the table access is constrained via Oracle Data Redaction.
        /// </value>
        [JsonProperty(PropertyName = "isAccessConstrainedByRedaction")]
        public System.Nullable<bool> IsAccessConstrainedByRedaction { get; set; }
        
        /// <value>
        /// Indicates whether the table access is constrained via Real Application Security.
        /// </value>
        [JsonProperty(PropertyName = "isAccessConstrainedByRealApplicationSecurity")]
        public System.Nullable<bool> IsAccessConstrainedByRealApplicationSecurity { get; set; }
        
        /// <value>
        /// Indicates whether the table access is constrained via Oracle Database SQL Firewall.
        /// </value>
        [JsonProperty(PropertyName = "isAccessConstrainedBySqlFirewall")]
        public System.Nullable<bool> IsAccessConstrainedBySqlFirewall { get; set; }
        
        /// <value>
        /// Indicates whether the table is marked as sensitive.
        /// </value>
        [JsonProperty(PropertyName = "isSensitive")]
        public System.Nullable<bool> IsSensitive { get; set; }
        
    }
}
