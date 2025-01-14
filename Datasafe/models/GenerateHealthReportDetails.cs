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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Details to use when performing health check on a masking policy.
    /// </summary>
    public class GenerateHealthReportDetails 
    {
                ///
        /// <value>
        /// The type of health check. The default behaviour is to perform all health checks.
        /// 
        /// </value>
        ///
        public enum CheckTypeEnum {
            [EnumMember(Value = "ALL")]
            All
        };

        /// <value>
        /// The type of health check. The default behaviour is to perform all health checks.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "checkType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<CheckTypeEnum> CheckType { get; set; }
        
        /// <value>
        /// The OCID of the target database to use for the masking policy 
        /// health check. The targetId associated with the masking policy
        /// is used if this is not passed.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// The OCID of the compartment where the health report resource should be created.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The tablespace that should be used to estimate space.
        /// If no tablespace is provided, the DEFAULT tablespace is used. 
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tablespace")]
        public string Tablespace { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
