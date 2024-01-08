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


namespace Oci.DatabasetoolsService.Models
{
    /// <summary>
    /// The key store content.
    /// </summary>
    public class DatabaseToolsKeyStoreContentSecretIdGenericJdbc : DatabaseToolsKeyStoreContentGenericJdbc
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the secret containing the key store.
        /// </value>
        [JsonProperty(PropertyName = "secretId")]
        public string SecretId { get; set; }
        
        [JsonProperty(PropertyName = "valueType")]
        private readonly string valueType = "SECRETID";
    }
}
