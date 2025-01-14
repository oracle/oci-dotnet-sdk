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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// Defines the IDP Groups to GoldenGate roles mapping. This field is used only for IAM deployment and does not have any impact on non-IAM deployments.
    /// For IAM deployment, when user does not specify this mapping, then it has null value and default mapping is used.
    /// User belonging to each group can only perform the actions according to the role the respective group is mapped to.
    /// 
    /// </summary>
    public class UpdateGroupToRolesMappingDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the IDP group which will be mapped to goldengate role securityGroup.
        /// It grants administration of security related objects and invoke security related service requests. This role has full privileges.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "securityGroupId")]
        public string SecurityGroupId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the IDP group which will be mapped to goldengate role administratorGroup.
        /// It grants full access to the user, including the ability to alter general, non-security related operational parameters
        /// and profiles of the server.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "administratorGroupId")]
        public string AdministratorGroupId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the IDP group which will be mapped to goldengate role operatorGroup.
        /// It allows users to perform only operational actions, like starting and stopping resources.
        /// Operators cannot alter the operational parameters or profiles of the MA server.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "operatorGroupId")]
        public string OperatorGroupId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the IDP group which will be mapped to goldengate role userGroup.
        /// It allows information-only service requests, which do not alter or affect the operation of either the MA.
        /// Examples of query and read-only information include performance metric information and resource status and monitoring information
        /// 
        /// </value>
        [JsonProperty(PropertyName = "userGroupId")]
        public string UserGroupId { get; set; }
        
    }
}
