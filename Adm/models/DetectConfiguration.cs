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


namespace Oci.AdmService.Models
{
    /// <summary>
    /// A configuration to define the constraints when detecting vulnerable dependencies and recommending remediations.
    /// 
    /// </summary>
    public class DetectConfiguration 
    {
        
        /// <value>
        /// The list of dependencies to be ignored by the recommendation algorithm. The dependency pattern is matched against the 'group:artifact:version' or the purl of a dependency.
        /// An asterisk (*) at the end in the dependency pattern acts as a wildcard and matches zero or more characters.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "exclusions")]
        public System.Collections.Generic.List<string> Exclusions { get; set; }
                ///
        /// <value>
        /// The upgrade policy for recommendations.
        /// The `Nearest` upgrade policy upgrades a dependency to the oldest version that meets both of the following criteria: it is newer than the current version and it is not affected by a vulnerability.
        /// 
        /// </value>
        ///
        public enum UpgradePolicyEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "NEAREST")]
            Nearest
        };

        /// <value>
        /// The upgrade policy for recommendations.
        /// The `Nearest` upgrade policy upgrades a dependency to the oldest version that meets both of the following criteria: it is newer than the current version and it is not affected by a vulnerability.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "upgradePolicy")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<UpgradePolicyEnum> UpgradePolicy { get; set; }
        
        /// <value>
        /// The maximum Common Vulnerability Scoring System Version 2 (CVSS V2) score. A vulnerability with a CVSS V2 score below this value is not considered for remediation.
        /// </value>
        [JsonProperty(PropertyName = "maxPermissibleCvssV2Score")]
        public System.Nullable<float> MaxPermissibleCvssV2Score { get; set; }
        
        /// <value>
        /// The maximum Common Vulnerability Scoring System Version 3 (CVSS V3) score. A vulnerability with a CVSS V3 score below this value is not considered for patching.
        /// </value>
        [JsonProperty(PropertyName = "maxPermissibleCvssV3Score")]
        public System.Nullable<float> MaxPermissibleCvssV3Score { get; set; }
        
        /// <value>
        /// The maximum ADM Severity. A vulnerability with an severity below this value is not considered for remediation.
        /// </value>
        [JsonProperty(PropertyName = "maxPermissibleSeverity")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ConfigSeverity> MaxPermissibleSeverity { get; set; }
        
    }
}
