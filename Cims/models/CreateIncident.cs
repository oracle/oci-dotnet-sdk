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


namespace Oci.CimsService.Models
{
    /// <summary>
    /// Details gathered during the creation of the support ticket.
    /// 
    /// </summary>
    public class CreateIncident 
    {
        
        /// <value>
        /// The OCID of the tenancy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Ticket is required.")]
        [JsonProperty(PropertyName = "ticket")]
        public CreateTicketDetails Ticket { get; set; }
        
        /// <value>
        /// The Customer Support Identifier (CSI) number associated with the support account.
        /// The CSI is required for technical support tickets and optional for limits and billing tickets.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "csi")]
        public string Csi { get; set; }
        
        /// <value>
        /// The kind of support ticket, such as a technical support request or a limit increase request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProblemType is required.")]
        [JsonProperty(PropertyName = "problemType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ProblemType> ProblemType { get; set; }
        
        /// <value>
        /// The list of contacts.
        /// </value>
        [JsonProperty(PropertyName = "contacts")]
        public System.Collections.Generic.List<Contact> Contacts { get; set; }
        
        /// <value>
        /// The incident referrer. This value is often the URL that the customer used when creating the support ticket.
        /// </value>
        [JsonProperty(PropertyName = "referrer")]
        public string Referrer { get; set; }
        
    }
}
