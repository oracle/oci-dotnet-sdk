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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// An Enterprise Manager entity that can be imported into Operations Insights.
    /// </summary>
    public class ImportableEnterpriseManagerEntity 
    {
        
        /// <value>
        /// Enterprise Manager Unique Identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EnterpriseManagerIdentifier is required.")]
        [JsonProperty(PropertyName = "enterpriseManagerIdentifier")]
        public string EnterpriseManagerIdentifier { get; set; }
        
        /// <value>
        /// Enterprise Manager Entity Name
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EnterpriseManagerEntityName is required.")]
        [JsonProperty(PropertyName = "enterpriseManagerEntityName")]
        public string EnterpriseManagerEntityName { get; set; }
        
        /// <value>
        /// Enterprise Manager Entity Type
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EnterpriseManagerEntityType is required.")]
        [JsonProperty(PropertyName = "enterpriseManagerEntityType")]
        public string EnterpriseManagerEntityType { get; set; }
        
        /// <value>
        /// Enterprise Manager Entity Unique Identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EnterpriseManagerEntityIdentifier is required.")]
        [JsonProperty(PropertyName = "enterpriseManagerEntityIdentifier")]
        public string EnterpriseManagerEntityIdentifier { get; set; }
        
        /// <value>
        /// Ops Insights internal representation of the resource type.
        /// </value>
        [JsonProperty(PropertyName = "opsiEntityType")]
        public string OpsiEntityType { get; set; }
        
    }
}
