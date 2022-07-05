/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DatabasemigrationService.Models
{
  /// <summary>
  /// Possible ODMS Job Phases.
    /// 
  /// </summary>
  public enum OdmsJobPhases {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "ODMS_VALIDATE_TGT")]
      OdmsValidateTgt,
      [EnumMember(Value = "ODMS_VALIDATE_SRC")]
      OdmsValidateSrc,
      [EnumMember(Value = "ODMS_VALIDATE_PREMIGRATION_ADVISOR")]
      OdmsValidatePremigrationAdvisor,
      [EnumMember(Value = "ODMS_VALIDATE_GG_HUB")]
      OdmsValidateGgHub,
      [EnumMember(Value = "ODMS_VALIDATE_DATAPUMP_SETTINGS")]
      OdmsValidateDatapumpSettings,
      [EnumMember(Value = "ODMS_VALIDATE_DATAPUMP_SETTINGS_SRC")]
      OdmsValidateDatapumpSettingsSrc,
      [EnumMember(Value = "ODMS_VALIDATE_DATAPUMP_SETTINGS_TGT")]
      OdmsValidateDatapumpSettingsTgt,
      [EnumMember(Value = "ODMS_VALIDATE_DATAPUMP_SRC")]
      OdmsValidateDatapumpSrc,
      [EnumMember(Value = "ODMS_VALIDATE_DATAPUMP_ESTIMATE_SRC")]
      OdmsValidateDatapumpEstimateSrc,
      [EnumMember(Value = "ODMS_VALIDATE")]
      OdmsValidate,
      [EnumMember(Value = "ODMS_PREPARE")]
      OdmsPrepare,
      [EnumMember(Value = "ODMS_INITIAL_LOAD_EXPORT")]
      OdmsInitialLoadExport,
      [EnumMember(Value = "ODMS_DATA_UPLOAD")]
      OdmsDataUpload,
      [EnumMember(Value = "ODMS_INITIAL_LOAD_IMPORT")]
      OdmsInitialLoadImport,
      [EnumMember(Value = "ODMS_POST_INITIAL_LOAD")]
      OdmsPostInitialLoad,
      [EnumMember(Value = "ODMS_PREPARE_REPLICATION_TARGET")]
      OdmsPrepareReplicationTarget,
      [EnumMember(Value = "ODMS_MONITOR_REPLICATION_LAG")]
      OdmsMonitorReplicationLag,
      [EnumMember(Value = "ODMS_SWITCHOVER")]
      OdmsSwitchover,
      [EnumMember(Value = "ODMS_CLEANUP")]
      OdmsCleanup
  }
}
