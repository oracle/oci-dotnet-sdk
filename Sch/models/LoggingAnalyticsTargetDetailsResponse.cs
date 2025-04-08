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


namespace Oci.SchService.Models
{
    /// <summary>
    /// The destination log group for data transferred from the source.
    /// For configuration instructions, see
    /// [Creating a Connector](https://docs.cloud.oracle.com/iaas/Content/connector-hub/create-service-connector.htm).
    /// 
    /// </summary>
    public class LoggingAnalyticsTargetDetailsResponse : TargetDetailsResponse
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Logging Analytics log group.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LogGroupId is required.")]
        [JsonProperty(PropertyName = "logGroupId")]
        public string LogGroupId { get; set; }
        
        /// <value>
        /// Identifier of the log source that you want to use for processing data received from the connector source.
        /// Applies to `StreamingSource` only.
        /// Equivalent to `name` at {@link LogAnalyticsSource}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "logSourceIdentifier")]
        public string LogSourceIdentifier { get; set; }
        
        [JsonProperty(PropertyName = "kind")]
        private readonly string kind = "loggingAnalytics";
    }
}
