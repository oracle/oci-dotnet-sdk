/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DatabasemanagementService.Models
{
  /// <summary>
  /// The origin of the SQL plan baseline.
  /// </summary>
  public enum SqlPlanBaselineOrigin {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "ADDM_SQLTUNE")]
      AddmSqltune,
      [EnumMember(Value = "AUTO_CAPTURE")]
      AutoCapture,
      [EnumMember(Value = "AUTO_SQLTUNE")]
      AutoSqltune,
      [EnumMember(Value = "EVOLVE_AUTO_INDEX_LOAD")]
      EvolveAutoIndexLoad,
      [EnumMember(Value = "EVOLVE_CREATE_FROM_ADAPTIVE")]
      EvolveCreateFromAdaptive,
      [EnumMember(Value = "EVOLVE_LOAD_FROM_STS")]
      EvolveLoadFromSts,
      [EnumMember(Value = "EVOLVE_LOAD_FROM_AWR")]
      EvolveLoadFromAwr,
      [EnumMember(Value = "EVOLVE_LOAD_FROM_CURSOR_CACHE")]
      EvolveLoadFromCursorCache,
      [EnumMember(Value = "MANUAL_LOAD")]
      ManualLoad,
      [EnumMember(Value = "MANUAL_LOAD_FROM_AWR")]
      ManualLoadFromAwr,
      [EnumMember(Value = "MANUAL_LOAD_FROM_CURSOR_CACHE")]
      ManualLoadFromCursorCache,
      [EnumMember(Value = "MANUAL_LOAD_FROM_STS")]
      ManualLoadFromSts,
      [EnumMember(Value = "MANUAL_SQLTUNE")]
      ManualSqltune,
      [EnumMember(Value = "STORED_OUTLINE")]
      StoredOutline,
      [EnumMember(Value = "UNKNOWN")]
      Unknown
  }
}
