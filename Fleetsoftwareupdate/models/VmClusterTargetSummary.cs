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


namespace Oci.FleetsoftwareupdateService.Models
{
    /// <summary>
    /// Details of a VmCluster target member of a Exadata Fleet Update Collection.
    /// Stored references of the resource documented in
    ///   https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/VmCluster/
    /// 
    /// </summary>
    public class VmClusterTargetSummary : TargetDetails
    {
        
        /// <value>
        /// OCID of the related Exadata Infrastructure or Cloud Exadata Infrastructure resource.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "infrastructureId")]
        public string InfrastructureId { get; set; }
        
        /// <value>
        /// OCID of the Grid Infrastructure software image.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "softwareImageId")]
        public string SoftwareImageId { get; set; }
        
        [JsonProperty(PropertyName = "entityType")]
        private readonly string entityType = "VMCLUSTER";
    }
}
