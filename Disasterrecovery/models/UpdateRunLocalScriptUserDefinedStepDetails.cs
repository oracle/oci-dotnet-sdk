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
    /// The details for updating a Run Local Script step.
    /// 
    /// </summary>
    public class UpdateRunLocalScriptUserDefinedStepDetails : UpdateDrPlanUserDefinedStepDetails
    {
        
        /// <value>
        /// The OCID of the instance on which this script or command should be executed.  
        /// <br/>
        /// **For moving instances:** *runOnInstanceId* must be the OCID of the instance in the region where the 
        /// instance is currently present.  
        /// <br/>
        /// **For non-moving instances:** *runOnInstanceId* must be the OCID of the non-moving instance.  
        /// <br/>
        /// Example: ocid1.instance.oc1..uniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RunOnInstanceId is required.")]
        [JsonProperty(PropertyName = "runOnInstanceId")]
        public string RunOnInstanceId { get; set; }
        
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
