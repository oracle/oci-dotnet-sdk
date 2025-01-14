/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.AnalyticsService.Models
{
  /// <summary>
  /// The types of work request operations.
    /// 
  /// </summary>
  public enum WorkRequestOperationType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATE_ANALYTICS_INSTANCE")]
      CreateAnalyticsInstance,
      [EnumMember(Value = "DELETE_ANALYTICS_INSTANCE")]
      DeleteAnalyticsInstance,
      [EnumMember(Value = "START_ANALYTICS_INSTANCE")]
      StartAnalyticsInstance,
      [EnumMember(Value = "STOP_ANALYTICS_INSTANCE")]
      StopAnalyticsInstance,
      [EnumMember(Value = "SCALE_ANALYTICS_INSTANCE")]
      ScaleAnalyticsInstance,
      [EnumMember(Value = "CHANGE_ANALYTICS_INSTANCE_COMPARTMENT")]
      ChangeAnalyticsInstanceCompartment,
      [EnumMember(Value = "CHANGE_ANALYTICS_INSTANCE_NETWORK_ENDPOINT")]
      ChangeAnalyticsInstanceNetworkEndpoint,
      [EnumMember(Value = "CREATE_VANITY_URL")]
      CreateVanityUrl,
      [EnumMember(Value = "UPDATE_VANITY_URL")]
      UpdateVanityUrl,
      [EnumMember(Value = "DELETE_VANITY_URL")]
      DeleteVanityUrl,
      [EnumMember(Value = "CREATE_PRIVATE_ACCESS_CHANNEL")]
      CreatePrivateAccessChannel,
      [EnumMember(Value = "UPDATE_PRIVATE_ACCESS_CHANNEL")]
      UpdatePrivateAccessChannel,
      [EnumMember(Value = "DELETE_PRIVATE_ACCESS_CHANNEL")]
      DeletePrivateAccessChannel,
      [EnumMember(Value = "UPDATE_INSTANCE_ENCRYPTION_KEY")]
      UpdateInstanceEncryptionKey
  }
}
