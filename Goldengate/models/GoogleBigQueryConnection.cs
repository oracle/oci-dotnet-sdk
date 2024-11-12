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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// Represents the metadata of a Google BigQuery Connection.
    /// 
    /// </summary>
    public class GoogleBigQueryConnection : Connection
    {
                ///
        /// <value>
        /// The Google BigQuery technology type.
        /// </value>
        ///
        public enum TechnologyTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "GOOGLE_BIGQUERY")]
            GoogleBigquery
        };

        /// <value>
        /// The Google BigQuery technology type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TechnologyType is required.")]
        [JsonProperty(PropertyName = "technologyType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TechnologyTypeEnum> TechnologyType { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the content of the service account key file is stored,
        /// which containing the credentials required to use Google BigQuery.
        /// Note: When provided, 'serviceAccountKeyFile' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "serviceAccountKeyFileSecretId")]
        public string ServiceAccountKeyFileSecretId { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "GOOGLE_BIGQUERY";
    }
}
