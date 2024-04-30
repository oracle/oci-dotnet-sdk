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


namespace Oci.RecoveryService.Models
{
    /// <summary>
    /// Provides which configuration details to get.
    /// </summary>
    public class FetchProtectedDatabaseConfigurationDetails 
    {
                ///
        /// <value>
        /// Currently has four config options ALL, TNSNAMES, HOSTS and CABUNDLE. All will return a zipped folder containing the contents of both tnsnames and the certificateChainPem.
        /// </value>
        ///
        public enum ConfigurationTypeEnum {
            [EnumMember(Value = "CABUNDLE")]
            Cabundle,
            [EnumMember(Value = "TNSNAMES")]
            Tnsnames,
            [EnumMember(Value = "HOSTS")]
            Hosts,
            [EnumMember(Value = "RCVCONF")]
            Rcvconf,
            [EnumMember(Value = "ALL")]
            All
        };

        /// <value>
        /// Currently has four config options ALL, TNSNAMES, HOSTS and CABUNDLE. All will return a zipped folder containing the contents of both tnsnames and the certificateChainPem.
        /// </value>
        [JsonProperty(PropertyName = "configurationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ConfigurationTypeEnum> ConfigurationType { get; set; }
        
    }
}
