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
    /// An object that defines the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) and the availability of a vendor software source.
    /// </summary>
    public class SoftwareSourceAvailability 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the vendor software source.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SoftwareSourceId is required.")]
        [JsonProperty(PropertyName = "softwareSourceId")]
        public string SoftwareSourceId { get; set; }
        
        /// <value>
        /// Availability of the software source to instances in private data centers or third-party clouds.
        /// </value>
        [JsonProperty(PropertyName = "availability")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Availability> Availability { get; set; }
        
        /// <value>
        /// Availability of the software source to OCI instances.
        /// </value>
        [JsonProperty(PropertyName = "availabilityAtOci")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Availability> AvailabilityAtOci { get; set; }
        
    }
}
