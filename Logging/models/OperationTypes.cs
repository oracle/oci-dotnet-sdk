/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.LoggingService.Models
{
  /// <summary>
  /// The types of work request operations.
  /// </summary>
  public enum OperationTypes {
      [EnumMember(Value = "CREATE_LOG")]
      CreateLog,
      [EnumMember(Value = "UPDATE_LOG")]
      UpdateLog,
      [EnumMember(Value = "DELETE_LOG")]
      DeleteLog,
      [EnumMember(Value = "MOVE_LOG")]
      MoveLog,
      [EnumMember(Value = "CREATE_LOG_GROUP")]
      CreateLogGroup,
      [EnumMember(Value = "UPDATE_LOG_GROUP")]
      UpdateLogGroup,
      [EnumMember(Value = "DELETE_LOG_GROUP")]
      DeleteLogGroup,
      [EnumMember(Value = "MOVE_LOG_GROUP")]
      MoveLogGroup,
      [EnumMember(Value = "CREATE_CONFIGURATION")]
      CreateConfiguration,
      [EnumMember(Value = "UPDATE_CONFIGURATION")]
      UpdateConfiguration,
      [EnumMember(Value = "DELETE_CONFIGURATION")]
      DeleteConfiguration,
      [EnumMember(Value = "MOVE_CONFIGURATION")]
      MoveConfiguration
  }
}
