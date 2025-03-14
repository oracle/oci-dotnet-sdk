/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.OsmanagementService.Models
{
  /// <summary>
  /// Content Availability Status:
    ///   * NOT_AVAILABLE - content is not available on the instance nor in the service
    ///   * AVAILABLE_ON_INSTANCE - content is only available on the instance
    ///   * AVAILABLE_ON_SERVICE - content is only available on the service
    ///   * AVAILABLE_ON_INSTANCE_AND_SERVICE - content is available both on the instance and the service
    ///   * AVAILABLE_ON_INSTANCE_UPLOAD_IN_PROGRESS - content is available on the instance and its upload is in progress
    /// 
  /// </summary>
  public enum ContentAvailability {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "NOT_AVAILABLE")]
      NotAvailable,
      [EnumMember(Value = "AVAILABLE_ON_INSTANCE")]
      AvailableOnInstance,
      [EnumMember(Value = "AVAILABLE_ON_SERVICE")]
      AvailableOnService,
      [EnumMember(Value = "AVAILABLE_ON_INSTANCE_AND_SERVICE")]
      AvailableOnInstanceAndService,
      [EnumMember(Value = "AVAILABLE_ON_INSTANCE_UPLOAD_IN_PROGRESS")]
      AvailableOnInstanceUploadInProgress
  }
}
