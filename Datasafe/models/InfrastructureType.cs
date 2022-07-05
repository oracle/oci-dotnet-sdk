/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DatasafeService.Models
{
  /// <summary>
  /// The infrastructure type the database is running on. Allowed values are
    ///   - ORACLE_CLOUD - Represents that the database is running on the Oracle Cloud Infrastructure.
    ///   - CLOUD_AT_CUSTOMER - Represents that the database is running on Oracle Cloud@Customer infrastructure.
    ///   - ON_PREMISES - Represents that the database is running on on-premises infrastructure.
    ///   - NON_ORACLE_CLOUD - Represents that the database is running on non-Oracle cloud infrastructure.
    /// 
  /// </summary>
  public enum InfrastructureType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "ORACLE_CLOUD")]
      OracleCloud,
      [EnumMember(Value = "CLOUD_AT_CUSTOMER")]
      CloudAtCustomer,
      [EnumMember(Value = "ON_PREMISES")]
      OnPremises,
      [EnumMember(Value = "NON_ORACLE_CLOUD")]
      NonOracleCloud
  }
}
