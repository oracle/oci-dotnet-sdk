/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DisasterrecoveryService.Models
{
  /// <summary>
  /// The secondary lifecycle states of a DR plan. Provides information in addition to the lifecycle state.
    /// - NEEDS_REFRESH - The DR plan needs a refresh.
    /// - NEEDS_VERIFICATION - The DR plan needs verification.
    /// - REFRESHING - The DR plan is being updated due to a plan refresh.
    /// - VERIFYING - The DR plan is being updated due to a plan verification.
    /// 
  /// </summary>
  public enum DrPlanLifecycleSubState {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "NEEDS_REFRESH")]
      NeedsRefresh,
      [EnumMember(Value = "NEEDS_VERIFICATION")]
      NeedsVerification,
      [EnumMember(Value = "REFRESHING")]
      Refreshing,
      [EnumMember(Value = "VERIFYING")]
      Verifying
  }
}