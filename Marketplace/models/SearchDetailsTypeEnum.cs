/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.MarketplaceService.Models
{
  /// <summary>
  /// Possible values for the type of SearchDetails.
    /// FreeText - A request containing arbitrary text that must be present in the resource.
    /// Structured - A request that uses Search's structured query language to specify filter conditions to apply to search results.
    /// 
  /// </summary>
  public enum SearchDetailsTypeEnum {
      [EnumMember(Value = "FreeText")]
      FreeText,
      [EnumMember(Value = "Structured")]
      Structured
  }
}
