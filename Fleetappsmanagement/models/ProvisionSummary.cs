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


namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// Summary information about a FamProvision.
    /// </summary>
    public class ProvisionSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the FamProvision.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A description of the provision.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProvisionDescription is required.")]
        [JsonProperty(PropertyName = "provisionDescription")]
        public string ProvisionDescription { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The date and time the FamProvision was created, in the format defined by [RFC 3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time the FamProvision was updated, in the format defined by [RFC 3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The current state of the FamProvision.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Provision.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A message that describes the current state of the FamProvision in more detail. For example,
        /// can be used to provide actionable information for a resource in the Failed state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Catalog Item.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PackageCatalogItemId is required.")]
        [JsonProperty(PropertyName = "packageCatalogItemId")]
        public string PackageCatalogItemId { get; set; }
        
        /// <value>
        /// A [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Catalog Item to a file with key/value pairs to set up variables for createStack API.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConfigCatalogItemId is required.")]
        [JsonProperty(PropertyName = "configCatalogItemId")]
        public string ConfigCatalogItemId { get; set; }
        
        /// <value>
        /// A display Name of the Catalog Item in the Catalog.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PackageCatalogItemDisplayName is required.")]
        [JsonProperty(PropertyName = "packageCatalogItemDisplayName")]
        public string PackageCatalogItemDisplayName { get; set; }
        
        /// <value>
        /// A listing ID of the Catalog Item in the Catalog.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PackageCatalogItemListingId is required.")]
        [JsonProperty(PropertyName = "packageCatalogItemListingId")]
        public string PackageCatalogItemListingId { get; set; }
        
        /// <value>
        /// A listing version of the Catalog Item in the Catalog.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PackageCatalogItemListingVersion is required.")]
        [JsonProperty(PropertyName = "packageCatalogItemListingVersion")]
        public string PackageCatalogItemListingVersion { get; set; }
        
        /// <value>
        /// A display Name of the Catalog Item in the Catalog.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConfigCatalogItemDisplayName is required.")]
        [JsonProperty(PropertyName = "configCatalogItemDisplayName")]
        public string ConfigCatalogItemDisplayName { get; set; }
        
        /// <value>
        /// A listing ID of the Catalog Item in the Catalog.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConfigCatalogItemListingId is required.")]
        [JsonProperty(PropertyName = "configCatalogItemListingId")]
        public string ConfigCatalogItemListingId { get; set; }
        
        /// <value>
        /// A listing version of the Catalog Item in the Catalog.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConfigCatalogItemListingVersion is required.")]
        [JsonProperty(PropertyName = "configCatalogItemListingVersion")]
        public string ConfigCatalogItemListingVersion { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the RMS Stack.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StackId is required.")]
        [JsonProperty(PropertyName = "stackId")]
        public string StackId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the Fleet.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FleetId is required.")]
        [JsonProperty(PropertyName = "fleetId")]
        public string FleetId { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FreeformTags is required.")]
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefinedTags is required.")]
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
