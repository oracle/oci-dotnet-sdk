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


namespace Oci.FunctionsService.Models
{
    /// <summary>
    /// Properties to create a new function.
    /// 
    /// </summary>
    public class CreateFunctionDetails 
    {
        
        /// <value>
        /// The display name of the function. The display name must be unique within the application containing the function. Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the application this function belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApplicationId is required.")]
        [JsonProperty(PropertyName = "applicationId")]
        public string ApplicationId { get; set; }
        
        /// <value>
        /// The qualified name of the Docker image to use in the function, including the image tag.
        /// The image should be in the OCI Registry that is in the same region as the function itself.
        /// Example: phx.ocir.io/ten/functions/function:0.0.1
        /// </value>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }
        
        /// <value>
        /// The image digest for the version of the image that will be pulled when invoking this function.
        /// If no value is specified, the digest currently associated with the image in the OCI Registry will be used.
        /// Example: sha256:ca0eeb6fb05351dfc8759c20733c91def84cb8007aa89a5bf606bc8b315b9fc7
        /// </value>
        [JsonProperty(PropertyName = "imageDigest")]
        public string ImageDigest { get; set; }
        
        [JsonProperty(PropertyName = "sourceDetails")]
        public FunctionSourceDetails SourceDetails { get; set; }
        
        /// <value>
        /// Maximum usable memory for the function (MiB).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MemoryInMBs is required.")]
        [JsonProperty(PropertyName = "memoryInMBs")]
        public System.Nullable<long> MemoryInMBs { get; set; }
        
        /// <value>
        /// Function configuration. These values are passed on to the function as environment variables, this overrides application configuration values.
        /// Keys must be ASCII strings consisting solely of letters, digits, and the '_' (underscore) character, and must not begin with a digit. Values should be limited to printable unicode characters.
        /// <br/>
        /// Example: {&quot;MY_FUNCTION_CONFIG&quot;: &quot;ConfVal&quot;}The maximum size for all configuration keys and values is limited to 4KB. This is measured as the sum of octets necessary to represent each key and value in UTF-8.
        /// </value>
        [JsonProperty(PropertyName = "config")]
        public System.Collections.Generic.Dictionary<string, string> Config { get; set; }
        
        /// <value>
        /// Timeout for executions of the function. Value in seconds.
        /// </value>
        [JsonProperty(PropertyName = "timeoutInSeconds")]
        public System.Nullable<int> TimeoutInSeconds { get; set; }
        
        [JsonProperty(PropertyName = "provisionedConcurrencyConfig")]
        public FunctionProvisionedConcurrencyConfig ProvisionedConcurrencyConfig { get; set; }
        
        [JsonProperty(PropertyName = "traceConfig")]
        public FunctionTraceConfig TraceConfig { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
