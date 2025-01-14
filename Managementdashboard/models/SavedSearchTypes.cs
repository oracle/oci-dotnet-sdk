/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.ManagementdashboardService.Models
{
  /// <summary>
  /// Determines how the saved search is displayed in a dashboard.
  /// </summary>
  public enum SavedSearchTypes {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "SEARCH_SHOW_IN_DASHBOARD")]
      SearchShowInDashboard,
      [EnumMember(Value = "SEARCH_DONT_SHOW_IN_DASHBOARD")]
      SearchDontShowInDashboard,
      [EnumMember(Value = "WIDGET_SHOW_IN_DASHBOARD")]
      WidgetShowInDashboard,
      [EnumMember(Value = "WIDGET_DONT_SHOW_IN_DASHBOARD")]
      WidgetDontShowInDashboard,
      [EnumMember(Value = "FILTER_SHOW_IN_DASHBOARD")]
      FilterShowInDashboard,
      [EnumMember(Value = "FILTER_DONT_SHOW_IN_DASHBOARD")]
      FilterDontShowInDashboard
  }
}
