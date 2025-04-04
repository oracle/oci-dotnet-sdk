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
  /// The objective of the IORM plan of an Exadata storage server. The following is an excerpt from Exadata documentation:
    /// auto - Use this setting for IORM to determine the best mode based on active workloads and resource plans.
    ///        IORM continuously and dynamically determines the optimization objective, based on the observed workloads
    ///        and enabled resource plans. This is the recommended value for most use cases, and starting with
    ///        Oracle Exadata System Software release 21.2.0, this is the default setting.
    /// high_throughput - Use this setting to optimize critical DSS workloads that require high throughput.
    ///       This setting improves throughput at the cost of I/O latency.
    /// low_latency - Use this setting to optimize critical OLTP workloads that require extremely good disk latency.
    ///       This setting provides the lowest possible latency at the cost of throughput by limiting disk utilization.
    /// balanced - Use this setting for a mixture of critical OLTP and DSS workloads. This setting balances low disk
    ///       latency and high throughput. This setting limits disk utilization of large I/Os to a lesser extent than
    ///       low_latency to achieve a balance between latency and throughput.
    /// basic - Use this setting to limit the maximum small I/O latency and otherwise disable I/O prioritization.
    ///       This is the default setting in Oracle Exadata System Software release 20.1.0 and earlier.
    /// other - Temporarily handle the case when Exadata side adds new value, should not be used as input
    ///       when to make change to IORM plan.
    /// 
  /// </summary>
  public enum IormPlanObjectiveEnum {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "AUTO")]
      Auto,
      [EnumMember(Value = "HIGH_THROUGHPUT")]
      HighThroughput,
      [EnumMember(Value = "LOW_LATENCY")]
      LowLatency,
      [EnumMember(Value = "BALANCED")]
      Balanced,
      [EnumMember(Value = "BASIC")]
      Basic,
      [EnumMember(Value = "OTHER")]
      Other
  }
}
