/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.BdsService.Models
{
  /// <summary>
  /// Possible operation types.
  /// </summary>
  public enum OperationTypes {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATE_BDS")]
      CreateBds,
      [EnumMember(Value = "UPDATE_BDS")]
      UpdateBds,
      [EnumMember(Value = "DELETE_BDS")]
      DeleteBds,
      [EnumMember(Value = "ADD_BLOCK_STORAGE")]
      AddBlockStorage,
      [EnumMember(Value = "ADD_MASTER_NODES")]
      AddMasterNodes,
      [EnumMember(Value = "ADD_UTILITY_NODES")]
      AddUtilityNodes,
      [EnumMember(Value = "ADD_WORKER_NODES")]
      AddWorkerNodes,
      [EnumMember(Value = "ADD_CLOUD_SQL")]
      AddCloudSql,
      [EnumMember(Value = "REMOVE_CLOUD_SQL")]
      RemoveCloudSql,
      [EnumMember(Value = "CHANGE_COMPARTMENT_FOR_BDS")]
      ChangeCompartmentForBds,
      [EnumMember(Value = "CHANGE_SHAPE")]
      ChangeShape,
      [EnumMember(Value = "UPDATE_INFRA")]
      UpdateInfra,
      [EnumMember(Value = "RESTART_NODE")]
      RestartNode,
      [EnumMember(Value = "REMOVE_NODE")]
      RemoveNode,
      [EnumMember(Value = "CREATE_AUTOSCALE_CONFIG")]
      CreateAutoscaleConfig,
      [EnumMember(Value = "UPDATE_AUTOSCALE_CONFIG")]
      UpdateAutoscaleConfig,
      [EnumMember(Value = "DELETE_AUTOSCALE_CONFIG")]
      DeleteAutoscaleConfig,
      [EnumMember(Value = "AUTOSCALE_CONFIG")]
      AutoscaleConfig,
      [EnumMember(Value = "AUTOSCALE_RUN")]
      AutoscaleRun,
      [EnumMember(Value = "CREATE_API_KEY")]
      CreateApiKey,
      [EnumMember(Value = "DELETE_API_KEY")]
      DeleteApiKey,
      [EnumMember(Value = "TEST_OBJECT_STORE_CONNECTION")]
      TestObjectStoreConnection,
      [EnumMember(Value = "CREATE_METASTORE_CONFIG")]
      CreateMetastoreConfig,
      [EnumMember(Value = "DELETE_METASTORE_CONFIG")]
      DeleteMetastoreConfig,
      [EnumMember(Value = "UPDATE_METASTORE_CONFIG")]
      UpdateMetastoreConfig,
      [EnumMember(Value = "ACTIVATE_METASTORE_CONFIG")]
      ActivateMetastoreConfig,
      [EnumMember(Value = "TEST_METASTORE_CONFIG")]
      TestMetastoreConfig,
      [EnumMember(Value = "PATCH_BDS")]
      PatchBds,
      [EnumMember(Value = "PATCH_ODH")]
      PatchOdh,
      [EnumMember(Value = "PATCH_OS")]
      PatchOs,
      [EnumMember(Value = "STOP_BDS")]
      StopBds,
      [EnumMember(Value = "START_BDS")]
      StartBds,
      [EnumMember(Value = "ADD_KAFKA")]
      AddKafka,
      [EnumMember(Value = "REMOVE_KAFKA")]
      RemoveKafka,
      [EnumMember(Value = "EXECUTE_BOOTSTRAP_SCRIPT")]
      ExecuteBootstrapScript,
      [EnumMember(Value = "ODH_SERVICE_CERTIFICATE_UPDATE")]
      OdhServiceCertificateUpdate,
      [EnumMember(Value = "CREATE_BACKUP_CONFIG")]
      CreateBackupConfig,
      [EnumMember(Value = "UPDATE_BACKUP_CONFIG")]
      UpdateBackupConfig,
      [EnumMember(Value = "DELETE_BACKUP_CONFIG")]
      DeleteBackupConfig,
      [EnumMember(Value = "CREATE_NODE_REPLACE_CONFIG")]
      CreateNodeReplaceConfig,
      [EnumMember(Value = "UPDATE_NODE_REPLACE_CONFIG")]
      UpdateNodeReplaceConfig,
      [EnumMember(Value = "DELETE_NODE_REPLACE_CONFIG")]
      DeleteNodeReplaceConfig,
      [EnumMember(Value = "BACKUP_NODES")]
      BackupNodes,
      [EnumMember(Value = "DELETE_NODE_BACKUP")]
      DeleteNodeBackup,
      [EnumMember(Value = "REPLACE_NODE")]
      ReplaceNode,
      [EnumMember(Value = "CREATE_RESOURCE_PRINCIPAL_CONFIGURATION")]
      CreateResourcePrincipalConfiguration,
      [EnumMember(Value = "DELETE_RESOURCE_PRINCIPAL_CONFIGURATION")]
      DeleteResourcePrincipalConfiguration,
      [EnumMember(Value = "UPDATE_RESOURCE_PRINCIPAL_CONFIGURATION")]
      UpdateResourcePrincipalConfiguration,
      [EnumMember(Value = "REFRESH_RESOURCE_PRINCIPAL")]
      RefreshResourcePrincipal,
      [EnumMember(Value = "CREATE_IDENTITY_CONFIG")]
      CreateIdentityConfig,
      [EnumMember(Value = "DELETE_IDENTITY_CONFIG")]
      DeleteIdentityConfig,
      [EnumMember(Value = "UPDATE_IDENTITY_CONFIG")]
      UpdateIdentityConfig,
      [EnumMember(Value = "ACTIVATE_UPST_CONFIG")]
      ActivateUpstConfig,
      [EnumMember(Value = "DEACTIVATE_UPST_CONFIG")]
      DeactivateUpstConfig,
      [EnumMember(Value = "REFRESH_CONFIDENTIAL_APPLICATION")]
      RefreshConfidentialApplication,
      [EnumMember(Value = "REFRESH_TOKEN_EXCHANGE_KEYTAB")]
      RefreshTokenExchangeKeytab,
      [EnumMember(Value = "ACTIVATE_IAM_USER_SYNC_CONFIG")]
      ActivateIamUserSyncConfig,
      [EnumMember(Value = "DEACTIVATE_IAM_USER_SYNC_CONFIG")]
      DeactivateIamUserSyncConfig,
      [EnumMember(Value = "INSTALL_SOFTWARE_UPDATES")]
      InstallSoftwareUpdates
  }
}
