/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Provides summary information for a software package installed on a managed instance.
    /// </summary>
    public class InstalledPackageSummary : PackageSummary
    {
        
        /// <value>
        /// The date and time the package was installed, as described in
        /// [RFC 3339](https://tools.ietf.org/rfc/rfc3339), section 14.29.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeInstalled is required.")]
        [JsonProperty(PropertyName = "timeInstalled")]
        public System.Nullable<System.DateTime> TimeInstalled { get; set; }
        
        /// <value>
        /// The date and time the package was issued by a providing erratum (in [RFC 3339](https://tools.ietf.org/rfc/rfc3339) format).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeIssued")]
        public System.Nullable<System.DateTime> TimeIssued { get; set; }
        
        [JsonProperty(PropertyName = "packageClassification")]
        private readonly string packageClassification = "INSTALLED";
    }
}
