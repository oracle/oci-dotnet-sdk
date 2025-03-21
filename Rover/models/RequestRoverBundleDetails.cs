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


namespace Oci.RoverService.Models
{
    /// <summary>
    /// Information required by Object Storage to process a request to copy an object to another bucket.
    /// </summary>
    public class RequestRoverBundleDetails 
    {
        
        /// <value>
        /// The compartment OCID of destination compartment that the bundle will be copied to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DestinationCompartmentId is required.")]
        [JsonProperty(PropertyName = "destinationCompartmentId")]
        public string DestinationCompartmentId { get; set; }
        
        /// <value>
        /// The destination bucket name the bundle will be copied to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DestinationBucketName is required.")]
        [JsonProperty(PropertyName = "destinationBucketName")]
        public string DestinationBucketName { get; set; }
        
        /// <value>
        /// The bundle version that customer wants to upgrade to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BundleVersion is required.")]
        [JsonProperty(PropertyName = "bundleVersion")]
        public string BundleVersion { get; set; }
        
    }
}
