/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DatacatalogService.Models
{
  /// <summary>
  /// Harvest state of the object indicates the completeness of the metadata definition of the object in the catalog.
    /// COMPLETE   - The object's metadata is harvested successfully including properties, relationships, and its children.
    /// ERROR      - There is an error during the harvest process. This could be due to failure in the harvest process, or
    ///              invalid or currupted data.
    /// IN-PROGRESS - The harvest is currently in progress. This might imply a successful shallow harvest and a deep harvest
    ///              is currently in progress.
    /// DEFERRED   - The dependencies are incomplete and the resolution of the metadata is deferred until all information
    ///              is available for the object.
    /// 
  /// </summary>
  public enum HarvestStatus {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "COMPLETE")]
      Complete,
      [EnumMember(Value = "ERROR")]
      Error,
      [EnumMember(Value = "IN_PROGRESS")]
      InProgress,
      [EnumMember(Value = "DEFERRED")]
      Deferred
  }
}
