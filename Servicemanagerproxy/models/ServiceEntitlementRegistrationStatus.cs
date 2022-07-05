/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.ServicemanagerproxyService.Models
{
  /// <summary>
  /// Service Entitlement registration status
  /// </summary>
  public enum ServiceEntitlementRegistrationStatus {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "INITIALIZED")]
      Initialized,
      [EnumMember(Value = "BEGIN_ACTIVATION")]
      BeginActivation,
      [EnumMember(Value = "ACTIVE")]
      Active,
      [EnumMember(Value = "BEGIN_SOFT_TERMINATION")]
      BeginSoftTermination,
      [EnumMember(Value = "SOFT_TERMINATED")]
      SoftTerminated,
      [EnumMember(Value = "BEGIN_TERMINATION")]
      BeginTermination,
      [EnumMember(Value = "CANCELED")]
      Canceled,
      [EnumMember(Value = "TERMINATED")]
      Terminated,
      [EnumMember(Value = "BEGIN_DISABLING")]
      BeginDisabling,
      [EnumMember(Value = "BEGIN_ENABLING")]
      BeginEnabling,
      [EnumMember(Value = "BEGIN_MIGRATION")]
      BeginMigration,
      [EnumMember(Value = "DISABLED")]
      Disabled,
      [EnumMember(Value = "BEGIN_SUSPENSION")]
      BeginSuspension,
      [EnumMember(Value = "BEGIN_RESUMPTION")]
      BeginResumption,
      [EnumMember(Value = "SUSPENDED")]
      Suspended,
      [EnumMember(Value = "BEGIN_LOCK_RELOCATION")]
      BeginLockRelocation,
      [EnumMember(Value = "LOCKED_RELOCATION")]
      LockedRelocation,
      [EnumMember(Value = "BEGIN_RELOCATION")]
      BeginRelocation,
      [EnumMember(Value = "RELOCATED")]
      Relocated,
      [EnumMember(Value = "BEGIN_UNLOCK_RELOCATION")]
      BeginUnlockRelocation,
      [EnumMember(Value = "UNLOCKED_RELOCATION")]
      UnlockedRelocation,
      [EnumMember(Value = "FAILED_LOCK_RELOCATION")]
      FailedLockRelocation,
      [EnumMember(Value = "FAILED_ACTIVATION")]
      FailedActivation,
      [EnumMember(Value = "FAILED_MIGRATION")]
      FailedMigration,
      [EnumMember(Value = "ACCESS_DISABLED")]
      AccessDisabled,
      [EnumMember(Value = "BEGIN_DISABLING_ACCESS")]
      BeginDisablingAccess,
      [EnumMember(Value = "BEGIN_ENABLING_ACCESS")]
      BeginEnablingAccess,
      [EnumMember(Value = "TRA_UNKNOWN")]
      TraUnknown
  }
}
