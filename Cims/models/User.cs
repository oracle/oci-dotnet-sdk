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
    /// Details about the user.
    /// </summary>
    public class User 
    {
        
        /// <value>
        /// A unique identifier for the user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The user's first name.
        /// </value>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }
        
        /// <value>
        /// The user's last name.
        /// </value>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }
        
        /// <value>
        /// The country of the user.
        /// </value>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
        
        /// <value>
        /// The CSI associated with the user.
        /// </value>
        [JsonProperty(PropertyName = "csi")]
        public string Csi { get; set; }
        
        /// <value>
        /// The user's contact phone number.
        /// </value>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        
        /// <value>
        /// The timezone of the user.
        /// </value>
        [JsonProperty(PropertyName = "timezone")]
        public string Timezone { get; set; }
        
        /// <value>
        /// The company that the user belongs to.
        /// </value>
        [JsonProperty(PropertyName = "organizationName")]
        public string OrganizationName { get; set; }
        
        /// <value>
        /// The OCID of the tenancy.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The email of the contact person.
        /// </value>
        [JsonProperty(PropertyName = "contactEmail")]
        public string ContactEmail { get; set; }
        
        /// <value>
        /// The kind of support ticket, such as a technical support request or a limit increase request.
        /// </value>
        [JsonProperty(PropertyName = "problemType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ProblemType> ProblemType { get; set; }
        
    }
}
