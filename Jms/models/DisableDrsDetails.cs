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


namespace Oci.JmsService.Models
{
    /// <summary>
    /// Details of the request to disable DRS file from active managed instance(s) in a Fleet.
    /// When the targets aren't specified, then all active managed instance(s) currently in the Fleet are selected.
    /// 
    /// </summary>
    public class DisableDrsDetails 
    {
        
        [JsonProperty(PropertyName = "manageDrsDetails")]
        public ManageDrsDetails ManageDrsDetails { get; set; }
        
    }
}
