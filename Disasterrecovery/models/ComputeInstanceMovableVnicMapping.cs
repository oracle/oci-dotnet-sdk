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


namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// Source VNIC to destination subnet mapping for a movable compute instance.
    /// </summary>
    public class ComputeInstanceMovableVnicMapping 
    {
        
        /// <value>
        /// The OCID of the source VNIC.
        /// <br/>
        /// Example: ocid1.vnic.oc1..uniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceVnicId is required.")]
        [JsonProperty(PropertyName = "sourceVnicId")]
        public string SourceVnicId { get; set; }
        
        /// <value>
        /// The OCID of the destination subnet to which the source VNIC should connect.
        /// <br/>
        /// Example: ocid1.subnet.oc1..uniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DestinationSubnetId is required.")]
        [JsonProperty(PropertyName = "destinationSubnetId")]
        public string DestinationSubnetId { get; set; }
        
        /// <value>
        /// The private IP address to be assigned as the VNIC's primary IP address in the destination subnet.
        /// This must be a valid IP address in the destination subnet and the IP address must be available.
        /// <br/>
        /// Example: 10.0.3.3
        /// </value>
        [JsonProperty(PropertyName = "destinationPrimaryPrivateIpAddress")]
        public string DestinationPrimaryPrivateIpAddress { get; set; }
        
        /// <value>
        /// The hostname label to be assigned in the destination subnet for the primary private IP of the source VNIC.
        /// This label is the hostname portion of the private IP's fully qualified domain name (FQDN) 
        /// (for example, 'myhost1' in the FQDN 'myhost1.subnet123.vcn1.oraclevcn.com').
        /// <br/>
        /// Example: myhost1
        /// </value>
        [JsonProperty(PropertyName = "destinationPrimaryPrivateIpHostnameLabel")]
        public string DestinationPrimaryPrivateIpHostnameLabel { get; set; }
        
        /// <value>
        /// A list of OCIDs of network security groups (NSG) in the destination region which should be assigned to
        /// the source VNIC.
        /// <br/>
        /// Example: [ ocid1.networksecuritygroup.oc1..uniqueID, ocid1.networksecuritygroup.oc1..uniqueID ]
        /// </value>
        [JsonProperty(PropertyName = "destinationNsgIdList")]
        public System.Collections.Generic.List<string> DestinationNsgIdList { get; set; }
        
    }
}
