/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.GoldengateService.Models
{
  /// <summary>
  /// Possible operation types.
    /// <br/>
    /// Deprecated value: GoldengateConnectionAssigmnentDelete
    /// 
  /// </summary>
  public enum OperationType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "GOLDENGATE_DATABASE_REGISTRATION_CREATE")]
      GoldengateDatabaseRegistrationCreate,
      [EnumMember(Value = "GOLDENGATE_DATABASE_REGISTRATION_UPDATE")]
      GoldengateDatabaseRegistrationUpdate,
      [EnumMember(Value = "GOLDENGATE_DATABASE_REGISTRATION_DELETE")]
      GoldengateDatabaseRegistrationDelete,
      [EnumMember(Value = "GOLDENGATE_DATABASE_REGISTRATION_MOVE")]
      GoldengateDatabaseRegistrationMove,
      [EnumMember(Value = "GOLDENGATE_DEPLOYMENT_CREATE")]
      GoldengateDeploymentCreate,
      [EnumMember(Value = "GOLDENGATE_DEPLOYMENT_UPDATE")]
      GoldengateDeploymentUpdate,
      [EnumMember(Value = "GOLDENGATE_DEPLOYMENT_DELETE")]
      GoldengateDeploymentDelete,
      [EnumMember(Value = "GOLDENGATE_DEPLOYMENT_MOVE")]
      GoldengateDeploymentMove,
      [EnumMember(Value = "GOLDENGATE_DEPLOYMENT_RESTORE")]
      GoldengateDeploymentRestore,
      [EnumMember(Value = "GOLDENGATE_DEPLOYMENT_START")]
      GoldengateDeploymentStart,
      [EnumMember(Value = "GOLDENGATE_DEPLOYMENT_STOP")]
      GoldengateDeploymentStop,
      [EnumMember(Value = "GOLDENGATE_DEPLOYMENT_UPGRADE")]
      GoldengateDeploymentUpgrade,
      [EnumMember(Value = "GOLDENGATE_DEPLOYMENT_BACKUP_CREATE")]
      GoldengateDeploymentBackupCreate,
      [EnumMember(Value = "GOLDENGATE_DEPLOYMENT_BACKUP_DELETE")]
      GoldengateDeploymentBackupDelete,
      [EnumMember(Value = "GOLDENGATE_DEPLOYMENT_BACKUP_CANCEL")]
      GoldengateDeploymentBackupCancel,
      [EnumMember(Value = "GOLDENGATE_DEPLOYMENT_BACKUP_COPY")]
      GoldengateDeploymentBackupCopy,
      [EnumMember(Value = "GOLDENGATE_CONNECTION_CREATE")]
      GoldengateConnectionCreate,
      [EnumMember(Value = "GOLDENGATE_CONNECTION_UPDATE")]
      GoldengateConnectionUpdate,
      [EnumMember(Value = "GOLDENGATE_CONNECTION_DELETE")]
      GoldengateConnectionDelete,
      [EnumMember(Value = "GOLDENGATE_CONNECTION_MOVE")]
      GoldengateConnectionMove,
      [EnumMember(Value = "GOLDENGATE_CONNECTION_REFRESH")]
      GoldengateConnectionRefresh,
      [EnumMember(Value = "GOLDENGATE_CONNECTION_ASSIGNMENT_CREATE")]
      GoldengateConnectionAssignmentCreate,
      [EnumMember(Value = "GOLDENGATE_CONNECTION_ASSIGNMENT_DELETE")]
      GoldengateConnectionAssignmentDelete,
      [EnumMember(Value = "GOLDENGATE_CONNECTION_ASSIGMNENT_DELETE")]
      GoldengateConnectionAssigmnentDelete,
      [EnumMember(Value = "GOLDENGATE_DEPLOYMENT_DIAGNOSTIC_COLLECT")]
      GoldengateDeploymentDiagnosticCollect,
      [EnumMember(Value = "GOLDENGATE_DEPLOYMENT_WALLET_EXPORT")]
      GoldengateDeploymentWalletExport,
      [EnumMember(Value = "GOLDENGATE_DEPLOYMENT_WALLET_IMPORT")]
      GoldengateDeploymentWalletImport,
      [EnumMember(Value = "GOLDENGATE_DEPLOYMENT_UPGRADE_UPGRADE")]
      GoldengateDeploymentUpgradeUpgrade,
      [EnumMember(Value = "GOLDENGATE_DEPLOYMENT_UPGRADE_ROLLBACK")]
      GoldengateDeploymentUpgradeRollback,
      [EnumMember(Value = "GOLDENGATE_DEPLOYMENT_UPGRADE_SNOOZE")]
      GoldengateDeploymentUpgradeSnooze,
      [EnumMember(Value = "GOLDENGATE_DEPLOYMENT_CERTIFICATE_CREATE")]
      GoldengateDeploymentCertificateCreate,
      [EnumMember(Value = "GOLDENGATE_DEPLOYMENT_CERTIFICATE_DELETE")]
      GoldengateDeploymentCertificateDelete
  }
}
