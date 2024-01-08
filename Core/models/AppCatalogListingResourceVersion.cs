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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Listing Resource Version
    /// </summary>
    public class AppCatalogListingResourceVersion 
    {
        
        /// <value>
        /// The OCID of the listing this resource version belongs to.
        /// </value>
        [JsonProperty(PropertyName = "listingId")]
        public string ListingId { get; set; }
        
        /// <value>
        /// Date and time the listing resource version was published, in [RFC3339](https://tools.ietf.org/html/rfc3339) format.
        /// Example: 2018-03-20T12:32:53.532Z
        /// </value>
        [JsonProperty(PropertyName = "timePublished")]
        public System.Nullable<System.DateTime> TimePublished { get; set; }
        
        /// <value>
        /// OCID of the listing resource.
        /// </value>
        [JsonProperty(PropertyName = "listingResourceId")]
        public string ListingResourceId { get; set; }
        
        /// <value>
        /// Resource Version.
        /// </value>
        [JsonProperty(PropertyName = "listingResourceVersion")]
        public string ListingResourceVersion { get; set; }
        
        /// <value>
        /// List of regions that this listing resource version is available.
        /// <br/>
        /// For information about regions, see
        /// [Regions and Availability Domains](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/regions.htm).
        /// <br/>
        /// Example: [&quot;us-ashburn-1&quot;, &quot;us-phoenix-1&quot;]
        /// </value>
        [JsonProperty(PropertyName = "availableRegions")]
        public System.Collections.Generic.List<string> AvailableRegions { get; set; }
        
        /// <value>
        /// Array of shapes compatible with this resource.
        /// <br/>
        /// You can enumerate all available shapes by calling {@link #listShapes(ListShapesRequest) listShapes}.
        /// <br/>
        /// Example: [&quot;VM.Standard1.1&quot;, &quot;VM.Standard1.2&quot;]
        /// </value>
        [JsonProperty(PropertyName = "compatibleShapes")]
        public System.Collections.Generic.List<string> CompatibleShapes { get; set; }
        
        /// <value>
        /// List of accessible ports for instances launched with this listing resource version.
        /// </value>
        [JsonProperty(PropertyName = "accessiblePorts")]
        public System.Collections.Generic.List<int> AccessiblePorts { get; set; }
                ///
        ///
        public enum AllowedActionsEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SNAPSHOT")]
            Snapshot,
            [EnumMember(Value = "BOOT_VOLUME_DETACH")]
            BootVolumeDetach,
            [EnumMember(Value = "PRESERVE_BOOT_VOLUME")]
            PreserveBootVolume,
            [EnumMember(Value = "SERIAL_CONSOLE_ACCESS")]
            SerialConsoleAccess,
            [EnumMember(Value = "BOOT_RECOVERY")]
            BootRecovery,
            [EnumMember(Value = "BACKUP_BOOT_VOLUME")]
            BackupBootVolume,
            [EnumMember(Value = "CAPTURE_CONSOLE_HISTORY")]
            CaptureConsoleHistory
        };

        /// <value>
        /// Allowed actions for the listing resource.
        /// </value>
        [JsonProperty(PropertyName = "allowedActions", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<AllowedActionsEnum> AllowedActions { get; set; }
        
    }
}
