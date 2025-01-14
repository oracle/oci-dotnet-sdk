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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// Request to create execution action resource.
    /// 
    /// </summary>
    public class CreateExecutionActionDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the execution window resource the execution action belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExecutionWindowId is required.")]
        [JsonProperty(PropertyName = "executionWindowId")]
        public string ExecutionWindowId { get; set; }
                ///
        /// <value>
        /// The action type of the execution action being performed
        /// </value>
        ///
        public enum ActionTypeEnum {
            [EnumMember(Value = "DB_SERVER_FULL_SOFTWARE_UPDATE")]
            DbServerFullSoftwareUpdate,
            [EnumMember(Value = "STORAGE_SERVER_FULL_SOFTWARE_UPDATE")]
            StorageServerFullSoftwareUpdate,
            [EnumMember(Value = "NETWORK_SWITCH_FULL_SOFTWARE_UPDATE")]
            NetworkSwitchFullSoftwareUpdate
        };

        /// <value>
        /// The action type of the execution action being performed
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActionType is required.")]
        [JsonProperty(PropertyName = "actionType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ActionTypeEnum> ActionType { get; set; }
        
        /// <value>
        /// Map<ParamName, ParamValue> where a key value pair describes the specific action parameter.
        /// Example: {&quot;count&quot;: &quot;3&quot;}
        /// </value>
        [JsonProperty(PropertyName = "actionParams")]
        public System.Collections.Generic.Dictionary<string, string> ActionParams { get; set; }
        
        /// <value>
        /// List of action members of this execution action.
        /// </value>
        [JsonProperty(PropertyName = "actionMembers")]
        public System.Collections.Generic.List<ExecutionActionMember> ActionMembers { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
