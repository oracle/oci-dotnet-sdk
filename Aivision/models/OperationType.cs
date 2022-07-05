/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.AivisionService.Models
{
  /// <summary>
  /// Possible operation types.
  /// </summary>
  public enum OperationType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATE_PROJECT")]
      CreateProject,
      [EnumMember(Value = "UPDATE_PROJECT")]
      UpdateProject,
      [EnumMember(Value = "DELETE_PROJECT")]
      DeleteProject,
      [EnumMember(Value = "MOVE_PROJECT")]
      MoveProject,
      [EnumMember(Value = "CREATE_MODEL")]
      CreateModel,
      [EnumMember(Value = "UPDATE_MODEL")]
      UpdateModel,
      [EnumMember(Value = "DELETE_MODEL")]
      DeleteModel,
      [EnumMember(Value = "MOVE_MODEL")]
      MoveModel
  }
}
