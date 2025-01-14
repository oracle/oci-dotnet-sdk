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


namespace Oci.ArtifactsService.Models
{
    /// <summary>
    /// Container image signature metadata.
    /// </summary>
    public class ContainerImageSignature 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment in which the container repository exists.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The id of the user or principal that created the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CreatedBy is required.")]
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; set; }
        
        /// <value>
        /// The last 10 characters of the kmsKeyId, the last 10 characters of the kmsKeyVersionId, the signingAlgorithm, and the last 10 characters of the signatureId.
        /// <br/>
        /// Example: wrmz22sixa::qdwyc2ptun::SHA_256_RSA_PKCS_PSS::2vwmobasva
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the container image signature.
        /// <br/>
        /// Example: ocid1.containerimagesignature.oc1..exampleuniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the container image.
        /// <br/>
        /// Example: ocid1.containerimage.oc1..exampleuniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ImageId is required.")]
        [JsonProperty(PropertyName = "imageId")]
        public string ImageId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the kmsKeyId used to sign the container image.
        /// <br/>
        /// Example: ocid1.key.oc1..exampleuniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KmsKeyId is required.")]
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the kmsKeyVersionId used to sign the container image.
        /// <br/>
        /// Example: ocid1.keyversion.oc1..exampleuniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "KmsKeyVersionId is required.")]
        [JsonProperty(PropertyName = "kmsKeyVersionId")]
        public string KmsKeyVersionId { get; set; }
        
        /// <value>
        /// The base64 encoded signature payload that was signed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Message is required.")]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
        /// <value>
        /// The signature of the message field using the kmsKeyId, the kmsKeyVersionId, and the signingAlgorithm.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Signature is required.")]
        [JsonProperty(PropertyName = "signature")]
        public string Signature { get; set; }
                ///
        /// <value>
        /// The algorithm to be used for signing. These are the only supported signing algorithms for container images.
        /// </value>
        ///
        public enum SigningAlgorithmEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SHA_224_RSA_PKCS_PSS")]
            Sha224RsaPkcsPss,
            [EnumMember(Value = "SHA_256_RSA_PKCS_PSS")]
            Sha256RsaPkcsPss,
            [EnumMember(Value = "SHA_384_RSA_PKCS_PSS")]
            Sha384RsaPkcsPss,
            [EnumMember(Value = "SHA_512_RSA_PKCS_PSS")]
            Sha512RsaPkcsPss
        };

        /// <value>
        /// The algorithm to be used for signing. These are the only supported signing algorithms for container images.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SigningAlgorithm is required.")]
        [JsonProperty(PropertyName = "signingAlgorithm")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SigningAlgorithmEnum> SigningAlgorithm { get; set; }
        
        /// <value>
        /// An RFC 3339 timestamp indicating when the image was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
                ///
        /// <value>
        /// The current state of the container image signature.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <value>
        /// The current state of the container image signature.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FreeformTags is required.")]
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefinedTags is required.")]
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// The system tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SystemTags is required.")]
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
