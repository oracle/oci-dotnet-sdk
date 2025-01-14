/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.NetworkloadbalancerService.Models
{
  /// <summary>
  /// This object is deprecated.
    /// Protocols supported for the listener of the network load balancer.
    /// 
  /// </summary>
  public enum NetworkLoadBalancersProtocolSummary {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "ANY")]
      Any,
      [EnumMember(Value = "TCP")]
      Tcp,
      [EnumMember(Value = "UDP")]
      Udp,
      [EnumMember(Value = "TCP_AND_UDP")]
      TcpAndUdp,
      [EnumMember(Value = "L3IP")]
      L3Ip
  }
}
