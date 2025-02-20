/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// Days since patch release date details.
    /// If you set the policy rule by selecting this option and entering the number of days since release, Fleet Application Management calculates the number of days passed after the release date and reports the product as noncompliant if the days exceed the number provided in Days since release
    /// 
    /// </summary>
    public class PatchReleaseDateSelectionDetails : PatchSelectionDetails
    {
        
        /// <value>
        /// Days passed since patch release.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DaysSinceRelease is required.")]
        [JsonProperty(PropertyName = "daysSinceRelease")]
        public System.Nullable<int> DaysSinceRelease { get; set; }
        
        [JsonProperty(PropertyName = "selectionType")]
        private readonly string selectionType = "PATCH_RELEASE_DATE";
    }
}
