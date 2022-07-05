/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.CertificatesmanagementService.Models
{
  /// <summary>
  /// A list of possible rotation states for the certificate version. A certificate version marked `CURRENT` is currently in use. A certificate version marked `PENDING` is staged and available for use, but has not been applied on the target system and, therefore, has not been rotated
    /// into current, active use. The certificate most recently uploaded to the service is always marked `LATEST`. (The first version of a certificate is always marked as both `CURRENT` and `LATEST`.) A certificate version marked `PREVIOUS` is the certificate version that was most recently marked `CURRENT`, before the last certificate version rotation.
    /// A certificate version marked `DEPRECATED` is neither current, pending, nor the previous one in use. Only certificate versions marked `DEPRECATED` can be scheduled for deletion.
    /// 
  /// </summary>
  public enum VersionStage {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CURRENT")]
      Current,
      [EnumMember(Value = "PENDING")]
      Pending,
      [EnumMember(Value = "LATEST")]
      Latest,
      [EnumMember(Value = "PREVIOUS")]
      Previous,
      [EnumMember(Value = "DEPRECATED")]
      Deprecated,
      [EnumMember(Value = "FAILED")]
      Failed
  }
}
