/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.OsmanagementService.Models
{
  /// <summary>
  /// Event type:
    ///   * `KERNEL_OOPS` - Used to identify a kernel panic condition event
    ///   * `KERNEL_CRASH` - Used to identify an internal fatal kernel error that cannot be safely recovered from
    ///   * `CRASH` - Used to identify when an application stopped functioning properly and exited
    ///   * `EXPLOIT_ATTEMPT` - Used to identify a known exploit detection as identified by Ksplice
    ///   * `COMPLIANCE` - Used to identify a compliance related events
    ///   * `TUNING_SUGGESTION` - Used to identify autonomous tuning suggestion events
    ///   * `TUNING_APPLIED` - Used to identify when a tuning suggestion has been applied
    ///   * `SECURITY` - Used to identify security related events
    ///   * `ERROR` - Used to identify error related events
    ///   * `WARNING` - Used to identify warning related events
    /// 
  /// </summary>
  public enum EventType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "KERNEL_OOPS")]
      KernelOops,
      [EnumMember(Value = "KERNEL_CRASH")]
      KernelCrash,
      [EnumMember(Value = "CRASH")]
      Crash,
      [EnumMember(Value = "EXPLOIT_ATTEMPT")]
      ExploitAttempt,
      [EnumMember(Value = "COMPLIANCE")]
      Compliance,
      [EnumMember(Value = "TUNING_SUGGESTION")]
      TuningSuggestion,
      [EnumMember(Value = "TUNING_APPLIED")]
      TuningApplied,
      [EnumMember(Value = "SECURITY")]
      Security,
      [EnumMember(Value = "ERROR")]
      Error,
      [EnumMember(Value = "WARNING")]
      Warning
  }
}
