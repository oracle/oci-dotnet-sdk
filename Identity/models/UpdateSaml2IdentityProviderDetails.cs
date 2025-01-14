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


namespace Oci.IdentityService.Models
{
    
    public class UpdateSaml2IdentityProviderDetails : UpdateIdentityProviderDetails
    {
        
        /// <value>
        /// The URL for retrieving the identity provider's metadata,
        /// which contains information required for federating.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "metadataUrl")]
        public string MetadataUrl { get; set; }
        
        /// <value>
        /// The XML that contains the information required for federating.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "metadata")]
        public string Metadata { get; set; }
        
        /// <value>
        /// Extra name value pairs associated with this identity provider.
        /// Example: {&quot;clientId&quot;: &quot;app_sf3kdjf3&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformAttributes")]
        public System.Collections.Generic.Dictionary<string, string> FreeformAttributes { get; set; }
        
        [JsonProperty(PropertyName = "protocol")]
        private readonly string protocol = "SAML2";
    }
}
