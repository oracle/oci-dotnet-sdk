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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Provides summary information for a software package available for installation on a managed instance.
    /// </summary>
    public class UpdatablePackageSummary : PackageSummary
    {
        
        /// <value>
        /// The version of the package that is currently installed on the instance.
        /// </value>
        [JsonProperty(PropertyName = "installedVersion")]
        public string InstalledVersion { get; set; }
        
        /// <value>
        /// The type of update.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UpdateType is required.")]
        [JsonProperty(PropertyName = "updateType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ClassificationTypes> UpdateType { get; set; }
        
        /// <value>
        /// List of errata applicable to this update.
        /// </value>
        [JsonProperty(PropertyName = "errata")]
        public System.Collections.Generic.List<string> Errata { get; set; }
        
        /// <value>
        /// List of CVEs applicable to this erratum.
        /// </value>
        [JsonProperty(PropertyName = "relatedCves")]
        public System.Collections.Generic.List<string> RelatedCves { get; set; }
        
        [JsonProperty(PropertyName = "packageClassification")]
        private readonly string packageClassification = "UPDATABLE";
    }
}
