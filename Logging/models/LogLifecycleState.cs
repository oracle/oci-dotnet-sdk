/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.LoggingService.Models
{
  /// <summary>
  /// The log object state. The states workflow is:
    ///    1. *CREATING* Object is being created, backend service contacted.
    ///    2. *ACTIVE* Logging is active.
    ///    3. *UPDATING* Object configuration change requested, but the backend service has not confirmed the update.
    ///    4. *INACTIVE* Logging is disabled.
    ///    5. *DELETING* Log object is being deleted.
    /// 
  /// </summary>
  public enum LogLifecycleState {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATING")]
      Creating,
      [EnumMember(Value = "ACTIVE")]
      Active,
      [EnumMember(Value = "UPDATING")]
      Updating,
      [EnumMember(Value = "INACTIVE")]
      Inactive,
      [EnumMember(Value = "DELETING")]
      Deleting,
      [EnumMember(Value = "FAILED")]
      Failed
  }
}
