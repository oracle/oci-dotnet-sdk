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
    /// Basic configuration item summary. Value and defaultValue fields will contain the custom value stored in the resource and default value from Ops Insights respectively.
    /// 
    /// </summary>
    public class OpsiConfigurationBasicConfigurationItemSummary : OpsiConfigurationConfigurationItemSummary
    {
        
        /// <value>
        /// Name of configuration item.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Value of configuration item.
        /// </value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// Value of configuration item.
        /// </value>
        [JsonProperty(PropertyName = "defaultValue")]
        public string DefaultValue { get; set; }
        
        /// <value>
        /// List of contexts in Operations Insights where this configuration item is applicable.
        /// </value>
        [JsonProperty(PropertyName = "applicableContexts")]
        public System.Collections.Generic.List<string> ApplicableContexts { get; set; }
        
        [JsonProperty(PropertyName = "metadata")]
        public ConfigurationItemMetadata Metadata { get; set; }
        
        [JsonProperty(PropertyName = "configItemType")]
        private readonly string configItemType = "BASIC";
    }
}
