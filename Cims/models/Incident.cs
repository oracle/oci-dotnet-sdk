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
    /// Details about the support ticket.
    /// </summary>
    public class Incident 
    {
        
        /// <value>
        /// Unique identifier for the support ticket.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The OCID of the tenancy.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        [JsonProperty(PropertyName = "contactList")]
        public ContactList ContactList { get; set; }
        
        [JsonProperty(PropertyName = "tenancyInformation")]
        public TenancyInformation TenancyInformation { get; set; }
        
        [JsonProperty(PropertyName = "ticket")]
        public Ticket Ticket { get; set; }
        
        [JsonProperty(PropertyName = "incidentType")]
        public IncidentType IncidentType { get; set; }
        
        /// <value>
        /// Technical support type (`TECH`) only: The identifier of the support request's user group in My Oracle Cloud Support portal.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "userGroupId")]
        public string UserGroupId { get; set; }
        
        /// <value>
        /// Technical support type (`TECH`) only: Name of the support request's user group in My Oracle Cloud Support portal.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "userGroupName")]
        public string UserGroupName { get; set; }
        
        /// <value>
        /// Technical support type (`TECH`) only: The identifier of the support request's primary contact (`primaryContactPartyName`) in My Oracle Cloud Support portal.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "primaryContactPartyId")]
        public string PrimaryContactPartyId { get; set; }
        
        /// <value>
        /// Technical support type (`TECH`) only: The name of the support request's primary contact in My Oracle Cloud Support portal.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "primaryContactPartyName")]
        public string PrimaryContactPartyName { get; set; }
        
        /// <value>
        /// Technical support type (`TECH`) only: Allows update of the support request in My Oracle Cloud Support portal, 
        /// when the user has write permission to the support request's user group.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isWritePermitted")]
        public System.Nullable<bool> IsWritePermitted { get; set; }
        
        /// <value>
        /// Technical support type (`TECH`) only: Message indicating the user group (`userGroupId`) that was auto-selected for a new support request. This message appears when no user group was specified in the create request for a new technical support request.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "warnMessage")]
        public string WarnMessage { get; set; }
        
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
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ProblemType> ProblemType { get; set; }
        
        /// <value>
        /// The incident referrer. This value is often the URL that the customer used when creating the support ticket.
        /// </value>
        [JsonProperty(PropertyName = "referrer")]
        public string Referrer { get; set; }
        
    }
}
