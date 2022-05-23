/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.LicensemanagerService.Models
{
    /// <summary>
    /// A summary of the top utilized product licenses.
    /// 
    /// </summary>
    public class TopUtilizedProductLicenseSummary 
    {
        
        /// <value>
        /// The product license [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProductLicenseId is required.")]
        [JsonProperty(PropertyName = "productLicenseId")]
        public string ProductLicenseId { get; set; }
        
        /// <value>
        /// The product type.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProductType is required.")]
        [JsonProperty(PropertyName = "productType")]
        public string ProductType { get; set; }
        
        /// <value>
        /// The product license unit.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UnitType is required.")]
        [JsonProperty(PropertyName = "unitType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseUnit> UnitType { get; set; }
        
        /// <value>
        /// Number of license units consumed.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalUnitsConsumed is required.")]
        [JsonProperty(PropertyName = "totalUnitsConsumed")]
        public System.Double TotalUnitsConsumed { get; set; }
        
        /// <value>
        /// Total number of license units in the product license provided by the user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TotalLicenseUnitCount is required.")]
        [JsonProperty(PropertyName = "totalLicenseUnitCount")]
        public System.Nullable<int> TotalLicenseUnitCount { get; set; }
        
        /// <value>
        /// Specifies if the license unit count is unlimited.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsUnlimited is required.")]
        [JsonProperty(PropertyName = "isUnlimited")]
        public System.Nullable<bool> IsUnlimited { get; set; }
        
        /// <value>
        /// The current product license status.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<Status> Status { get; set; }
        
    }
}
