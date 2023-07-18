/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
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
    /// The details for updating a Run Object Store Script step.
    /// 
    /// </summary>
    public class UpdateRunObjectStoreScriptUserDefinedStepDetails : UpdateDrPlanUserDefinedStepDetails
    {
        
        /// <value>
        /// The OCID of the instance where this script or command should be executed.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RunOnInstanceId is required.")]
        [JsonProperty(PropertyName = "runOnInstanceId")]
        public string RunOnInstanceId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectStorageScriptLocation is required.")]
        [JsonProperty(PropertyName = "objectStorageScriptLocation")]
        public UpdateObjectStorageScriptLocationDetails ObjectStorageScriptLocation { get; set; }
        
        [JsonProperty(PropertyName = "stepType")]
        private readonly string stepType = "RUN_OBJECTSTORE_SCRIPT";
    }
}
