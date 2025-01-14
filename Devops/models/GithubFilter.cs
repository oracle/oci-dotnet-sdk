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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// The filter for GitHub events.
    /// </summary>
    public class GithubFilter : Filter
    {
                ///
        ///
        public enum EventsEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PUSH")]
            Push,
            [EnumMember(Value = "PULL_REQUEST_CREATED")]
            PullRequestCreated,
            [EnumMember(Value = "PULL_REQUEST_UPDATED")]
            PullRequestUpdated,
            [EnumMember(Value = "PULL_REQUEST_REOPENED")]
            PullRequestReopened,
            [EnumMember(Value = "PULL_REQUEST_MERGED")]
            PullRequestMerged
        };

        /// <value>
        /// The events, for example, PUSH, PULL_REQUEST_MERGE.
        /// </value>
        [JsonProperty(PropertyName = "events", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<EventsEnum> Events { get; set; }
        
        [JsonProperty(PropertyName = "include")]
        public GithubFilterAttributes Include { get; set; }
        
        [JsonProperty(PropertyName = "exclude")]
        public GithubFilterExclusionAttributes Exclude { get; set; }
        
        [JsonProperty(PropertyName = "triggerSource")]
        private readonly string triggerSource = "GITHUB";
    }
}
