/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.JmsService.Models
{
  /// <summary>
  /// The field to sort installation sites.
  /// </summary>
  public enum InstallationSiteSortBy {
      [EnumMember(Value = "managedInstanceId")]
      ManagedInstanceId,
      [EnumMember(Value = "jreDistribution")]
      JreDistribution,
      [EnumMember(Value = "jreVendor")]
      JreVendor,
      [EnumMember(Value = "jreVersion")]
      JreVersion,
      [EnumMember(Value = "path")]
      Path,
      [EnumMember(Value = "approximateApplicationCount")]
      ApproximateApplicationCount,
      [EnumMember(Value = "osName")]
      OsName,
      [EnumMember(Value = "securityStatus")]
      SecurityStatus
  }
}
