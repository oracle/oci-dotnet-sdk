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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Summary of a Private endpoint managed Exadata insight resource (ExaCS).
    /// </summary>
    public class PeComanagedExadataInsightSummary : ExadataInsightSummary
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Exadata Infrastructure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExadataInfraId is required.")]
        [JsonProperty(PropertyName = "exadataInfraId")]
        public string ExadataInfraId { get; set; }
        
        /// <value>
        /// OCI exadata infrastructure resource type
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExadataInfraResourceType is required.")]
        [JsonProperty(PropertyName = "exadataInfraResourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ExadataResourceType> ExadataInfraResourceType { get; set; }
        
        /// <value>
        /// The shape of the Exadata Infrastructure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExadataShape is required.")]
        [JsonProperty(PropertyName = "exadataShape")]
        public string ExadataShape { get; set; }
        
        [JsonProperty(PropertyName = "entitySource")]
        private readonly string entitySource = "PE_COMANAGED_EXADATA";
    }
}
