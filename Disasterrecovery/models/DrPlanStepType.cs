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
    /// - COMPUTE_INSTANCE_STOP_PRECHECK - A precheck step for validating a compute instance stop.
    /// - COMPUTE_INSTANCE_LAUNCH_PRECHECK - A precheck step for validating a compute instance launch.
    /// - COMPUTE_INSTANCE_TERMINATE_PRECHECK - A precheck step for validating a compute instance termination.
    /// - COMPUTE_INSTANCE_REMOVE_PRECHECK - A precheck step for validating a compute instance removal.
    /// - VOLUME_GROUP_RESTORE_SWITCHOVER_PRECHECK - A precheck step for validating a volume group restoration during a switchover.
    /// - VOLUME_GROUP_RESTORE_FAILOVER_PRECHECK - A precheck step for validating a volume group restoration during a failover.
    /// - DATABASE_SWITCHOVER_PRECHECK - A precheck step for validating the database during a switchover.
    /// - DATABASE_FAILOVER_PRECHECK - A precheck step for validating the database during a failover.
    /// - AUTONOMOUS_DATABASE_SWITCHOVER_PRECHECK - A precheck step for validating an autonomous database during a switchover.
    /// - AUTONOMOUS_DATABASE_FAILOVER_PRECHECK - A precheck step for validating an autonomous database during a failover.
    /// - AUTONOMOUS_CONTAINER_DATABASE_SWITCHOVER_PRECHECK - A precheck step for validating an autonomous container database during a switchover.
    /// - AUTONOMOUS_CONTAINER_DATABASE_FAILOVER_PRECHECK - A precheck step for validating an autonomous container database during a failover.
    /// - AUTONOMOUS_CONTAINER_DATABASE_START_DRILL_CONVERT_TO_SNAPSHOT_STANDBY_PRECHECK - A precheck step for validating the conversion of an autonomous container database to a snapshot at standby for a start drill.
    /// - AUTONOMOUS_CONTAINER_DATABASE_STOP_DRILL_CONVERT_TO_PHYSICAL_STANDBY_PRECHECK - A precheck step for validating the conversion of an autonomous container database to a physical instance at standby for a stop drill.
    /// - AUTONOMOUS_CONTAINER_DATABASE_SWITCHOVER - A DR plan step to perform an autonomous container database switchover.
    /// - AUTONOMOUS_CONTAINER_DATABASE_FAILOVER - A DR plan step to perform an autonomous container database failover.
    /// - AUTONOMOUS_CONTAINER_DATABASE_START_DRILL_CONVERT_TO_SNAPSHOT_STANDBY - A DR plan step to convert an autonomous container database to a snapshot at standby during a start drill.
    /// - AUTONOMOUS_CONTAINER_DATABASE_STOP_DRILL_CONVERT_TO_PHYSICAL_STANDBY - A DR plan step to convert an autonomous container database to a physical instance at standby during a stop drill.
    /// - AUTONOMOUS_DATABASE_START_DRILL_CREATE_CLONE_STANDBY_PRECHECK - A precheck step for validating the creation of an autonomous database clone at standby during a start drill.
    /// - AUTONOMOUS_DATABASE_STOP_DRILL_DELETE_CLONE_STANDBY_PRECHECK - A precheck step for validating the deletion of an autonomous database clone at standby during a stop drill.
    /// - AUTONOMOUS_DATABASE_START_DRILL_CONVERT_TO_SNAPSHOT_STANDBY_PRECHECK - A precheck step for validating the conversion of an autonomous database to snapshot at standby during a start drill.
    /// - AUTONOMOUS_DATABASE_STOP_DRILL_CONVERT_TO_PHYSICAL_STANDBY_PRECHECK - A precheck step for validating the conversion of an autonomous database to a physical instance at standby during a start drill.
    /// - AUTONOMOUS_DATABASE_START_DRILL_CREATE_CLONE_STANDBY - A DR plan step to create an autonomous database clone at standby during a start drill.
    /// - AUTONOMOUS_DATABASE_STOP_DRILL_DELETE_CLONE_STANDBY - A DR plan step to delete an autonomous database clone at standby during a stop drill.
    /// - AUTONOMOUS_DATABASE_START_DRILL_CONVERT_TO_SNAPSHOT_STANDBY - A DR plan step to convert an autonomous database to a snapshot at standby during a start drill.
    /// - AUTONOMOUS_DATABASE_STOP_DRILL_CONVERT_TO_PHYSICAL_STANDBY - A DR plan step to convert an autonomous database to a physical instance at standby during a stop drill.
    /// - USER_DEFINED_PRECHECK - A precheck step for validating a user-defined step.
    /// - COMPUTE_INSTANCE_LAUNCH - A DR plan step to launch a compute instance.
    /// - COMPUTE_INSTANCE_STOP - A DR plan step to stop a compute instance.
    /// - COMPUTE_INSTANCE_TERMINATE - A DR plan step to terminate a compute instance.
    /// - COMPUTE_INSTANCE_REMOVE - A DR plan step to remove a compute instance.
    /// - DATABASE_SWITCHOVER - A DR plan step to perform a database switchover.
    /// - DATABASE_FAILOVER - A DR plan step to perform a database failover.
    /// - AUTONOMOUS_DATABASE_SWITCHOVER - A DR plan step to perform an autonomous database switchover.
    /// - AUTONOMOUS_DATABASE_FAILOVER - A DR plan step to perform an autonomous database failover.
    /// - VOLUME_GROUP_RESTORE_SWITCHOVER - A DR plan step to perform a volume group restoration during a switchover.
    /// - VOLUME_GROUP_RESTORE_FAILOVER - A DR plan step to perform a volume group restoration during a failover.
    /// - VOLUME_GROUP_REVERSE - A DR plan step to reverse a volume group.
    /// - VOLUME_GROUP_DELETE - A DR plan step to delete a volume group.
    /// - VOLUME_GROUP_REMOVE - A DR plan step to remove a volume group.
    /// - VOLUME_GROUP_TERMINATE - A DR plan step to terminate a volume group.
    /// - USER_DEFINED - User-defined step
    /// - VOLUME_GROUP_RESTORE_START_DRILL_PRECHECK - A precheck step for validating a volume group restoration during a start drill.
    /// - VOLUME_GROUP_REMOVE_PRECHECK - A precheck step for validating a volume group removal.
    /// - VOLUME_GROUP_TERMINATE_PRECHECK - A precheck step for validating a volume group termination.
    /// - VOLUME_GROUP_RESTORE_START_DRILL - A DR plan step for volume group restoration during a start drill.
    /// - AUTONOMOUS_DATABASE_CREATE_CLONE_PRECHECK - A precheck step for validating the creation of an autonomous database clone.
    /// - AUTONOMOUS_DATABASE_DELETE_CLONE_PRECHECK - A precheck step for validating the deletion of an autonomous database clone.
    /// - LOAD_BALANCER_UPDATE_PRIMARY_BACKEND_SET_PRECHECK - A precheck step for validating the update of primary load balancer backend set.
    /// - LOAD_BALANCER_UPDATE_STANDBY_BACKEND_SET_PRECHECK - A precheck step for validating the update of standby load balancer backend set.
    /// - FILE_SYSTEM_SWITCHOVER_PRECHECK - A precheck step for validating a file system during a switchover.
    /// - FILE_SYSTEM_FAILOVER_PRECHECK - A precheck step for validating a file system during a failover.
    /// - FILE_SYSTEM_START_DRILL_PRECHECK - A precheck step for validating a file system during a start drill.
    /// - FILE_SYSTEM_STOP_DRILL_PRECHECK - A precheck step for validating a file system during a stop drill.
    /// - FILE_SYSTEM_REMOVE_PRECHECK - A precheck step for validating a file system removal.
    /// - FILE_SYSTEM_TERMINATE_PRECHECK - A precheck step for validating a file system termination.
    /// - FILE_SYSTEM_MOUNT_PRECHECK - A precheck step for validating a file system to be mounted.
    /// - FILE_SYSTEM_UNMOUNT_PRECHECK - A precheck step for validating a file system to be unmounted.
    /// - COMPUTE_INSTANCE_START_PRECHECK - A precheck step for validating the start of a compute instance.
    /// - COMPUTE_INSTANCE_ATTACH_BLOCK_VOLUMES_PRECHECK - A precheck step for validating the attachment of block volumes to a compute instance.
    /// - COMPUTE_INSTANCE_DETACH_BLOCK_VOLUMES_PRECHECK - A precheck step for validating the detachment of block volumes from a compute instance.
    /// - COMPUTE_INSTANCE_MOUNT_BLOCK_VOLUMES_PRECHECK - A precheck step for validating the mounting of block volumes on a compute instance.
    /// - COMPUTE_INSTANCE_UNMOUNT_BLOCK_VOLUMES_PRECHECK - A precheck step for validating the unmounting of block volumes from a compute instance.
    /// - COMPUTE_CAPACITY_RESERVATION_START_DRILL_PRECHECK - A precheck step for validating a compute capacity reservation during a start drill.
    /// - COMPUTE_CAPACITY_AVAILABILITY_START_DRILL_PRECHECK - A precheck step for validating a compute capacity availability during a start drill .
    /// - AUTONOMOUS_DATABASE_CREATE_CLONE - A DR plan step to create an autonomous database clone.
    /// - AUTONOMOUS_DATABASE_DELETE_CLONE - A DR plan step to delete an autonomous database clone.
    /// - LOAD_BALANCER_UPDATE_PRIMARY_BACKEND_SET - A DR plan step to update a primary load balancer backend set.
    /// - LOAD_BALANCER_UPDATE_STANDBY_BACKEND_SET - A DR plan step to update a standby load balancer backend set.
    /// - FILE_SYSTEM_SWITCHOVER - A DR plan step to perform a file system switchover.
    /// - FILE_SYSTEM_FAILOVER - A DR plan step to perform a file system failover.
    /// - FILE_SYSTEM_REMOVE - A DR plan step to remove a file system.
    /// - FILE_SYSTEM_REVERSE - A DR plan step to reverse replication in a file system.
    /// - FILE_SYSTEM_TERMINATE - A DR plan step to terminate a file system.
    /// - FILE_SYSTEM_START_DRILL - A DR plan step to perform a start drill operation for a file system.
    /// - FILE_SYSTEM_STOP_DRILL - A DR plan step to perform a stop drill operation for a file system.
    /// - COMPUTE_INSTANCE_START - A DR plan step to start a compute instance.
    /// - COMPUTE_INSTANCE_ATTACH_BLOCK_VOLUMES - A DR plan step to attach block volumes to a compute instance.
    /// - COMPUTE_INSTANCE_DETACH_BLOCK_VOLUMES - A DR plan step to detach block volumes from a compute instance.
    /// - FILE_SYSTEM_MOUNT - A DR plan step to mount a file system.
    /// - FILE_SYSTEM_UNMOUNT - A DR plan step to unmount a file system.
    /// - COMPUTE_CAPACITY_RESERVATION_SWITCHOVER_PRECHECK - A precheck step for validating a compute capacity reservation during a switchover.
    /// - COMPUTE_CAPACITY_RESERVATION_FAILOVER_PRECHECK - A precheck step for validating a capacity reservation during a failover.
    /// - COMPUTE_CAPACITY_AVAILABILITY_SWITCHOVER_PRECHECK - A precheck step for validating a compute capacity availability during a switchover.
    /// - COMPUTE_CAPACITY_AVAILABILITY_FAILOVER_PRECHECK - A precheck step for validating a compute capacity availability during a failover.
    /// - OBJECT_STORAGE_BUCKET_SWITCHOVER_DELETE_REPLICATION_PRIMARY_PRECHECK - A precheck step for validating the deletion of an object storage bucket replication in the primary region during a switchover.
    /// - OBJECT_STORAGE_BUCKET_SWITCHOVER_SETUP_REVERSE_REPLICATION_STANDBY_PRECHECK - A precheck step for validating an object storage bucket reverse replication set up in the standby region during a switchover.
    /// - OBJECT_STORAGE_BUCKET_FAILOVER_DELETE_REPLICATION_STANDBY_PRECHECK - A precheck step for validating the deletion of an object storage bucket replication in the standby region during a failover.
    /// - OBJECT_STORAGE_BUCKET_FAILOVER_SETUP_REVERSE_REPLICATION_STANDBY_PRECHECK - A precheck step for validating an object storage bucket reverse replication set up in the standby region during a failover.
    /// - OBJECT_STORAGE_BUCKET_SWITCHOVER_DELETE_REPLICATION_PRIMARY - A DR plan step to delete an object storage bucket replication in the primary region during a switchover.
    /// - OBJECT_STORAGE_BUCKET_SWITCHOVER_SETUP_REVERSE_REPLICATION_STANDBY - A DR plan step to set up an object storage bucket reverse replication in the standby region during a switchover.
    /// - OBJECT_STORAGE_BUCKET_FAILOVER_DELETE_REPLICATION_STANDBY - A DR plan step to delete an object storage bucket replication in the standby region during a failover.
    /// - OBJECT_STORAGE_BUCKET_FAILOVER_SETUP_REVERSE_REPLICATION_STANDBY - A DR plan step to set up an object storage bucket reverse replication in the standby region during a failover.
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
      [EnumMember(Value = "AUTONOMOUS_CONTAINER_DATABASE_SWITCHOVER_PRECHECK")]
      AutonomousContainerDatabaseSwitchoverPrecheck,
      [EnumMember(Value = "AUTONOMOUS_CONTAINER_DATABASE_FAILOVER_PRECHECK")]
      AutonomousContainerDatabaseFailoverPrecheck,
      [EnumMember(Value = "AUTONOMOUS_CONTAINER_DATABASE_START_DRILL_CONVERT_TO_SNAPSHOT_STANDBY_PRECHECK")]
      AutonomousContainerDatabaseStartDrillConvertToSnapshotStandbyPrecheck,
      [EnumMember(Value = "AUTONOMOUS_CONTAINER_DATABASE_STOP_DRILL_CONVERT_TO_PHYSICAL_STANDBY_PRECHECK")]
      AutonomousContainerDatabaseStopDrillConvertToPhysicalStandbyPrecheck,
      [EnumMember(Value = "AUTONOMOUS_CONTAINER_DATABASE_SWITCHOVER")]
      AutonomousContainerDatabaseSwitchover,
      [EnumMember(Value = "AUTONOMOUS_CONTAINER_DATABASE_FAILOVER")]
      AutonomousContainerDatabaseFailover,
      [EnumMember(Value = "AUTONOMOUS_CONTAINER_DATABASE_START_DRILL_CONVERT_TO_SNAPSHOT_STANDBY")]
      AutonomousContainerDatabaseStartDrillConvertToSnapshotStandby,
      [EnumMember(Value = "AUTONOMOUS_CONTAINER_DATABASE_STOP_DRILL_CONVERT_TO_PHYSICAL_STANDBY")]
      AutonomousContainerDatabaseStopDrillConvertToPhysicalStandby,
      [EnumMember(Value = "AUTONOMOUS_DATABASE_START_DRILL_CREATE_CLONE_STANDBY_PRECHECK")]
      AutonomousDatabaseStartDrillCreateCloneStandbyPrecheck,
      [EnumMember(Value = "AUTONOMOUS_DATABASE_STOP_DRILL_DELETE_CLONE_STANDBY_PRECHECK")]
      AutonomousDatabaseStopDrillDeleteCloneStandbyPrecheck,
      [EnumMember(Value = "AUTONOMOUS_DATABASE_START_DRILL_CONVERT_TO_SNAPSHOT_STANDBY_PRECHECK")]
      AutonomousDatabaseStartDrillConvertToSnapshotStandbyPrecheck,
      [EnumMember(Value = "AUTONOMOUS_DATABASE_STOP_DRILL_CONVERT_TO_PHYSICAL_STANDBY_PRECHECK")]
      AutonomousDatabaseStopDrillConvertToPhysicalStandbyPrecheck,
      [EnumMember(Value = "AUTONOMOUS_DATABASE_START_DRILL_CREATE_CLONE_STANDBY")]
      AutonomousDatabaseStartDrillCreateCloneStandby,
      [EnumMember(Value = "AUTONOMOUS_DATABASE_STOP_DRILL_DELETE_CLONE_STANDBY")]
      AutonomousDatabaseStopDrillDeleteCloneStandby,
      [EnumMember(Value = "AUTONOMOUS_DATABASE_START_DRILL_CONVERT_TO_SNAPSHOT_STANDBY")]
      AutonomousDatabaseStartDrillConvertToSnapshotStandby,
      [EnumMember(Value = "AUTONOMOUS_DATABASE_STOP_DRILL_CONVERT_TO_PHYSICAL_STANDBY")]
      AutonomousDatabaseStopDrillConvertToPhysicalStandby,
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
      ComputeCapacityAvailabilityFailoverPrecheck,
      [EnumMember(Value = "OBJECT_STORAGE_BUCKET_SWITCHOVER_DELETE_REPLICATION_PRIMARY_PRECHECK")]
      ObjectStorageBucketSwitchoverDeleteReplicationPrimaryPrecheck,
      [EnumMember(Value = "OBJECT_STORAGE_BUCKET_SWITCHOVER_SETUP_REVERSE_REPLICATION_STANDBY_PRECHECK")]
      ObjectStorageBucketSwitchoverSetupReverseReplicationStandbyPrecheck,
      [EnumMember(Value = "OBJECT_STORAGE_BUCKET_FAILOVER_DELETE_REPLICATION_STANDBY_PRECHECK")]
      ObjectStorageBucketFailoverDeleteReplicationStandbyPrecheck,
      [EnumMember(Value = "OBJECT_STORAGE_BUCKET_FAILOVER_SETUP_REVERSE_REPLICATION_STANDBY_PRECHECK")]
      ObjectStorageBucketFailoverSetupReverseReplicationStandbyPrecheck,
      [EnumMember(Value = "OBJECT_STORAGE_BUCKET_SWITCHOVER_DELETE_REPLICATION_PRIMARY")]
      ObjectStorageBucketSwitchoverDeleteReplicationPrimary,
      [EnumMember(Value = "OBJECT_STORAGE_BUCKET_SWITCHOVER_SETUP_REVERSE_REPLICATION_STANDBY")]
      ObjectStorageBucketSwitchoverSetupReverseReplicationStandby,
      [EnumMember(Value = "OBJECT_STORAGE_BUCKET_FAILOVER_DELETE_REPLICATION_STANDBY")]
      ObjectStorageBucketFailoverDeleteReplicationStandby,
      [EnumMember(Value = "OBJECT_STORAGE_BUCKET_FAILOVER_SETUP_REVERSE_REPLICATION_STANDBY")]
      ObjectStorageBucketFailoverSetupReverseReplicationStandby
  }
}
