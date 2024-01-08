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


namespace Oci.VnmonitoringService.Models
{
    
    public class CreateCrossConnectDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment to contain the cross-connect.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the cross-connect group to put this cross-connect in.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "crossConnectGroupId")]
        public string CrossConnectGroupId { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// If you already have an existing cross-connect or cross-connect group at this FastConnect
        /// location, and you want this new cross-connect to be on a different router (for the
        /// purposes of redundancy), provide the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of that existing cross-connect or
        /// cross-connect group.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "farCrossConnectOrCrossConnectGroupId")]
        public string FarCrossConnectOrCrossConnectGroupId { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The name of the FastConnect location where this cross-connect will be installed.
        /// To get a list of the available locations, see
        /// {@link #listCrossConnectLocations(ListCrossConnectLocationsRequest) listCrossConnectLocations}.
        /// <br/>
        /// Example: CyrusOne, Chandler, AZ
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LocationName is required.")]
        [JsonProperty(PropertyName = "locationName")]
        public string LocationName { get; set; }
        
        /// <value>
        /// If you already have an existing cross-connect or cross-connect group at this FastConnect
        /// location, and you want this new cross-connect to be on the same router, provide the
        /// [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of that existing cross-connect or cross-connect group.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nearCrossConnectOrCrossConnectGroupId")]
        public string NearCrossConnectOrCrossConnectGroupId { get; set; }
        
        /// <value>
        /// The port speed for this cross-connect. To get a list of the available port speeds, see
        /// {@link #listCrossconnectPortSpeedShapes(ListCrossconnectPortSpeedShapesRequest) listCrossconnectPortSpeedShapes}.
        /// <br/>
        /// Example: 10 Gbps
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PortSpeedShapeName is required.")]
        [JsonProperty(PropertyName = "portSpeedShapeName")]
        public string PortSpeedShapeName { get; set; }
        
        /// <value>
        /// A reference name or identifier for the physical fiber connection that this cross-connect
        /// uses.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "customerReferenceName")]
        public string CustomerReferenceName { get; set; }
        
        [JsonProperty(PropertyName = "macsecProperties")]
        public CreateMacsecProperties MacsecProperties { get; set; }
        
    }
}
