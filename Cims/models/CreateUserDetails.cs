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
    /// Details for creating a new user.
    /// </summary>
    public class CreateUserDetails 
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
        
        /// <value>
        /// First name of the user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FirstName is required.")]
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }
        
        /// <value>
        /// Last name of the user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LastName is required.")]
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }
        
        /// <value>
        /// CSI associated with the user.
        /// </value>
        [JsonProperty(PropertyName = "csi")]
        public string Csi { get; set; }
        
        /// <value>
        /// Contact number of the user.
        /// </value>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        
        /// <value>
        /// Timezone of the user.
        /// </value>
        [JsonProperty(PropertyName = "timezone")]
        public string Timezone { get; set; }
        
        /// <value>
        /// Organization of the user.
        /// </value>
        [JsonProperty(PropertyName = "organizationName")]
        public string OrganizationName { get; set; }
        
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
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProblemType is required.")]
        [JsonProperty(PropertyName = "problemType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ProblemType> ProblemType { get; set; }
        
    }
}
