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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// The external publication validation summary contains the validation summary information and the definition of the external object.
    /// </summary>
    public class ExternalPublicationValidationSummary 
    {
        
        /// <value>
        /// Total number of validation messages.
        /// </value>
        [JsonProperty(PropertyName = "totalMessageCount")]
        public System.Nullable<int> TotalMessageCount { get; set; }
        
        /// <value>
        /// Total number of validation error messages.
        /// </value>
        [JsonProperty(PropertyName = "errorMessageCount")]
        public System.Nullable<int> ErrorMessageCount { get; set; }
        
        /// <value>
        /// Total number of validation warning messages.
        /// </value>
        [JsonProperty(PropertyName = "warnMessageCount")]
        public System.Nullable<int> WarnMessageCount { get; set; }
        
        /// <value>
        /// Total number of validation information messages.
        /// </value>
        [JsonProperty(PropertyName = "infoMessageCount")]
        public System.Nullable<int> InfoMessageCount { get; set; }
        
        /// <value>
        /// Detailed information of the data flow object validation.
        /// </value>
        [JsonProperty(PropertyName = "validationMessages")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<ValidationMessage>> ValidationMessages { get; set; }
        
        /// <value>
        /// Objects use a 36 character key as unique ID. It is system generated and cannot be modified.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
    }
}
