/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.JmsService.Models
{
  /// <summary>
  /// list of post installation actions
  /// </summary>
  public enum PostInstallationActions {
      [EnumMember(Value = "CHANGE_MINIMUM_KEY_LENGTH_FOR_EC")]
      ChangeMinimumKeyLengthForEc,
      [EnumMember(Value = "CHANGE_MINIMUM_KEY_LENGTH_FOR_DSA")]
      ChangeMinimumKeyLengthForDsa,
      [EnumMember(Value = "CHANGE_MINIMUM_KEY_LENGTH_FOR_DIFFIE_HELLMAN")]
      ChangeMinimumKeyLengthForDiffieHellman,
      [EnumMember(Value = "CHANGE_MINIMUM_KEY_LENGTH_FOR_RSA_SIGNED_JARS")]
      ChangeMinimumKeyLengthForRsaSignedJars,
      [EnumMember(Value = "DISABLE_TLS")]
      DisableTls,
      [EnumMember(Value = "USE_OS_CACERTS")]
      UseOsCacerts
  }
}
