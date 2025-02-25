/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.OsmanagementhubService.Models
{
  /// <summary>
  /// Possible metric names.
  /// </summary>
  public enum MetricName {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "TOTAL_INSTANCE_COUNT")]
      TotalInstanceCount,
      [EnumMember(Value = "INSTANCE_WITH_AVAILABLE_SECURITY_UPDATES_COUNT")]
      InstanceWithAvailableSecurityUpdatesCount,
      [EnumMember(Value = "INSTANCE_WITH_AVAILABLE_BUGFIX_UPDATES_COUNT")]
      InstanceWithAvailableBugfixUpdatesCount,
      [EnumMember(Value = "NORMAL_INSTANCE_COUNT")]
      NormalInstanceCount,
      [EnumMember(Value = "ERROR_INSTANCE_COUNT")]
      ErrorInstanceCount,
      [EnumMember(Value = "WARNING_INSTANCE_COUNT")]
      WarningInstanceCount,
      [EnumMember(Value = "UNREACHABLE_INSTANCE_COUNT")]
      UnreachableInstanceCount,
      [EnumMember(Value = "REGISTRATION_FAILED_INSTANCE_COUNT")]
      RegistrationFailedInstanceCount,
      [EnumMember(Value = "DELETING_INSTANCE_COUNT")]
      DeletingInstanceCount,
      [EnumMember(Value = "ONBOARDING_INSTANCE_COUNT")]
      OnboardingInstanceCount,
      [EnumMember(Value = "INSTANCE_SECURITY_UPDATES_COUNT")]
      InstanceSecurityUpdatesCount,
      [EnumMember(Value = "INSTANCE_BUGFIX_UPDATES_COUNT")]
      InstanceBugfixUpdatesCount,
      [EnumMember(Value = "INSTANCE_SECURITY_ADVISORY_COUNT")]
      InstanceSecurityAdvisoryCount,
      [EnumMember(Value = "INSTANCE_BUGFIX_ADVISORY_COUNT")]
      InstanceBugfixAdvisoryCount,
      [EnumMember(Value = "REBOOTING_INSTANCE_COUNT")]
      RebootingInstanceCount,
      [EnumMember(Value = "NEEDS_REBOOTING_INSTANCE_COUNT")]
      NeedsRebootingInstanceCount
  }
}
