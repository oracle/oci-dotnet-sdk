/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.RecoveryService.Models
{
  /// <summary>
  /// The type of work request.
  /// </summary>
  public enum OperationType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATE_PROTECTED_DATABASE")]
      CreateProtectedDatabase,
      [EnumMember(Value = "UPDATE_PROTECTED_DATABASE")]
      UpdateProtectedDatabase,
      [EnumMember(Value = "DELETE_PROTECTED_DATABASE")]
      DeleteProtectedDatabase,
      [EnumMember(Value = "MOVE_PROTECTED_DATABASE")]
      MoveProtectedDatabase,
      [EnumMember(Value = "CREATE_PROTECTION_POLICY")]
      CreateProtectionPolicy,
      [EnumMember(Value = "UPDATE_PROTECTION_POLICY")]
      UpdateProtectionPolicy,
      [EnumMember(Value = "DELETE_PROTECTION_POLICY")]
      DeleteProtectionPolicy,
      [EnumMember(Value = "MOVE_PROTECTION_POLICY")]
      MoveProtectionPolicy,
      [EnumMember(Value = "CREATE_RECOVERY_SERVICE_SUBNET")]
      CreateRecoveryServiceSubnet,
      [EnumMember(Value = "UPDATE_RECOVERY_SERVICE_SUBNET")]
      UpdateRecoveryServiceSubnet,
      [EnumMember(Value = "DELETE_RECOVERY_SERVICE_SUBNET")]
      DeleteRecoveryServiceSubnet,
      [EnumMember(Value = "MOVE_RECOVERY_SERVICE_SUBNET")]
      MoveRecoveryServiceSubnet
  }
}
