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


namespace Oci.DnsService.Models
{
    /// <summary>
    /// DNSSEC configuration data.
    /// <br/>
    /// A zone may have a maximum of 10 `DnssecKeyVersions`, regardless of signing key type.
    /// 
    /// </summary>
    public class DnssecConfig 
    {
        
        /// <value>
        /// A read-only array of key signing key (KSK) versions.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "kskDnssecKeyVersions")]
        public System.Collections.Generic.List<KskDnssecKeyVersion> KskDnssecKeyVersions { get; set; }
        
        /// <value>
        /// A read-only array of zone signing key (ZSK) versions.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "zskDnssecKeyVersions")]
        public System.Collections.Generic.List<ZskDnssecKeyVersion> ZskDnssecKeyVersions { get; set; }
        
    }
}
