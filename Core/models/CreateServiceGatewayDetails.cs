/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
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
    
    public class CreateServiceGatewayDetails 
    {
        
        /// <value>
        /// The [OCID] (https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment to contain the service gateway.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
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
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The OCID of the route table the service gateway will use.
        /// <br/>
        /// If you don't specify a route table here, the service gateway is created without an associated route
        /// table. The Networking service does NOT automatically associate the attached VCN's default route table
        /// with the service gateway.
        /// <br/>
        /// For information about why you would associate a route table with a service gateway, see
        /// [Transit Routing: Private Access to Oracle Services](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/transitroutingoracleservices.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "routeTableId")]
        public string RouteTableId { get; set; }
        
        /// <value>
        /// List of the OCIDs of the {@link Service} objects to
        /// enable for the service gateway. This list can be empty if you don't want to enable any
        /// `Service` objects when you create the gateway. You can enable a `Service`
        /// object later by using either {@link #attachServiceId(AttachServiceIdRequest) attachServiceId}
        /// or {@link #updateServiceGateway(UpdateServiceGatewayRequest) updateServiceGateway}.
        /// <br/>
        /// For each enabled `Service`, make sure there's a route rule with the `Service` object's `cidrBlock`
        /// as the rule's destination and the service gateway as the rule's target. See
        /// {@link RouteTable}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Services is required.")]
        [JsonProperty(PropertyName = "services")]
        public System.Collections.Generic.List<ServiceIdRequestDetails> Services { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the VCN.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcnId is required.")]
        [JsonProperty(PropertyName = "vcnId")]
        public string VcnId { get; set; }
        
    }
}
