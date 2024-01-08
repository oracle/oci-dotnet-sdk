/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DatabasemigrationService.Models
{
  /// <summary>
  /// Possible operation types.
    /// 
  /// </summary>
  public enum OperationTypes {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATE_AGENT")]
      CreateAgent,
      [EnumMember(Value = "DELETE_AGENT")]
      DeleteAgent,
      [EnumMember(Value = "CREATE_MIGRATION")]
      CreateMigration,
      [EnumMember(Value = "CLONE_MIGRATION")]
      CloneMigration,
      [EnumMember(Value = "DELETE_MIGRATION")]
      DeleteMigration,
      [EnumMember(Value = "UPDATE_MIGRATION")]
      UpdateMigration,
      [EnumMember(Value = "START_MIGRATION")]
      StartMigration,
      [EnumMember(Value = "VALIDATE_MIGRATION")]
      ValidateMigration,
      [EnumMember(Value = "CREATE_CONNECTION")]
      CreateConnection,
      [EnumMember(Value = "DELETE_CONNECTION")]
      DeleteConnection,
      [EnumMember(Value = "UPDATE_CONNECTION")]
      UpdateConnection
  }
}
