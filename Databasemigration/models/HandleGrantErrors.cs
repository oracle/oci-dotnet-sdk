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
  /// The action taken in the event of errors related to GRANT or REVOKE errors.
    /// ABORT - (default) stops the load process and displays an error.
    /// DROP_ACCOUNT - deletes the account and continues the load process.
    /// IGNORE - ignores the error and continues the load process.
    /// 
  /// </summary>
  public enum HandleGrantErrors {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "ABORT")]
      Abort,
      [EnumMember(Value = "DROP_ACCOUNT")]
      DropAccount,
      [EnumMember(Value = "IGNORE")]
      Ignore
  }
}