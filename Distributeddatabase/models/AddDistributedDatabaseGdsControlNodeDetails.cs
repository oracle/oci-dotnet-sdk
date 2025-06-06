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


namespace Oci.DistributeddatabaseService.Models
{
    /// <summary>
    /// Details required to create a new Global database services control(GDS CTL) compute node.
    /// 
    /// </summary>
    public class AddDistributedDatabaseGdsControlNodeDetails 
    {
        
        /// <value>
        /// The public sshKey for Global database services control(GDS CTL) node.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PublicSshKey is required.")]
        [JsonProperty(PropertyName = "publicSshKey")]
        public string PublicSshKey { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subnet on which the Global database services control(GDS CTL) node should be created.
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
    }
}
