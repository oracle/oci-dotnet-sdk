/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.NetworkfirewallService.Models
{
  /// <summary>
  /// Types of Action on the Traffic flow.
    /// <br/>
    ///   * ALLOW - Allows the traffic.
    ///   * DROP - Silently drops the traffic, e.g. without sending a TCP reset.
    ///   * REJECT - Rejects the traffic, sending a TCP reset to client and/or server as applicable.
    ///   * INSPECT - Inspects traffic for vulnerability as specified in `inspection`, which may result in rejection.
    /// 
  /// </summary>
  public enum TrafficActionType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "ALLOW")]
      Allow,
      [EnumMember(Value = "DROP")]
      Drop,
      [EnumMember(Value = "REJECT")]
      Reject,
      [EnumMember(Value = "INSPECT")]
      Inspect
  }
}
