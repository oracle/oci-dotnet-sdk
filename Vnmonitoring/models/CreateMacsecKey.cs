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


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// Defines the secret [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm)s held in Vault that represent the MACsec key.
    /// </summary>
    public class CreateMacsecKey 
    {
        
        /// <value>
        /// Secret [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) containing the Connectivity association Key Name (CKN) of this MACsec key.
        /// <br/>
        /// NOTE: Only the latest secret version will be used.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectivityAssociationNameSecretId is required.")]
        [JsonProperty(PropertyName = "connectivityAssociationNameSecretId")]
        public string ConnectivityAssociationNameSecretId { get; set; }
        
        /// <value>
        /// Secret [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) containing the Connectivity Association Key (CAK) of this MACsec key.
        /// <br/>
        /// NOTE: Only the latest secret version will be used.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConnectivityAssociationKeySecretId is required.")]
        [JsonProperty(PropertyName = "connectivityAssociationKeySecretId")]
        public string ConnectivityAssociationKeySecretId { get; set; }
        
    }
}
