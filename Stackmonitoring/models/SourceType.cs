/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.StackmonitoringService.Models
{
  /// <summary>
  /// Source Type of the resource.
    /// 1. SM_MGMT_AGENT_MONITORED - Management agent monitored stack monitoring discovered resources.
    /// 2. SM_REPO_ONLY - Repository only stack monitoring discovered resources.
    /// 3. OCI_NATIVE - OCI Native resources imported from OCI Monitoring Service.
    /// 4. PROMETHEUS - Prometheus resources imported from OCI Monitoring Service.
    /// 5. TELEGRAF - Telegraf based resources.
    /// 6. COLLECTD - Collectd based resources.
    /// 
  /// </summary>
  public enum SourceType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "SM_MGMT_AGENT_MONITORED")]
      SmMgmtAgentMonitored,
      [EnumMember(Value = "SM_REPO_ONLY")]
      SmRepoOnly,
      [EnumMember(Value = "OCI_NATIVE")]
      OciNative,
      [EnumMember(Value = "PROMETHEUS")]
      Prometheus,
      [EnumMember(Value = "TELEGRAF")]
      Telegraf,
      [EnumMember(Value = "COLLECTD")]
      Collectd
  }
}
