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


namespace Oci.OperatoraccesscontrolService.Models
{
    /// <summary>
    /// The auditLog report details.
    /// </summary>
    public class AuditLogReport 
    {
        
        /// <value>
        /// Contains the report data.
        /// </value>
        [JsonProperty(PropertyName = "report")]
        public string Report { get; set; }
        
        /// <value>
        /// Contains the process tree data
        /// </value>
        [JsonProperty(PropertyName = "processTree")]
        public string ProcessTree { get; set; }
        
        /// <value>
        /// auditReportStatus for the accessRequestId
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AuditReportStatus is required.")]
        [JsonProperty(PropertyName = "auditReportStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<AuditReportStatus> AuditReportStatus { get; set; }
        
        /// <value>
        /// Time when the audit report was generated [RFC 3339](https://tools.ietf.org/html/rfc3339) timestamp format.Example: '2020-05-22T21:10:29.600Z'
        /// </value>
        [JsonProperty(PropertyName = "timeOfReportGeneration")]
        public System.Nullable<System.DateTime> TimeOfReportGeneration { get; set; }
        
    }
}
