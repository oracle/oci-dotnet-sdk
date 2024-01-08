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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Typeahead results
    /// 
    /// </summary>
    public class SuggestOutput 
    {
        
        /// <value>
        /// Character position suggestion should be placed in queryString provided as input.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Position is required.")]
        [JsonProperty(PropertyName = "position")]
        public System.Nullable<int> Position { get; set; }
        
        /// <value>
        /// Context specific list of querylanguage commands if input is seeking command suggestions.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "commands")]
        public System.Collections.Generic.List<string> Commands { get; set; }
        
        /// <value>
        /// Context specific list of querylanguage fields / columns if input is seeking field / column suggestions.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "fields")]
        public System.Collections.Generic.List<string> Fields { get; set; }
        
        /// <value>
        /// Context specific list of field values if input is seeking field value suggestions.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "fieldValues")]
        public System.Collections.Generic.List<string> FieldValues { get; set; }
        
        /// <value>
        /// Context specific list of terms / phrases if input is seeking terms / phrase suggestions.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "terms")]
        public System.Collections.Generic.List<string> Terms { get; set; }
        
        /// <value>
        /// Context specific list of querylanguage command options if input is seeking command option suggestions.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "options")]
        public System.Collections.Generic.List<string> Options { get; set; }
        
        /// <value>
        /// Context specific list of querylanguage querystring examples if input is seeking queryString example suggestions.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "examples")]
        public System.Collections.Generic.List<string> Examples { get; set; }
        
    }
}
