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
    /// The REST API configuration for execution.
    /// </summary>
    public class ExecuteRestCallConfig 
    {
                ///
        /// <value>
        /// The REST method to use.
        /// </value>
        ///
        public enum MethodTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "GET")]
            Get,
            [EnumMember(Value = "POST")]
            Post,
            [EnumMember(Value = "PATCH")]
            Patch,
            [EnumMember(Value = "DELETE")]
            Delete,
            [EnumMember(Value = "PUT")]
            Put
        };

        /// <value>
        /// The REST method to use.
        /// </value>
        [JsonProperty(PropertyName = "methodType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MethodTypeEnum> MethodType { get; set; }
        
        /// <value>
        /// The headers for the REST call.
        /// </value>
        [JsonProperty(PropertyName = "requestHeaders")]
        public System.Collections.Generic.Dictionary<string, string> RequestHeaders { get; set; }
        
        [JsonProperty(PropertyName = "configValues")]
        public ConfigValues ConfigValues { get; set; }
        
    }
}
