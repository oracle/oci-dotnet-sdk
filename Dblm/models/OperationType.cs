/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DblmService.Models
{
  /// <summary>
  /// Possible operation types.
  /// </summary>
  public enum OperationType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "DBLM_SUBSCRIBE")]
      DblmSubscribe,
      [EnumMember(Value = "DBLM_ENABLE")]
      DblmEnable,
      [EnumMember(Value = "SCAN_VUL_CVE")]
      ScanVulCve,
      [EnumMember(Value = "SCAN_VUL_PATCH")]
      ScanVulPatch,
      [EnumMember(Value = "SCAN_VUL_IMAGE")]
      ScanVulImage,
      [EnumMember(Value = "UPDATE_SUBSCRIPTION")]
      UpdateSubscription,
      [EnumMember(Value = "UPDATE_SUBSCRIBED_RESOURCE")]
      UpdateSubscribedResource,
      [EnumMember(Value = "CREATE_SHARED_DATASTORE")]
      CreateSharedDatastore,
      [EnumMember(Value = "DELETE_SHARED_DATASTORE")]
      DeleteSharedDatastore
  }
}
