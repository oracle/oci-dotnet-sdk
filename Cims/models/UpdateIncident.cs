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


namespace Oci.CimsService.Models
{
    /// <summary>
    /// Details about the support ticket being updated.
    /// </summary>
    public class UpdateIncident 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Ticket is required.")]
        [JsonProperty(PropertyName = "ticket")]
        public UpdateTicketDetails Ticket { get; set; }
        
        /// <value>
        /// The kind of support ticket (type of support request).
        /// For information about `ACCOUNT` support tickets, see 
        /// [Creating a Billing Support Request](https://docs.cloud.oracle.com/iaas/Content/GSG/support/create-incident-billing.htm).
        /// For information about `LIMIT` support tickets, see 
        /// [Creating a Service Limit Increase Request](https://docs.cloud.oracle.com/iaas/Content/GSG/support/create-incident-limit.htm).
        /// For information about `TECH` support tickets, see 
        /// [Creating a Technical Support Request](https://docs.cloud.oracle.com/iaas/Content/GSG/support/create-incident-technical.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "problemType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ProblemType> ProblemType { get; set; }
        
    }
}
