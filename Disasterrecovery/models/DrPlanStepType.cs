/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DisasterrecoveryService.Models
{
  /// <summary>
  /// The types of steps in a DR plan.
    /// 
  /// </summary>
  public enum DrPlanStepType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "COMPUTE_INSTANCE_STOP_PRECHECK")]
      ComputeInstanceStopPrecheck,
      [EnumMember(Value = "COMPUTE_INSTANCE_LAUNCH_PRECHECK")]
      ComputeInstanceLaunchPrecheck,
      [EnumMember(Value = "COMPUTE_INSTANCE_TERMINATE_PRECHECK")]
      ComputeInstanceTerminatePrecheck,
      [EnumMember(Value = "COMPUTE_INSTANCE_REMOVE_PRECHECK")]
      ComputeInstanceRemovePrecheck,
      [EnumMember(Value = "VOLUME_GROUP_RESTORE_SWITCHOVER_PRECHECK")]
      VolumeGroupRestoreSwitchoverPrecheck,
      [EnumMember(Value = "VOLUME_GROUP_RESTORE_FAILOVER_PRECHECK")]
      VolumeGroupRestoreFailoverPrecheck,
      [EnumMember(Value = "DATABASE_SWITCHOVER_PRECHECK")]
      DatabaseSwitchoverPrecheck,
      [EnumMember(Value = "DATABASE_FAILOVER_PRECHECK")]
      DatabaseFailoverPrecheck,
      [EnumMember(Value = "AUTONOMOUS_DATABASE_SWITCHOVER_PRECHECK")]
      AutonomousDatabaseSwitchoverPrecheck,
      [EnumMember(Value = "AUTONOMOUS_DATABASE_FAILOVER_PRECHECK")]
      AutonomousDatabaseFailoverPrecheck,
      [EnumMember(Value = "USER_DEFINED_PRECHECK")]
      UserDefinedPrecheck,
      [EnumMember(Value = "COMPUTE_INSTANCE_LAUNCH")]
      ComputeInstanceLaunch,
      [EnumMember(Value = "COMPUTE_INSTANCE_STOP")]
      ComputeInstanceStop,
      [EnumMember(Value = "COMPUTE_INSTANCE_TERMINATE")]
      ComputeInstanceTerminate,
      [EnumMember(Value = "COMPUTE_INSTANCE_REMOVE")]
      ComputeInstanceRemove,
      [EnumMember(Value = "DATABASE_SWITCHOVER")]
      DatabaseSwitchover,
      [EnumMember(Value = "DATABASE_FAILOVER")]
      DatabaseFailover,
      [EnumMember(Value = "AUTONOMOUS_DATABASE_SWITCHOVER")]
      AutonomousDatabaseSwitchover,
      [EnumMember(Value = "AUTONOMOUS_DATABASE_FAILOVER")]
      AutonomousDatabaseFailover,
      [EnumMember(Value = "VOLUME_GROUP_RESTORE_SWITCHOVER")]
      VolumeGroupRestoreSwitchover,
      [EnumMember(Value = "VOLUME_GROUP_RESTORE_FAILOVER")]
      VolumeGroupRestoreFailover,
      [EnumMember(Value = "VOLUME_GROUP_REVERSE")]
      VolumeGroupReverse,
      [EnumMember(Value = "VOLUME_GROUP_DELETE")]
      VolumeGroupDelete,
      [EnumMember(Value = "VOLUME_GROUP_REMOVE")]
      VolumeGroupRemove,
      [EnumMember(Value = "VOLUME_GROUP_TERMINATE")]
      VolumeGroupTerminate,
      [EnumMember(Value = "USER_DEFINED")]
      UserDefined,
      [EnumMember(Value = "VOLUME_GROUP_RESTORE_START_DRILL_PRECHECK")]
      VolumeGroupRestoreStartDrillPrecheck,
      [EnumMember(Value = "VOLUME_GROUP_REMOVE_PRECHECK")]
      VolumeGroupRemovePrecheck,
      [EnumMember(Value = "VOLUME_GROUP_TERMINATE_PRECHECK")]
      VolumeGroupTerminatePrecheck,
      [EnumMember(Value = "VOLUME_GROUP_RESTORE_START_DRILL")]
      VolumeGroupRestoreStartDrill,
      [EnumMember(Value = "AUTONOMOUS_DATABASE_CREATE_CLONE_PRECHECK")]
      AutonomousDatabaseCreateClonePrecheck,
      [EnumMember(Value = "AUTONOMOUS_DATABASE_DELETE_CLONE_PRECHECK")]
      AutonomousDatabaseDeleteClonePrecheck,
      [EnumMember(Value = "LOAD_BALANCER_UPDATE_PRIMARY_BACKEND_SET_PRECHECK")]
      LoadBalancerUpdatePrimaryBackendSetPrecheck,
      [EnumMember(Value = "LOAD_BALANCER_UPDATE_STANDBY_BACKEND_SET_PRECHECK")]
      LoadBalancerUpdateStandbyBackendSetPrecheck,
      [EnumMember(Value = "FILE_SYSTEM_SWITCHOVER_PRECHECK")]
      FileSystemSwitchoverPrecheck,
      [EnumMember(Value = "FILE_SYSTEM_FAILOVER_PRECHECK")]
      FileSystemFailoverPrecheck,
      [EnumMember(Value = "FILE_SYSTEM_START_DRILL_PRECHECK")]
      FileSystemStartDrillPrecheck,
      [EnumMember(Value = "FILE_SYSTEM_STOP_DRILL_PRECHECK")]
      FileSystemStopDrillPrecheck,
      [EnumMember(Value = "FILE_SYSTEM_REMOVE_PRECHECK")]
      FileSystemRemovePrecheck,
      [EnumMember(Value = "FILE_SYSTEM_TERMINATE_PRECHECK")]
      FileSystemTerminatePrecheck,
      [EnumMember(Value = "FILE_SYSTEM_MOUNT_PRECHECK")]
      FileSystemMountPrecheck,
      [EnumMember(Value = "FILE_SYSTEM_UNMOUNT_PRECHECK")]
      FileSystemUnmountPrecheck,
      [EnumMember(Value = "COMPUTE_INSTANCE_START_PRECHECK")]
      ComputeInstanceStartPrecheck,
      [EnumMember(Value = "COMPUTE_INSTANCE_ATTACH_BLOCK_VOLUMES_PRECHECK")]
      ComputeInstanceAttachBlockVolumesPrecheck,
      [EnumMember(Value = "COMPUTE_INSTANCE_DETACH_BLOCK_VOLUMES_PRECHECK")]
      ComputeInstanceDetachBlockVolumesPrecheck,
      [EnumMember(Value = "COMPUTE_INSTANCE_MOUNT_BLOCK_VOLUMES_PRECHECK")]
      ComputeInstanceMountBlockVolumesPrecheck,
      [EnumMember(Value = "COMPUTE_INSTANCE_UNMOUNT_BLOCK_VOLUMES_PRECHECK")]
      ComputeInstanceUnmountBlockVolumesPrecheck,
      [EnumMember(Value = "COMPUTE_CAPACITY_RESERVATION_START_DRILL_PRECHECK")]
      ComputeCapacityReservationStartDrillPrecheck,
      [EnumMember(Value = "COMPUTE_CAPACITY_AVAILABILITY_START_DRILL_PRECHECK")]
      ComputeCapacityAvailabilityStartDrillPrecheck,
      [EnumMember(Value = "AUTONOMOUS_DATABASE_CREATE_CLONE")]
      AutonomousDatabaseCreateClone,
      [EnumMember(Value = "AUTONOMOUS_DATABASE_DELETE_CLONE")]
      AutonomousDatabaseDeleteClone,
      [EnumMember(Value = "LOAD_BALANCER_UPDATE_PRIMARY_BACKEND_SET")]
      LoadBalancerUpdatePrimaryBackendSet,
      [EnumMember(Value = "LOAD_BALANCER_UPDATE_STANDBY_BACKEND_SET")]
      LoadBalancerUpdateStandbyBackendSet,
      [EnumMember(Value = "FILE_SYSTEM_SWITCHOVER")]
      FileSystemSwitchover,
      [EnumMember(Value = "FILE_SYSTEM_FAILOVER")]
      FileSystemFailover,
      [EnumMember(Value = "FILE_SYSTEM_REMOVE")]
      FileSystemRemove,
      [EnumMember(Value = "FILE_SYSTEM_REVERSE")]
      FileSystemReverse,
      [EnumMember(Value = "FILE_SYSTEM_TERMINATE")]
      FileSystemTerminate,
      [EnumMember(Value = "FILE_SYSTEM_START_DRILL")]
      FileSystemStartDrill,
      [EnumMember(Value = "FILE_SYSTEM_STOP_DRILL")]
      FileSystemStopDrill,
      [EnumMember(Value = "COMPUTE_INSTANCE_START")]
      ComputeInstanceStart,
      [EnumMember(Value = "COMPUTE_INSTANCE_ATTACH_BLOCK_VOLUMES")]
      ComputeInstanceAttachBlockVolumes,
      [EnumMember(Value = "COMPUTE_INSTANCE_DETACH_BLOCK_VOLUMES")]
      ComputeInstanceDetachBlockVolumes,
      [EnumMember(Value = "FILE_SYSTEM_MOUNT")]
      FileSystemMount,
      [EnumMember(Value = "FILE_SYSTEM_UNMOUNT")]
      FileSystemUnmount,
      [EnumMember(Value = "COMPUTE_CAPACITY_RESERVATION_SWITCHOVER_PRECHECK")]
      ComputeCapacityReservationSwitchoverPrecheck,
      [EnumMember(Value = "COMPUTE_CAPACITY_RESERVATION_FAILOVER_PRECHECK")]
      ComputeCapacityReservationFailoverPrecheck,
      [EnumMember(Value = "COMPUTE_CAPACITY_AVAILABILITY_SWITCHOVER_PRECHECK")]
      ComputeCapacityAvailabilitySwitchoverPrecheck,
      [EnumMember(Value = "COMPUTE_CAPACITY_AVAILABILITY_FAILOVER_PRECHECK")]
      ComputeCapacityAvailabilityFailoverPrecheck
  }
}
