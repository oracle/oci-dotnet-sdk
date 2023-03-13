/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.ContainerengineService.Models
{
  /// <summary>
  /// The types of work request operations.
  /// </summary>
  public enum WorkRequestOperationType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CLUSTER_CREATE")]
      ClusterCreate,
      [EnumMember(Value = "CLUSTER_UPDATE")]
      ClusterUpdate,
      [EnumMember(Value = "CLUSTER_DELETE")]
      ClusterDelete,
      [EnumMember(Value = "NODEPOOL_CREATE")]
      NodepoolCreate,
      [EnumMember(Value = "NODEPOOL_UPDATE")]
      NodepoolUpdate,
      [EnumMember(Value = "NODEPOOL_DELETE")]
      NodepoolDelete,
      [EnumMember(Value = "NODEPOOL_RECONCILE")]
      NodepoolReconcile,
      [EnumMember(Value = "WORKREQUEST_CANCEL")]
      WorkrequestCancel,
      [EnumMember(Value = "VIRTUALNODEPOOL_CREATE")]
      VirtualnodepoolCreate,
      [EnumMember(Value = "VIRTUALNODEPOOL_UPDATE")]
      VirtualnodepoolUpdate,
      [EnumMember(Value = "VIRTUALNODEPOOL_DELETE")]
      VirtualnodepoolDelete,
      [EnumMember(Value = "VIRTUALNODE_DELETE")]
      VirtualnodeDelete,
      [EnumMember(Value = "ENABLE_ADDON")]
      EnableAddon,
      [EnumMember(Value = "UPDATE_ADDON")]
      UpdateAddon,
      [EnumMember(Value = "DISABLE_ADDON")]
      DisableAddon,
      [EnumMember(Value = "RECONCILE_ADDON")]
      ReconcileAddon
  }
}
