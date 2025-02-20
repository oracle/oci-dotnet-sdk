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
    /// Product Config Category Details.
    /// Defines individual products which contribute to the applications hosting on the resources that are to be managed.
    /// 
    /// </summary>
    public class ProductConfigCategoryDetails : ConfigCategoryDetails
    {
        
        /// <value>
        /// Versions associated with the PRODUCT . 
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Versions is required.")]
        [JsonProperty(PropertyName = "versions")]
        public System.Collections.Generic.List<string> Versions { get; set; }
        
        /// <value>
        /// OCID for the Credential name to be associated with the Product.
        /// These are useful for target discovery or lifecycle management activities, for example, Oracle WebLogic admin credentials for Oracle WebLogic Application server.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "credentials")]
        public System.Collections.Generic.List<ConfigAssociationDetails> Credentials { get; set; }
        
        /// <value>
        /// Various components of the Product.
        /// For Example: The administration server or node manager can be the components of the Oracle WebLogic Application server.Forms server or concurrent manager can be the components of the Oracle E-Business Suite.
        /// </value>
        [JsonProperty(PropertyName = "components")]
        public System.Collections.Generic.List<string> Components { get; set; }
        
        /// <value>
        /// Products compatible with this Product.
        /// Provide products from the list of other products you have created that are compatible with the present one
        /// 
        /// </value>
        [JsonProperty(PropertyName = "compatibleProducts")]
        public System.Collections.Generic.List<ConfigAssociationDetails> CompatibleProducts { get; set; }
        
        /// <value>
        /// Patch Types associated with this Product.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "patchTypes")]
        public System.Collections.Generic.List<ConfigAssociationDetails> PatchTypes { get; set; }
        
        [JsonProperty(PropertyName = "configCategory")]
        private readonly string configCategory = "PRODUCT";
    }
}
