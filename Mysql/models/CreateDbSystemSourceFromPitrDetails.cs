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
    /// DB System OCID to perform a point in time recovery to the current point in time.
    /// <br/>
    /// DB System OCID and recovery point to perform a point in time recovery to the
    /// specified recovery point.
    /// 
    /// </summary>
    public class CreateDbSystemSourceFromPitrDetails : CreateDbSystemSourceDetails
    {
        
        /// <value>
        /// The OCID of the DB System from which a backup shall be selected to be
        /// restored when creating the new DB System. Use this together with
        /// recovery point to perform a point in time recovery operation.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbSystemId is required.")]
        [JsonProperty(PropertyName = "dbSystemId")]
        public string DbSystemId { get; set; }
        
        /// <value>
        /// The date and time, as per RFC 3339, of the change up to which the
        /// new DB System shall be restored to, using a backup and logs from the
        /// original DB System. In case no point in time is specified, then this
        /// new DB System shall be restored up to the latest change recorded for
        /// the original DB System.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "recoveryPoint")]
        public System.Nullable<System.DateTime> RecoveryPoint { get; set; }
        
        [JsonProperty(PropertyName = "sourceType")]
        private readonly string sourceType = "PITR";
    }
}
