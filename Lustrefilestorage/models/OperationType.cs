/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.LustrefilestorageService.Models
{
  /// <summary>
  /// The asynchronous operation tracked by the work request.
  /// </summary>
  public enum OperationType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATE_LUSTRE_FILE_SYSTEM")]
      CreateLustreFileSystem,
      [EnumMember(Value = "UPDATE_LUSTRE_FILE_SYSTEM")]
      UpdateLustreFileSystem,
      [EnumMember(Value = "DELETE_LUSTRE_FILE_SYSTEM")]
      DeleteLustreFileSystem,
      [EnumMember(Value = "MOVE_LUSTRE_FILE_SYSTEM")]
      MoveLustreFileSystem
  }
}
