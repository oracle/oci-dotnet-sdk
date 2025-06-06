/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.ContainerengineService.Models
{
  /// <summary>
  /// BOOT_VOLUME_REPLACE cycling swaps the boot volume on the same node, while INSTANCE_REPLACE cycling deletes and recreates a new node with the changes applied.
    /// Only a subset of fields (kubernetesVersion, imageId, bootVolumeSizeInGBs, nodeMetadata, sshPublicKey) can be changed with BOOT_VOLUME_REPLACE cycling. 
    /// The cycling operation will attempt to bring all nodes in the NodePool in sync with the NodePool specification. If BOOT_VOLUME_REPLACE cycling mode is chosen, and the node needs changes to fields that can not be updated via a BOOT_VOLUME_REPLACE cycle, the cycle attempt for that node will fail. The operation has to be retried with cycle mode changed to INSTANCE_REPLACE in this case.
    /// 
  /// </summary>
  public enum CycleMode {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "BOOT_VOLUME_REPLACE")]
      BootVolumeReplace,
      [EnumMember(Value = "INSTANCE_REPLACE")]
      InstanceReplace
  }
}
