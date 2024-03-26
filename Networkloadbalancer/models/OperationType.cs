/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.NetworkloadbalancerService.Models
{
  /// <summary>
  /// Possible operations.
  /// </summary>
  public enum OperationType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATE_NETWORK_LOAD_BALANCER")]
      CreateNetworkLoadBalancer,
      [EnumMember(Value = "UPDATE_NETWORK_LOAD_BALANCER")]
      UpdateNetworkLoadBalancer,
      [EnumMember(Value = "DELETE_NETWORK_LOAD_BALANCER")]
      DeleteNetworkLoadBalancer,
      [EnumMember(Value = "CREATE_BACKEND")]
      CreateBackend,
      [EnumMember(Value = "UPDATE_BACKEND")]
      UpdateBackend,
      [EnumMember(Value = "DELETE_BACKEND")]
      DeleteBackend,
      [EnumMember(Value = "CREATE_LISTENER")]
      CreateListener,
      [EnumMember(Value = "UPDATE_LISTENER")]
      UpdateListener,
      [EnumMember(Value = "DELETE_LISTENER")]
      DeleteListener,
      [EnumMember(Value = "CREATE_BACKENDSET")]
      CreateBackendset,
      [EnumMember(Value = "UPDATE_BACKENDSET")]
      UpdateBackendset,
      [EnumMember(Value = "DELETE_BACKENDSET")]
      DeleteBackendset,
      [EnumMember(Value = "UPDATE_NSGS")]
      UpdateNsgs,
      [EnumMember(Value = "UPDATE_HEALTH_CHECKER")]
      UpdateHealthChecker,
      [EnumMember(Value = "CHANGE_COMPARTMENT")]
      ChangeCompartment,
      [EnumMember(Value = "ATTACH_NLB_TO_POD")]
      AttachNlbToPod,
      [EnumMember(Value = "DETACH_NLB_FROM_POD")]
      DetachNlbFromPod,
      [EnumMember(Value = "LIVE_MIGRATION")]
      LiveMigration
  }
}
