/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.OsmanagementService.Models
{
    /// <summary>
    /// Details about the erratum.
    /// </summary>
    public class Erratum 
    {
        
        /// <value>
        /// Advisory name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// OCID for the Erratum.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// OCID for the Compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Summary description of the erratum.
        /// </value>
        [JsonProperty(PropertyName = "synopsis")]
        public string Synopsis { get; set; }
        
        /// <value>
        /// date the erratum was issued
        /// </value>
        [JsonProperty(PropertyName = "issued")]
        public string Issued { get; set; }
        
        /// <value>
        /// Details describing the erratum.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// most recent date the erratum was updated
        /// </value>
        [JsonProperty(PropertyName = "updated")]
        public string Updated { get; set; }
        
        /// <value>
        /// Type of the erratum.
        /// </value>
        [JsonProperty(PropertyName = "advisoryType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<UpdateTypes> AdvisoryType { get; set; }
        
        /// <value>
        /// Information specifying from where the erratum was release.
        /// </value>
        [JsonProperty(PropertyName = "from")]
        public string From { get; set; }
        
        /// <value>
        /// Information describing how the erratum can be resolved.
        /// </value>
        [JsonProperty(PropertyName = "solution")]
        public string Solution { get; set; }
        
        /// <value>
        /// Information describing how to find more information about the erratum.
        /// </value>
        [JsonProperty(PropertyName = "references")]
        public string References { get; set; }
        
        /// <value>
        /// list of managed instances  to this erratum
        /// </value>
        [JsonProperty(PropertyName = "affectedInstances")]
        public System.Collections.Generic.List<Id> AffectedInstances { get; set; }
        
        /// <value>
        /// list of CVEs applicable to this erratum
        /// </value>
        [JsonProperty(PropertyName = "relatedCves")]
        public System.Collections.Generic.List<string> RelatedCves { get; set; }
        
        /// <value>
        /// list of Software Sources
        /// </value>
        [JsonProperty(PropertyName = "softwareSources")]
        public System.Collections.Generic.List<Id> SoftwareSources { get; set; }
        
        /// <value>
        /// list of Packages affected by this erratum
        /// </value>
        [JsonProperty(PropertyName = "packages")]
        public System.Collections.Generic.List<SoftwarePackageSummary> Packages { get; set; }
        
    }
}
