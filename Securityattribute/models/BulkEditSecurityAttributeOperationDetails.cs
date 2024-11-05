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


namespace Oci.SecurityattributeService.Models
{
    
    public class BulkEditSecurityAttributeOperationDetails 
    {
                ///
        /// <value>
        /// An enum-like description of the type of operation.
        /// <br/>
        /// * `ADD_WHERE_ABSENT` adds a security attribute only if it does not already exist on the resource.
        /// * `SET_WHERE_PRESENT` updates the value for a security attribute only if it is present on the resource.
        /// * `ADD_OR_SET` combines the first two operations to add a security attribute if it does not already exist on the resource
        /// or update the value if it is present on the resource.
        /// * `REMOVE` removes the security attribute from the resource. It's removed from the resource regardless of the value.
        /// 
        /// </value>
        ///
        public enum OperationTypeEnum {
            [EnumMember(Value = "ADD_WHERE_ABSENT")]
            AddWhereAbsent,
            [EnumMember(Value = "SET_WHERE_PRESENT")]
            SetWherePresent,
            [EnumMember(Value = "ADD_OR_SET")]
            AddOrSet,
            [EnumMember(Value = "REMOVE")]
            Remove
        };

        /// <value>
        /// An enum-like description of the type of operation.
        /// <br/>
        /// * `ADD_WHERE_ABSENT` adds a security attribute only if it does not already exist on the resource.
        /// * `SET_WHERE_PRESENT` updates the value for a security attribute only if it is present on the resource.
        /// * `ADD_OR_SET` combines the first two operations to add a security attribute if it does not already exist on the resource
        /// or update the value if it is present on the resource.
        /// * `REMOVE` removes the security attribute from the resource. It's removed from the resource regardless of the value.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperationType is required.")]
        [JsonProperty(PropertyName = "operationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OperationTypeEnum> OperationType { get; set; }
        
        /// <value>
        /// Security attributes for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;oracle-zpr&quot;: {&quot;td&quot;: {&quot;value&quot;: &quot;42&quot;, &quot;mode&quot;: &quot;audit&quot;}}}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SecurityAttributes is required.")]
        [JsonProperty(PropertyName = "securityAttributes")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SecurityAttributes { get; set; }
        
    }
}