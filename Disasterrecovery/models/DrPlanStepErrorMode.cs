/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DisasterrecoveryService.Models
{
  /// <summary>
  /// The types of error modes for steps in a DR plan.
    /// - STOP_ON_ERROR - Stop DR plan execution if the step fails.
    /// - CONTINUE_ON_ERROR - Continue executing the DR plan even if the step fails.
    /// 
  /// </summary>
  public enum DrPlanStepErrorMode {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "STOP_ON_ERROR")]
      StopOnError,
      [EnumMember(Value = "CONTINUE_ON_ERROR")]
      ContinueOnError
  }
}
