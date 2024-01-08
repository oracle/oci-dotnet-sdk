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
  /// The types of groups in a DR plan.
    /// - USER_DEFINED - DR plan group whose contents are defined by the user.
    /// - BUILT_IN - DR plan group whose contents are pre-defined by the service.  These groups cannot be modified by the user.
    /// - BUILT_IN_PRECHECK - DR plan precheck group whose contents are pre-defined by the service. These groups cannot be modified by the user.
    /// 
  /// </summary>
  public enum DrPlanGroupType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "USER_DEFINED")]
      UserDefined,
      [EnumMember(Value = "BUILT_IN")]
      BuiltIn,
      [EnumMember(Value = "BUILT_IN_PRECHECK")]
      BuiltInPrecheck
  }
}
