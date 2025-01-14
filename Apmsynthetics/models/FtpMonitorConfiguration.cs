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


namespace Oci.ApmsyntheticsService.Models
{
    /// <summary>
    /// Request configuration details for the FTP monitor type.
    /// </summary>
    public class FtpMonitorConfiguration : MonitorConfiguration
    {
        
        /// <value>
        /// FTP protocol type.
        /// </value>
        [JsonProperty(PropertyName = "ftpProtocol")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<FtpProtocol> FtpProtocol { get; set; }
        
        /// <value>
        /// FTP monitor request type.
        /// </value>
        [JsonProperty(PropertyName = "ftpRequestType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<FtpRequestType> FtpRequestType { get; set; }
        
        /// <value>
        /// If enabled, Active mode will be used for the FTP connection.
        /// </value>
        [JsonProperty(PropertyName = "isActiveMode")]
        public System.Nullable<bool> IsActiveMode { get; set; }
        
        [JsonProperty(PropertyName = "ftpBasicAuthenticationDetails")]
        public BasicAuthenticationDetails FtpBasicAuthenticationDetails { get; set; }
        
        /// <value>
        /// Download size limit in Bytes, at which to stop the transfer. Maximum download size limit is 5 MiB.
        /// </value>
        [JsonProperty(PropertyName = "downloadSizeLimitInBytes")]
        public System.Nullable<int> DownloadSizeLimitInBytes { get; set; }
        
        /// <value>
        /// File upload size in Bytes, at which to stop the transfer. Maximum upload size is 5 MiB.
        /// </value>
        [JsonProperty(PropertyName = "uploadFileSizeInBytes")]
        public System.Nullable<int> UploadFileSizeInBytes { get; set; }
        
        [JsonProperty(PropertyName = "networkConfiguration")]
        public NetworkConfiguration NetworkConfiguration { get; set; }
        
        /// <value>
        /// Expected FTP response codes. For status code range, set values such as 2xx, 3xx.
        /// </value>
        [JsonProperty(PropertyName = "verifyResponseCodes")]
        public System.Collections.Generic.List<string> VerifyResponseCodes { get; set; }
        
        /// <value>
        /// Verify response content against regular expression based string.
        /// If response content does not match the verifyResponseContent value, then it will be considered a failure.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "verifyResponseContent")]
        public string VerifyResponseContent { get; set; }
        
        [JsonProperty(PropertyName = "configType")]
        private readonly string configType = "FTP_CONFIG";
    }
}
