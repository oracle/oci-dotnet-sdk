/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// A masking format defines the logic to mask data in a database column. The condition attribute 
    /// defines the condition that must be true for applying the masking format. It enables you to do 
    /// <a href=\"https://docs.oracle.com/en/cloud/paas/data-safe/udscs/conditional-masking.html\">conditional masking</a>
    /// so that you can mask the column data values differently using different masking formats and 
    /// the associated conditions. A masking format can have one or more format entries. A format entry 
    /// can be a basic masking format such as Random Number, or it can be a library masking format.The 
    /// combined output of all the format entries is used for masking. It provides the flexibility to 
    /// define a masking format that can generate different parts of a data value separately and then 
    /// combine them to get the final data value for masking.
    /// 
    /// </summary>
    public class MaskingFormat 
    {
        
        /// <value>
        /// A condition that must be true for applying the masking format. It can be any valid 
        /// SQL construct that can be used in a SQL predicate. It enables you to do 
        /// <a href=\"https://docs.oracle.com/en/cloud/paas/data-safe/udscs/conditional-masking.html\">conditional masking</a> 
        /// so that you can mask the column data values differently using different masking 
        /// formats and the associated conditions.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "condition")]
        public string Condition { get; set; }
        
        /// <value>
        /// The description of the masking format.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// An array of format entries. The combined output of all the format entries is 
        /// used for masking the column data values.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FormatEntries is required.")]
        [JsonProperty(PropertyName = "formatEntries")]
        public System.Collections.Generic.List<FormatEntry> FormatEntries { get; set; }
        
    }
}