/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.CloudbridgeService.Models
{
  /// <summary>
  /// Possible operation types.
  /// </summary>
  public enum OperationType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATE_ENVIRONMENT")]
      CreateEnvironment,
      [EnumMember(Value = "UPDATE_ENVIRONMENT")]
      UpdateEnvironment,
      [EnumMember(Value = "DELETE_ENVIRONMENT")]
      DeleteEnvironment,
      [EnumMember(Value = "MOVE_ENVIRONMENT")]
      MoveEnvironment,
      [EnumMember(Value = "CREATE_OCB_AGENT")]
      CreateOcbAgent,
      [EnumMember(Value = "UPDATE_OCB_AGENT")]
      UpdateOcbAgent,
      [EnumMember(Value = "DELETE_OCB_AGENT")]
      DeleteOcbAgent,
      [EnumMember(Value = "MOVE_OCB_AGENT")]
      MoveOcbAgent,
      [EnumMember(Value = "CREATE_AGENT_DEPENDENCY")]
      CreateAgentDependency,
      [EnumMember(Value = "UPDATE_AGENT_DEPENDENCY")]
      UpdateAgentDependency,
      [EnumMember(Value = "DELETE_AGENT_DEPENDENCY")]
      DeleteAgentDependency,
      [EnumMember(Value = "MOVE_AGENT_DEPENDENCY")]
      MoveAgentDependency,
      [EnumMember(Value = "CREATE_INVENTORY")]
      CreateInventory,
      [EnumMember(Value = "DELETE_INVENTORY")]
      DeleteInventory,
      [EnumMember(Value = "IMPORT_INVENTORY")]
      ImportInventory,
      [EnumMember(Value = "DELETE_ASSET_SOURCE")]
      DeleteAssetSource,
      [EnumMember(Value = "REFRESH_ASSET_SOURCE")]
      RefreshAssetSource,
      [EnumMember(Value = "CREATE_ASSET_SOURCE")]
      CreateAssetSource,
      [EnumMember(Value = "UPDATE_ASSET_SOURCE")]
      UpdateAssetSource,
      [EnumMember(Value = "UPDATE_PLUGIN_STATE")]
      UpdatePluginState,
      [EnumMember(Value = "CLOUD_AWS_DISCOVERY")]
      CloudAwsDiscovery,
      [EnumMember(Value = "COLLECT_AWS_REALTIME_METRICS")]
      CollectAwsRealtimeMetrics,
      [EnumMember(Value = "COLLECT_AWS_HISTORICAL_METRICS")]
      CollectAwsHistoricalMetrics
  }
}
