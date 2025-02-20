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


namespace Oci.FleetsoftwareupdateService.Models
{
    /// <summary>
    /// Type used to remove previously stored scheduled details. The Action will be executed as soon as possible
    /// after the update completes.
    /// Used during Update operations.
    /// 
    /// </summary>
    public class NoneScheduleDetails : UpdateScheduleDetails
    {
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "NONE";
    }
}
