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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Summary details for the Oracle Siebel data asset type.
    /// </summary>
    public class DataAssetSummaryFromOracleSiebel : DataAssetSummary
    {
        
        /// <value>
        /// The Oracle Siebel hostname.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Host is required.")]
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }
        
        /// <value>
        /// The Oracle Siebel port.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Port is required.")]
        [JsonProperty(PropertyName = "port")]
        public string Port { get; set; }
        
        /// <value>
        /// The Oracle Siebel service name.
        /// </value>
        [JsonProperty(PropertyName = "serviceName")]
        public string ServiceName { get; set; }
        
        /// <value>
        /// The Oracle Siebel driver class.
        /// </value>
        [JsonProperty(PropertyName = "driverClass")]
        public string DriverClass { get; set; }
        
        /// <value>
        /// The Oracle Siebel SID.
        /// </value>
        [JsonProperty(PropertyName = "sid")]
        public string Sid { get; set; }
        
        [JsonProperty(PropertyName = "walletSecret")]
        public SensitiveAttribute WalletSecret { get; set; }
        
        [JsonProperty(PropertyName = "walletPasswordSecret")]
        public SensitiveAttribute WalletPasswordSecret { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefaultConnection is required.")]
        [JsonProperty(PropertyName = "defaultConnection")]
        public ConnectionSummaryFromOracleSiebel DefaultConnection { get; set; }
        
        [JsonProperty(PropertyName = "modelType")]
        private readonly string modelType = "ORACLE_SIEBEL_DATA_ASSET";
    }
}
