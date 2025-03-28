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


namespace Oci.AuditService.Models
{
    /// <summary>
    /// A container object for request attributes.
    /// 
    /// </summary>
    public class Request 
    {
        
        /// <value>
        /// The opc-request-id of the request.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The full path of the API request.
        /// <br/>
        /// Example: /20160918/instances/ocid1.instance.oc1.phx.<unique_ID>
        /// </value>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
        
        /// <value>
        /// The HTTP method of the request.
        /// <br/>
        /// Example: GET
        /// </value>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }
        
        /// <value>
        /// The parameters supplied by the caller during this operation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> Parameters { get; set; }
        
        /// <value>
        /// The HTTP header fields and values in the request.
        /// <br/>
        /// Example:   -----    {      &quot;opc-principal&quot;: [        &quot;{\\&quot;tenantId\\&quot;:\\&quot;ocid1.tenancy.oc1..<unique_ID>\\&quot;,\\&quot;subjectId\\&quot;:\\&quot;ocid1.user.oc1..<unique_ID>\\&quot;,\\&quot;claims\\&quot;:[{\\&quot;key\\&quot;:\\&quot;pstype\\&quot;,\\&quot;value\\&quot;:\\&quot;natv\\&quot;,\\&quot;issuer\\&quot;:\\&quot;authService.oracle.com\\&quot;},{\\&quot;key\\&quot;:\\&quot;h_host\\&quot;,\\&quot;value\\&quot;:\\&quot;iaas.r2.oracleiaas.com\\&quot;,\\&quot;issuer\\&quot;:\\&quot;h\\&quot;},{\\&quot;key\\&quot;:\\&quot;h_opc-request-id\\&quot;,\\&quot;value\\&quot;:\\&quot;<unique_ID>\\&quot;,\\&quot;issuer\\&quot;:\\&quot;h\\&quot;},{\\&quot;key\\&quot;:\\&quot;ptype\\&quot;,\\&quot;value\\&quot;:\\&quot;user\\&quot;,\\&quot;issuer\\&quot;:\\&quot;authService.oracle.com\\&quot;},{\\&quot;key\\&quot;:\\&quot;h_date\\&quot;,\\&quot;value\\&quot;:\\&quot;Wed, 18 Sep 2019 00:10:58 UTC\\&quot;,\\&quot;issuer\\&quot;:\\&quot;h\\&quot;},{\\&quot;key\\&quot;:\\&quot;h_accept\\&quot;,\\&quot;value\\&quot;:\\&quot;application/json\\&quot;,\\&quot;issuer\\&quot;:\\&quot;h\\&quot;},{\\&quot;key\\&quot;:\\&quot;authorization\\&quot;,\\&quot;value\\&quot;:\\&quot;Signature headers=\\\\\\&quot;date (request-target) host accept opc-request-id\\\\\\&quot;,keyId=\\\\\\&quot;ocid1.tenancy.oc1..<unique_ID>/ocid1.user.oc1..<unique_ID>/8c:b4:5f:18:e7:ec:db:08:b8:fa:d2:2a:7d:11:76:ac\\\\\\&quot;,algorithm=\\\\\\&quot;rsa-pss-sha256\\\\\\&quot;,signature=\\\\\\&quot;<unique_ID>\\\\\\&quot;,version=\\\\\\&quot;1\\\\\\&quot;\\&quot;,\\&quot;issuer\\&quot;:\\&quot;h\\&quot;},{\\&quot;key\\&quot;:\\&quot;h_(request-target)\\&quot;,\\&quot;value\\&quot;:\\&quot;get /20160918/instances/ocid1.instance.oc1.phx.<unique_ID>\\&quot;,\\&quot;issuer\\&quot;:\\&quot;h\\&quot;}]}&quot;      ],      &quot;Accept&quot;: [        &quot;application/json&quot;      ],      &quot;X-Oracle-Auth-Client-CN&quot;: [        &quot;splat-proxy-se-02302.node.ad2.r2&quot;      ],      &quot;X-Forwarded-Host&quot;: [        &quot;compute-api.svc.ad1.r2&quot;      ],      &quot;Connection&quot;: [        &quot;close&quot;      ],      &quot;User-Agent&quot;: [        &quot;Jersey/2.23 (HttpUrlConnection 1.8.0_212)&quot;      ],      &quot;X-Forwarded-For&quot;: [        &quot;172.24.80.88&quot;      ],      &quot;X-Real-IP&quot;: [        &quot;172.24.80.88&quot;      ],      &quot;oci-original-url&quot;: [        &quot;https://iaas.r2.oracleiaas.com/20160918/instances/ocid1.instance.oc1.phx.<unique_ID>&quot;      ],      &quot;opc-request-id&quot;: [        &quot;<unique_ID>&quot;      ],      &quot;Date&quot;: [        &quot;Wed, 18 Sep 2019 00:10:58 UTC&quot;      ]    }                -----
        /// </value>
        [JsonProperty(PropertyName = "headers")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> Headers { get; set; }
        
    }
}
