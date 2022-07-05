/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.OpsiService.Models
{
  /// <summary>
  /// Possible operation types.
  /// </summary>
  public enum OperationType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "ENABLE_DATABASE_INSIGHT")]
      EnableDatabaseInsight,
      [EnumMember(Value = "DISABLE_DATABASE_INSIGHT")]
      DisableDatabaseInsight,
      [EnumMember(Value = "UPDATE_DATABASE_INSIGHT")]
      UpdateDatabaseInsight,
      [EnumMember(Value = "CREATE_DATABASE_INSIGHT")]
      CreateDatabaseInsight,
      [EnumMember(Value = "MOVE_DATABASE_INSIGHT")]
      MoveDatabaseInsight,
      [EnumMember(Value = "DELETE_DATABASE_INSIGHT")]
      DeleteDatabaseInsight,
      [EnumMember(Value = "CREATE_ENTERPRISE_MANAGER_BRIDGE")]
      CreateEnterpriseManagerBridge,
      [EnumMember(Value = "UDPATE_ENTERPRISE_MANAGER_BRIDGE")]
      UdpateEnterpriseManagerBridge,
      [EnumMember(Value = "MOVE_ENTERPRISE_MANAGER_BRIDGE")]
      MoveEnterpriseManagerBridge,
      [EnumMember(Value = "DELETE_ENTERPRISE_MANAGER_BRIDGE")]
      DeleteEnterpriseManagerBridge,
      [EnumMember(Value = "ENABLE_HOST_INSIGHT")]
      EnableHostInsight,
      [EnumMember(Value = "DISABLE_HOST_INSIGHT")]
      DisableHostInsight,
      [EnumMember(Value = "UPDATE_HOST_INSIGHT")]
      UpdateHostInsight,
      [EnumMember(Value = "CREATE_HOST_INSIGHT")]
      CreateHostInsight,
      [EnumMember(Value = "MOVE_HOST_INSIGHT")]
      MoveHostInsight,
      [EnumMember(Value = "DELETE_HOST_INSIGHT")]
      DeleteHostInsight,
      [EnumMember(Value = "CREATE_EXADATA_INSIGHT")]
      CreateExadataInsight,
      [EnumMember(Value = "ENABLE_EXADATA_INSIGHT")]
      EnableExadataInsight,
      [EnumMember(Value = "DISABLE_EXADATA_INSIGHT")]
      DisableExadataInsight,
      [EnumMember(Value = "UPDATE_EXADATA_INSIGHT")]
      UpdateExadataInsight,
      [EnumMember(Value = "MOVE_EXADATA_INSIGHT")]
      MoveExadataInsight,
      [EnumMember(Value = "DELETE_EXADATA_INSIGHT")]
      DeleteExadataInsight,
      [EnumMember(Value = "ADD_EXADATA_INSIGHT_MEMBERS")]
      AddExadataInsightMembers,
      [EnumMember(Value = "EXADATA_AUTO_SYNC")]
      ExadataAutoSync,
      [EnumMember(Value = "UPDATE_OPSI_WAREHOUSE")]
      UpdateOpsiWarehouse,
      [EnumMember(Value = "CREATE_OPSI_WAREHOUSE")]
      CreateOpsiWarehouse,
      [EnumMember(Value = "MOVE_OPSI_WAREHOUSE")]
      MoveOpsiWarehouse,
      [EnumMember(Value = "DELETE_OPSI_WAREHOUSE")]
      DeleteOpsiWarehouse,
      [EnumMember(Value = "ROTATE_OPSI_WAREHOUSE_WALLET")]
      RotateOpsiWarehouseWallet,
      [EnumMember(Value = "UPDATE_OPSI_WAREHOUSE_USER")]
      UpdateOpsiWarehouseUser,
      [EnumMember(Value = "CREATE_OPSI_WAREHOUSE_USER")]
      CreateOpsiWarehouseUser,
      [EnumMember(Value = "MOVE_OPSI_WAREHOUSE_USER")]
      MoveOpsiWarehouseUser,
      [EnumMember(Value = "DELETE_OPSI_WAREHOUSE_USER")]
      DeleteOpsiWarehouseUser,
      [EnumMember(Value = "UPDATE_AWRHUB")]
      UpdateAwrhub,
      [EnumMember(Value = "CREATE_AWRHUB")]
      CreateAwrhub,
      [EnumMember(Value = "MOVE_AWRHUB")]
      MoveAwrhub,
      [EnumMember(Value = "DELETE_AWRHUB")]
      DeleteAwrhub,
      [EnumMember(Value = "UPDATE_PRIVATE_ENDPOINT")]
      UpdatePrivateEndpoint,
      [EnumMember(Value = "CREATE_PRIVATE_ENDPOINT")]
      CreatePrivateEndpoint,
      [EnumMember(Value = "MOVE_PRIVATE_ENDPOINT")]
      MovePrivateEndpoint,
      [EnumMember(Value = "DELETE_PRIVATE_ENDPOINT")]
      DeletePrivateEndpoint
  }
}
