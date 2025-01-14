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


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// Details for detecting drift in a stack.
    /// 
    /// </summary>
    public class DetectStackDriftDetails 
    {
        
        /// <value>
        /// The list of resources in the specified stack to detect drift for. Each resource is identified by a resource address,
        /// which is a string derived from the resource type and name specified in the stack's Terraform configuration plus an optional index.
        /// For example, the resource address for the fourth Compute instance with the name \"test_instance\" is oci_core_instance.test_instance[3].
        /// For more details and examples of resource addresses, see the Terraform documentation at [Resource spec](https://www.terraform.io/docs/internals/resource-addressing.html#examples).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "resourceAddresses")]
        public System.Collections.Generic.List<string> ResourceAddresses { get; set; }
        
        /// <value>
        /// Specifies whether or not to upgrade provider versions.
        /// Within the version constraints of your Terraform configuration, use the latest versions available from the source of Terraform providers.
        /// For more information about this option, see [Dependency Lock File (terraform.io)](https://www.terraform.io/language/files/dependency-lock).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isProviderUpgradeRequired")]
        public System.Nullable<bool> IsProviderUpgradeRequired { get; set; }
        
    }
}
