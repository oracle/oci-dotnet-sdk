/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.LockboxService.Models
{
  /// <summary>
  /// Possible operation types.
  /// </summary>
  public enum OperationType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATE_LOCKBOX")]
      CreateLockbox,
      [EnumMember(Value = "UPDATE_LOCKBOX")]
      UpdateLockbox,
      [EnumMember(Value = "DELETE_LOCKBOX")]
      DeleteLockbox,
      [EnumMember(Value = "MOVE_LOCKBOX")]
      MoveLockbox,
      [EnumMember(Value = "CREATE_ACCESS_REQUEST")]
      CreateAccessRequest,
      [EnumMember(Value = "APPROVE_ACCESS_REQUEST")]
      ApproveAccessRequest,
      [EnumMember(Value = "REVOKE_ACCESS_REQUEST")]
      RevokeAccessRequest,
      [EnumMember(Value = "CREATE_APPROVAL_TEMPLATE")]
      CreateApprovalTemplate,
      [EnumMember(Value = "MOVE_APPROVAL_TEMPLATE")]
      MoveApprovalTemplate,
      [EnumMember(Value = "UPDATE_APPROVAL_TEMPLATE")]
      UpdateApprovalTemplate,
      [EnumMember(Value = "DELETE_APPROVAL_TEMPLATE")]
      DeleteApprovalTemplate,
      [EnumMember(Value = "CREATE_PARTNER")]
      CreatePartner,
      [EnumMember(Value = "REMIND_ACCESS_REQUEST")]
      RemindAccessRequest,
      [EnumMember(Value = "CREATE_ACCESSCONTEXTATTRIBUTE")]
      CreateAccesscontextattribute
  }
}
