/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.AnalyticsService.Models
{
  /// <summary>
  /// The way in which a resource was affected by a work request.
    /// 
  /// </summary>
  public enum WorkRequestActionResult {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "COMPARTMENT_CHANGED")]
      CompartmentChanged,
      [EnumMember(Value = "CREATED")]
      Created,
      [EnumMember(Value = "DELETED")]
      Deleted,
      [EnumMember(Value = "STARTED")]
      Started,
      [EnumMember(Value = "STOPPED")]
      Stopped,
      [EnumMember(Value = "SCALED")]
      Scaled,
      [EnumMember(Value = "NETWORK_ENDPOINT_CHANGED")]
      NetworkEndpointChanged,
      [EnumMember(Value = "VANITY_URL_CREATED")]
      VanityUrlCreated,
      [EnumMember(Value = "VANITY_URL_UPDATED")]
      VanityUrlUpdated,
      [EnumMember(Value = "VANITY_URL_DELETED")]
      VanityUrlDeleted,
      [EnumMember(Value = "PRIVATE_ACCESS_CHANNEL_CREATED")]
      PrivateAccessChannelCreated,
      [EnumMember(Value = "PRIVATE_ACCESS_CHANNEL_UPDATED")]
      PrivateAccessChannelUpdated,
      [EnumMember(Value = "PRIVATE_ACCESS_CHANNEL_DELETED")]
      PrivateAccessChannelDeleted,
      [EnumMember(Value = "NONE")]
      None
  }
}
