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
    /// The details of the database running on-premises or on a compute instance.
    /// </summary>
    public class InstalledDatabaseDetails : DatabaseDetails
    {
        
        /// <value>
        /// The OCID of the compute instance on which the database is running.
        /// </value>
        [JsonProperty(PropertyName = "instanceId")]
        public string InstanceId { get; set; }
        
        /// <value>
        /// The list of database host IP Addresses. Fully qualified domain names can be used if connectionType is 'ONPREM_CONNECTOR'.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ipAddresses")]
        public System.Collections.Generic.List<string> IpAddresses { get; set; }
        
        /// <value>
        /// The port number of the database listener.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ListenerPort is required.")]
        [JsonProperty(PropertyName = "listenerPort")]
        public System.Nullable<int> ListenerPort { get; set; }
        
        /// <value>
        /// The service name of the database registered as target database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceName is required.")]
        [JsonProperty(PropertyName = "serviceName")]
        public string ServiceName { get; set; }
        
        [JsonProperty(PropertyName = "databaseType")]
        private readonly string databaseType = "INSTALLED_DATABASE";
    }
}
