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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// Details required to create a DB System.
    /// 
    /// </summary>
    public class CreateDbSystemDetails 
    {
        
        /// <value>
        /// The user-friendly name for the DB System. It does not have to be unique.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// User-provided data about the DB System.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The OCID of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Specifies if the DB System is highly available.
        /// <br/>
        /// When creating a DB System with High Availability, three instances
        /// are created and placed according to your region- and
        /// subnet-type. The secondaries are placed automatically in the other
        /// two availability or fault domains.  You can choose the preferred
        /// location of your primary instance, only.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isHighlyAvailable")]
        public System.Nullable<bool> IsHighlyAvailable { get; set; }
        
        /// <value>
        /// The availability domain on which to deploy the Read/Write endpoint. This defines the preferred primary instance.
        /// <br/>
        /// In a failover scenario, the Read/Write endpoint is redirected to one of the other availability domains
        /// and the MySQL instance in that domain is promoted to the primary instance.
        /// This redirection does not affect the IP address of the DB System in any way.
        /// <br/>
        /// For a standalone DB System, this defines the availability domain in which the DB System is placed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The fault domain on which to deploy the Read/Write endpoint. This defines the preferred primary instance.
        /// <br/>
        /// In a failover scenario, the Read/Write endpoint is redirected to one of the other fault domains
        /// and the MySQL instance in that domain is promoted to the primary instance.
        /// This redirection does not affect the IP address of the DB System in any way.
        /// <br/>
        /// For a standalone DB System, this defines the fault domain in which the DB System is placed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "faultDomain")]
        public string FaultDomain { get; set; }
        
        /// <value>
        /// The OCID of the Configuration to be used for this DB System.
        /// </value>
        [JsonProperty(PropertyName = "configurationId")]
        public string ConfigurationId { get; set; }
        
        /// <value>
        /// The name of the shape. The shape determines the resources allocated
        /// - CPU cores and memory for VM shapes; CPU cores, memory and storage
        /// for non-VM (or bare metal) shapes. To get a list of shapes, use the
        /// {@link #listShapes(ListShapesRequest) listShapes} operation.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShapeName is required.")]
        [JsonProperty(PropertyName = "shapeName")]
        public string ShapeName { get; set; }
        
        /// <value>
        /// The specific MySQL version identifier.
        /// </value>
        [JsonProperty(PropertyName = "mysqlVersion")]
        public string MysqlVersion { get; set; }
        
        /// <value>
        /// The OCID of the subnet the DB System is associated with.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The username for the administrative user.
        /// </value>
        [JsonProperty(PropertyName = "adminUsername")]
        public string AdminUsername { get; set; }
        
        /// <value>
        /// The password for the administrative user. The password must be
        /// between 8 and 32 characters long, and must contain at least 1
        /// numeric character, 1 lowercase character, 1 uppercase character, and
        /// 1 special (nonalphanumeric) character.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "adminPassword")]
        public string AdminPassword { get; set; }
        
        /// <value>
        /// Initial size of the data volume in GBs that will be created and attached.
        /// Keep in mind that this only specifies the size of the database data volume,
        /// the log volume for the database will be scaled appropriately with its shape.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dataStorageSizeInGBs")]
        public System.Nullable<int> DataStorageSizeInGBs { get; set; }
        
        /// <value>
        /// The hostname for the primary endpoint of the DB System. Used for DNS.
        /// <br/>
        /// The value is the hostname portion of the primary private IP's fully qualified domain name (FQDN)
        /// (for example, \"dbsystem-1\" in FQDN \"dbsystem-1.subnet123.vcn1.oraclevcn.com\").
        /// <br/>
        /// Must be unique across all VNICs in the subnet and comply with RFC 952 and RFC 1123.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "hostnameLabel")]
        public string HostnameLabel { get; set; }
        
        /// <value>
        /// The IP address the DB System is configured to listen on.
        /// A private IP address of your choice to assign to the primary endpoint of the DB System.
        /// Must be an available IP address within the subnet's CIDR. If you don't specify a value,
        /// Oracle automatically assigns a private IP address from the subnet. This should be a
        /// \"dotted-quad\" style IPv4 address.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }
        
        /// <value>
        /// The port for primary endpoint of the DB System to listen on.
        /// </value>
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// The TCP network port on which X Plugin listens for connections. This is the X Plugin equivalent of port.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "portX")]
        public System.Nullable<int> PortX { get; set; }
        
        [JsonProperty(PropertyName = "backupPolicy")]
        public CreateBackupPolicyDetails BackupPolicy { get; set; }
        
        [JsonProperty(PropertyName = "source")]
        public CreateDbSystemSourceDetails Source { get; set; }
        
        [JsonProperty(PropertyName = "maintenance")]
        public CreateMaintenanceDetails Maintenance { get; set; }
        
        /// <value>
        /// Simple key-value pair applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        [JsonProperty(PropertyName = "deletionPolicy")]
        public CreateDeletionPolicyDetails DeletionPolicy { get; set; }
        
        /// <value>
        /// Whether to run the DB System with InnoDB Redo Logs and the Double Write Buffer enabled or disabled,
        /// and whether to enable or disable syncing of the Binary Logs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "crashRecovery")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CrashRecoveryStatus> CrashRecovery { get; set; }
        
        /// <value>
        /// Whether to enable monitoring via the Database Management service.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "databaseManagement")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DatabaseManagementStatus> DatabaseManagement { get; set; }
        
        [JsonProperty(PropertyName = "secureConnections")]
        public SecureConnectionDetails SecureConnections { get; set; }
        
    }
}
