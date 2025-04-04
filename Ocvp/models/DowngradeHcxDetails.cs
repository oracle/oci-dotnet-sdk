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


namespace Oci.OcvpService.Models
{
    /// <summary>
    /// The HCX on-premise license keys to be reserved when downgrading from HCX Enterprise to HCX Advanced.
    /// Downgrading from HCX Enterprise to HCX Advanced reduces the number of provided license keys from 10 to 3.
    /// 
    /// </summary>
    public class DowngradeHcxDetails 
    {
        
        /// <value>
        /// The HCX on-premise license keys to be reserved when downgrading from HCX Enterprise to HCX Advanced.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ReservingHcxOnPremiseLicenseKeys is required.")]
        [JsonProperty(PropertyName = "reservingHcxOnPremiseLicenseKeys")]
        public System.Collections.Generic.List<string> ReservingHcxOnPremiseLicenseKeys { get; set; }
        
    }
}
