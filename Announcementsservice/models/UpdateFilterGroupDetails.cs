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


namespace Oci.AnnouncementsService.Models
{
    /// <summary>
    /// The details for updating a filter group in an announcement subscription.
    /// </summary>
    public class UpdateFilterGroupDetails 
    {
        
        /// <value>
        /// A list of filters against which the Announcements service will match announcements. You cannot combine the RESOURCE_ID filter with any other type of filter within a given filter group. For filter types that support multiple values, specify the values individually.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Filters is required.")]
        [JsonProperty(PropertyName = "filters")]
        public System.Collections.Generic.List<Filter> Filters { get; set; }
        
    }
}
