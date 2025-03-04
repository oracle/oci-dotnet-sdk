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


namespace Oci.MysqlService.Models
{
    /// <summary>
    /// DB System restart parameters.
    /// </summary>
    public class RestartDbSystemDetails 
    {
        
        /// <value>
        /// The InnoDB shutdown mode to use, following the option
        /// \"[innodb_fast_shutdown](https://dev.mysql.com/doc/refman/en/innodb-parameters.html#sysvar_innodb_fast_shutdown)\".
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShutdownType is required.")]
        [JsonProperty(PropertyName = "shutdownType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<InnoDbShutdownMode> ShutdownType { get; set; }
        
    }
}
