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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Provides summary information about an erratum associated with a managed instance.
    /// </summary>
    public class ManagedInstanceErratumSummary 
    {
        
        /// <value>
        /// The identifier of the erratum.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The advisory type of the erratum.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AdvisoryType is required.")]
        [JsonProperty(PropertyName = "advisoryType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ClassificationTypes> AdvisoryType { get; set; }
        
        /// <value>
        /// The date and time the package was issued by a providing erratum (in [RFC 3339](https://tools.ietf.org/rfc/rfc3339) format).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeIssued")]
        public System.Nullable<System.DateTime> TimeIssued { get; set; }
        
        /// <value>
        /// A summary description of the erratum.
        /// </value>
        [JsonProperty(PropertyName = "synopsis")]
        public string Synopsis { get; set; }
        
        /// <value>
        /// The list of CVEs applicable to this erratum.
        /// </value>
        [JsonProperty(PropertyName = "relatedCves")]
        public System.Collections.Generic.List<string> RelatedCves { get; set; }
        
        /// <value>
        /// The list of packages affected by this erratum.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Packages is required.")]
        [JsonProperty(PropertyName = "packages")]
        public System.Collections.Generic.List<PackageNameSummary> Packages { get; set; }
        
    }
}
