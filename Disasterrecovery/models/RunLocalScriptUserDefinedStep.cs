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
    /// Run Local Script step details.
    /// </summary>
    public class RunLocalScriptUserDefinedStep : DrPlanUserDefinedStep
    {
        
        /// <value>
        /// The OCID of the instance where this script or command should be executed.
        /// <br/>
        /// Example: ocid1.instance.oc1.phx.&lt;unique_id&gt;
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RunOnInstanceId is required.")]
        [JsonProperty(PropertyName = "runOnInstanceId")]
        public string RunOnInstanceId { get; set; }
        
        /// <value>
        /// The region in which the instance is present.
        /// <br/>
        /// Example: us-phoenix-1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RunOnInstanceRegion is required.")]
        [JsonProperty(PropertyName = "runOnInstanceRegion")]
        public string RunOnInstanceRegion { get; set; }
        
        /// <value>
        /// The script name and arguments.
        /// <br/>
        /// Example: /usr/bin/python3 /home/opc/scripts/my_app_script.py arg1 arg2 arg3
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScriptCommand is required.")]
        [JsonProperty(PropertyName = "scriptCommand")]
        public string ScriptCommand { get; set; }
        
        /// <value>
        /// The userid on the instance to be used for executing the script or command.
        /// <br/>
        /// Example: opc
        /// </value>
        [JsonProperty(PropertyName = "runAsUser")]
        public string RunAsUser { get; set; }
        
        [JsonProperty(PropertyName = "stepType")]
        private readonly string stepType = "RUN_LOCAL_SCRIPT";
    }
}
