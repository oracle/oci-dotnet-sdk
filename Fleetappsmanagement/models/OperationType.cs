/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.FleetappsmanagementService.Models
{
  /// <summary>
  /// Possible operation types.
  /// </summary>
  public enum OperationType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATE_FLEET")]
      CreateFleet,
      [EnumMember(Value = "UPDATE_FLEET")]
      UpdateFleet,
      [EnumMember(Value = "DELETE_FLEET")]
      DeleteFleet,
      [EnumMember(Value = "CONFIRM_TARGET")]
      ConfirmTarget,
      [EnumMember(Value = "GENERATE_COMPLIANCE")]
      GenerateCompliance,
      [EnumMember(Value = "REQUEST_TARGET_DISCOVERY")]
      RequestTargetDiscovery,
      [EnumMember(Value = "VALIDATE_RESOURCE")]
      ValidateResource,
      [EnumMember(Value = "CREATE_CREDENTIAL")]
      CreateCredential,
      [EnumMember(Value = "UPDATE_CREDENTIAL")]
      UpdateCredential,
      [EnumMember(Value = "DELETE_CREDENTIAL")]
      DeleteCredential,
      [EnumMember(Value = "CREATE_SCHEDULE")]
      CreateSchedule,
      [EnumMember(Value = "UPDATE_SCHEDULE")]
      UpdateSchedule,
      [EnumMember(Value = "UPDATE_MAINTENANCE_WINDOW")]
      UpdateMaintenanceWindow,
      [EnumMember(Value = "DELETE_MAINTENANCE_WINDOW")]
      DeleteMaintenanceWindow,
      [EnumMember(Value = "CREATE_FLEET_RESOURCE")]
      CreateFleetResource,
      [EnumMember(Value = "UPDATE_FLEET_RESOURCE")]
      UpdateFleetResource,
      [EnumMember(Value = "DELETE_FLEET_RESOURCE")]
      DeleteFleetResource,
      [EnumMember(Value = "CREATE_FAMS_ONBOARDING")]
      CreateFamsOnboarding
  }
}