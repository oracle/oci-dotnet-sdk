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


namespace Oci.IdentityService.Models
{
    /// <summary>
    /// A mapping between a single group defined by the identity provider (IdP) you're federating with
    /// and a single IAM Service {@link Group} in Oracle Cloud Infrastructure.
    /// For more information about group mappings and what they're for, see
    /// [Identity Providers and Federation](https://docs.cloud.oracle.com/Content/Identity/Concepts/federation.htm).
    /// <br/>
    /// A given IdP group can be mapped to zero, one, or multiple IAM Service groups, and vice versa.
    /// But each `IdPGroupMapping` object is between only a single IdP group and IAM Service group.
    /// Each `IdPGroupMapping` object has its own OCID.
    /// <br/>
    /// **Note:** Any users who are in more than 50 IdP groups cannot be authenticated to use the Oracle
    /// Cloud Infrastructure Console.
    /// 
    /// </summary>
    public class IdpGroupMapping 
    {
        
        /// <value>
        /// The OCID of the `IdpGroupMapping`.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the `IdentityProvider` this mapping belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IdpId is required.")]
        [JsonProperty(PropertyName = "idpId")]
        public string IdpId { get; set; }
        
        /// <value>
        /// The name of the IdP group that is mapped to the IAM Service group.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IdpGroupName is required.")]
        [JsonProperty(PropertyName = "idpGroupName")]
        public string IdpGroupName { get; set; }
        
        /// <value>
        /// The OCID of the IAM Service group that is mapped to the IdP group.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GroupId is required.")]
        [JsonProperty(PropertyName = "groupId")]
        public string GroupId { get; set; }
        
        /// <value>
        /// The OCID of the tenancy containing the `IdentityProvider`.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Date and time the mapping was created, in the format defined by RFC3339.
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
                ///
        /// <value>
        /// The mapping's current state.  After creating a mapping object, make sure its `lifecycleState` changes
        /// from CREATING to ACTIVE before using it.
        /// 
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "INACTIVE")]
            Inactive,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The mapping's current state.  After creating a mapping object, make sure its `lifecycleState` changes
        /// from CREATING to ACTIVE before using it.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The detailed status of INACTIVE lifecycleState.
        /// </value>
        [JsonProperty(PropertyName = "inactiveStatus")]
        public System.Nullable<long> InactiveStatus { get; set; }
        
    }
}
