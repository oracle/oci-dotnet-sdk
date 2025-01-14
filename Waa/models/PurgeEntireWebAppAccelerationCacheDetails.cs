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


namespace Oci.WaaService.Models
{
    /// <summary>
    /// Clears all resources from the cache of the WebAppAcceleration.
    /// </summary>
    public class PurgeEntireWebAppAccelerationCacheDetails : PurgeWebAppAccelerationCacheDetails
    {
        
        [JsonProperty(PropertyName = "purgeType")]
        private readonly string purgeType = "ENTIRE_CACHE";
    }
}
