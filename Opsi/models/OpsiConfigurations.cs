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
    /// An OPSI configuration resource is a container for storing custom values for customizable configuration items exposed by Operations Insights.
    /// <br/>
    /// Operations Insights exposes different sets of customizable configuration items through different OPSI configuration types.
    /// UX_CONFIGURATION: OPSI configuration resource of this type can be created only once in each compartment. It is a compartment level singleton resource.
    /// <br/>
    /// When configuration values, for an OPSI configuration type that supports compartment level singleton (e.g: UX_CONFIGURATION) resource, are queried for a compartment,
    /// following will be the order of preference.
    /// 1. If the specified compartment has an OPSI configuration resource, first preference will be given to the custom values inside that.
    /// 2. If the root compartment has an OPSI configuration resource, it will be considered as applicable to all compartments of that tenency,
    /// hence second preference will be given to the custom values inside that.
    /// 3. Default configuration will be considered as a final fallback option.
    /// 
    /// </summary>
    public class OpsiConfigurations 
    {
        
        /// <value>
        /// OPSI Configuration Object.
        /// </value>
        [JsonProperty(PropertyName = "opsiConfigurations")]
        public System.Object OpsiConfigurationsProp { get; set; }
        
    }
}
