/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabasetoolsService.Models
{
    /// <summary>
    /// The related resource
    /// </summary>
    public class UpdateDatabaseToolsRelatedResourcePostgresqlDetails 
    {
        
        /// <value>
        /// The resource entity type.
        /// </value>
        [JsonProperty(PropertyName = "entityType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RelatedResourceEntityTypePostgresql> EntityType { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the related resource.
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
    }
}
