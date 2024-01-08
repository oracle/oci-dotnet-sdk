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


namespace Oci.NetworkfirewallService.Models
{
    /// <summary>
    /// URL pattern lists of the policy.
    /// The value of an entry is a list of URL patterns.
    /// The associated key/name is the identifier by which the URL pattern list is referenced.
    /// 
    /// </summary>
    public class UrlList 
    {
        
        /// <value>
        /// Unique name identifier for the URL list.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// List of urls.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Urls is required.")]
        [JsonProperty(PropertyName = "urls")]
        public System.Collections.Generic.List<UrlPattern> Urls { get; set; }
        
        /// <value>
        /// Total count of URLs in the URL List
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalUrls is required.")]
        [JsonProperty(PropertyName = "totalUrls")]
        public System.Nullable<int> TotalUrls { get; set; }
        
        /// <value>
        /// OCID of the Network Firewall Policy this URL List belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ParentResourceId is required.")]
        [JsonProperty(PropertyName = "parentResourceId")]
        public string ParentResourceId { get; set; }
        
    }
}
