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


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// Property that is used for provisioning of the given MlApplicationInstance. It is validated against configurationSchema defined in referenced MlApplicationImplementation. The value is mandatory with exception for ConfigurationProperty of SECRET type where read operation does not return value field as it contains plain text secret and update operation does not have to contain value field when the secret value should not be updated.
    /// </summary>
    public class ConfigurationProperty 
    {
        
        /// <value>
        /// Key of configuration property
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// Value of configuration property
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
    }
}
