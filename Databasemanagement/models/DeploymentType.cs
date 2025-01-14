/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DatabasemanagementService.Models
{
  /// <summary>
  /// A list of the supported infrastructure that can be used to deploy the database:
    /// <br/>
    /// - ONPREMISE: External infrastructure on premises.
    /// - BM: Bare metal infrastructure in Oracle Cloud.
    /// - VM: Virtual machines in Oracle Cloud.
    /// - EXADATA: Exadata infrastructure in Oracle Cloud.
    /// - EXADATA_CC: Exadata Cloud@Customer infrastructure in customer's data center.
    /// - AUTONOMOUS: Oracle Autonomous Cloud infrastructure
    /// - EXADATA_XS: Exadata Exascale on virtual infrastructure
    /// 
  /// </summary>
  public enum DeploymentType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "ONPREMISE")]
      Onpremise,
      [EnumMember(Value = "BM")]
      Bm,
      [EnumMember(Value = "VM")]
      Vm,
      [EnumMember(Value = "EXADATA")]
      Exadata,
      [EnumMember(Value = "EXADATA_CC")]
      ExadataCc,
      [EnumMember(Value = "AUTONOMOUS")]
      Autonomous,
      [EnumMember(Value = "EXADATA_XS")]
      ExadataXs
  }
}
