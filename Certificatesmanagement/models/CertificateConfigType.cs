/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.CertificatesmanagementService.Models
{
  /// <summary>
  /// The manner in which the certificate was created. You can have a CA that was generated internally by the service issue a certificate. You can subsequently manage that certificate internally or externally. Alternatively, you can import a certificate that was issued by an external, third-party public or private CA, and then manage it internally.
    /// 
  /// </summary>
  public enum CertificateConfigType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "ISSUED_BY_INTERNAL_CA")]
      IssuedByInternalCa,
      [EnumMember(Value = "MANAGED_EXTERNALLY_ISSUED_BY_INTERNAL_CA")]
      ManagedExternallyIssuedByInternalCa,
      [EnumMember(Value = "IMPORTED")]
      Imported
  }
}
