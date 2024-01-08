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
    /// Definition of a registration profile of type SoftwareSource.
    /// </summary>
    public class SoftwareSourceProfile : Profile
    {
        
        /// <value>
        /// The list of software sources that the registration profile will use.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SoftwareSources is required.")]
        [JsonProperty(PropertyName = "softwareSources")]
        public System.Collections.Generic.List<SoftwareSourceDetails> SoftwareSources { get; set; }
        
        [JsonProperty(PropertyName = "profileType")]
        private readonly string profileType = "SOFTWARESOURCE";
    }
}
