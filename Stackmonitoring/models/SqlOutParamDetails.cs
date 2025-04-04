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


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// Position and SQL Type of PL/SQL OUT parameter
    /// </summary>
    public class SqlOutParamDetails 
    {
        
        /// <value>
        /// Position of PL/SQL procedure OUT parameter. The value of this property is ignored during update, if \"outParamType\" is set to NO_OUT_PARAM value.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OutParamPosition is required.")]
        [JsonProperty(PropertyName = "outParamPosition")]
        public System.Nullable<int> OutParamPosition { get; set; }
        
        /// <value>
        /// SQL Type of PL/SQL procedure OUT parameter. During the update, to completely remove the out parameter, use the value NO_OUT_PARAM. In that case, the value of \"outParamPosition\" will be ignored.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OutParamType is required.")]
        [JsonProperty(PropertyName = "outParamType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SqlOutParamTypes> OutParamType { get; set; }
        
        /// <value>
        /// Name of the Out Parameter
        /// </value>
        [JsonProperty(PropertyName = "outParamName")]
        public string OutParamName { get; set; }
        
    }
}
