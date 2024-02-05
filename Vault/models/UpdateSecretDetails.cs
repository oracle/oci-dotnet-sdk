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


namespace Oci.VaultService.Models
{
    /// <summary>
    /// Details for updating a secret.
    /// </summary>
    public class UpdateSecretDetails 
    {
        
        /// <value>
        /// Details to update the secret version of the specified secret. The secret contents,
        /// version number, and rules can't be specified at the same time.
        /// Updating the secret contents automatically creates a new secret version.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "currentVersionNumber")]
        public System.Nullable<long> CurrentVersionNumber { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A brief description of the secret. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Additional metadata that you can use to provide context about how to use the secret or during rotation or
        /// other administrative tasks. For example, for a secret that you use to connect to a database, the additional
        /// metadata might specify the connection endpoint and the connection string. Provide additional metadata as key-value pairs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.Dictionary<string, System.Object> Metadata { get; set; }
        
        [JsonProperty(PropertyName = "secretContent")]
        public SecretContentDetails SecretContent { get; set; }
        
        [JsonProperty(PropertyName = "rotationConfig")]
        public RotationConfig RotationConfig { get; set; }
        
        /// <value>
        /// A list of rules to control how the secret is used and managed.
        /// </value>
        [JsonProperty(PropertyName = "secretRules")]
        public System.Collections.Generic.List<SecretRule> SecretRules { get; set; }
        
    }
}
