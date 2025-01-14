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


namespace Oci.WaaService.Models
{
    /// <summary>
    /// An object that specifies a compression policy for HTTP response from ENABLEMENT POINT to the client.
    /// <br/>
    /// This compression policy can be used to enable support for HTTP response compression algorithms like gzip and
    /// configure the conditions of when a compression algorithm will be used.
    /// <br/>
    /// HTTP responses will only be compressed if the client indicates support for one of the enabled compression
    /// algorithms via the \"Accept-Encoding\" request header.
    /// 
    /// </summary>
    public class ResponseCompressionPolicy 
    {
        
        [JsonProperty(PropertyName = "gzipCompression")]
        public GzipCompressionPolicy GzipCompression { get; set; }
        
    }
}
