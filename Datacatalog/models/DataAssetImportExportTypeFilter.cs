/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DatacatalogService.Models
{
  /// <summary>
  /// Type of Data Asset import and export as described below.
    /// ALL - Includes all supported elements of the data asset enumerated by the other type filters.
    /// CUSTOM_PROPERTY_VALUES - Includes custom property values set on the objects within the export scope.
    /// 
  /// </summary>
  public enum DataAssetImportExportTypeFilter {
      [EnumMember(Value = "CUSTOM_PROPERTY_VALUES")]
      CustomPropertyValues,
      [EnumMember(Value = "ALL")]
      All
  }
}
