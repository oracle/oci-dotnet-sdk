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


namespace Oci.FleetsoftwareupdateService.Models
{
    /// <summary>
    /// 'DB' type Exadata Fleet Update Collection summary.
    /// 
    /// </summary>
    public class DbFsuCollectionSummary : FsuCollectionSummary
    {
        
        /// <value>
        /// Database Major Version of targets to be included in the Exadata Fleet Update Collection.
        /// https://docs.oracle.com/en-us/iaas/api/#/en/database/20160918/DbVersionSummary/ListDbVersions
        /// Only Database targets that match the version specified in this value would be added to the Exadata Fleet Update Collection.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceMajorVersion is required.")]
        [JsonProperty(PropertyName = "sourceMajorVersion")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DbSourceMajorVersions> SourceMajorVersion { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "DB";
    }
}
