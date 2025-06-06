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


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// Details for the notebook session configuration.
    /// </summary>
    public class NotebookSessionConfigurationDetails 
    {
        
        /// <value>
        /// The shape used to launch the notebook session compute instance.  The list of available shapes in a given compartment can be retrieved using the `ListNotebookSessionShapes` endpoint.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Shape is required.")]
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// A notebook session instance is provided with a block storage volume. This specifies the size of the volume in GBs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "blockStorageSizeInGBs")]
        public System.Nullable<int> BlockStorageSizeInGBs { get; set; }
        
        /// <value>
        /// A notebook session instance is provided with a VNIC for network access.  This specifies the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the subnet to create a VNIC in.  The subnet should be in a VCN with a NAT gateway for egress to the internet.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The OCID of a Data Science private endpoint.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateEndpointId")]
        public string PrivateEndpointId { get; set; }
        
        [JsonProperty(PropertyName = "notebookSessionShapeConfigDetails")]
        public NotebookSessionShapeConfigDetails NotebookSessionShapeConfigDetails { get; set; }
        
    }
}
