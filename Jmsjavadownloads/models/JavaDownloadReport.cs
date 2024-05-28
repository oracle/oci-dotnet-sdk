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


namespace Oci.JmsjavadownloadsService.Models
{
    /// <summary>
    /// Details about a Java download report in a tenancy.
    /// The report is a file in Object Storage. It contains the download records in a specific format.
    /// 
    /// </summary>
    public class JavaDownloadReport 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Java download report.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Display name for the Java download report.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The file format of the Java download report.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Format is required.")]
        [JsonProperty(PropertyName = "format")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<JavaDownloadReportFormat> Format { get; set; }
        
        /// <value>
        /// Approximate size of the Java download report file in bytes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FileSizeInBytes is required.")]
        [JsonProperty(PropertyName = "fileSizeInBytes")]
        public System.Nullable<long> FileSizeInBytes { get; set; }
        
        /// <value>
        /// The algorithm used for calculating the checksum.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ChecksumType is required.")]
        [JsonProperty(PropertyName = "checksumType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ChecksumType> ChecksumType { get; set; }
        
        /// <value>
        /// The checksum value of the Java download report file.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ChecksumValue is required.")]
        [JsonProperty(PropertyName = "checksumValue")]
        public string ChecksumValue { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the tenancy scoped to the Java download report.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CreatedBy is required.")]
        [JsonProperty(PropertyName = "createdBy")]
        public Principal CreatedBy { get; set; }
        
        /// <value>
        /// The time the Java download report was created, displayed as an [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339) formatted datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The start time from when the download records are included (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// The end time until when the download records are included (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
        
        /// <value>
        /// The property used for sorting the records.
        /// </value>
        [JsonProperty(PropertyName = "sortBy")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<JavaDownloadRecordSortBy> SortBy { get; set; }
        
        /// <value>
        /// The sort order for the records.
        /// </value>
        [JsonProperty(PropertyName = "sortOrder")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        /// <value>
        /// The current state of the Java download report.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type, or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}. (See [Managing Tags and Tag Namespaces](https://docs.cloud.oracle.com/Content/Tagging/Concepts/understandingfreeformtags.htm).)
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}. (See [Understanding Free-form Tags](https://docs.cloud.oracle.com/Content/Tagging/Tasks/managingtagsandtagnamespaces.htm)).
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// System tags can be viewed by users, but can only be created by the system.
        /// <br/>
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
