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


namespace Oci.OsmanagementService.Models
{
    /// <summary>
    /// The set of changes to make to the state of the modules, streams, and profiles on a managed instance
    /// </summary>
    public class ManageModuleStreamsOnManagedInstanceDetails 
    {
        
        /// <value>
        /// Indicates if this operation is a dry run or if the operation
        /// should be commited.  If set to true, the result of the operation
        /// will be evaluated but not committed.  If set to false, the
        /// operation is committed to the managed instance.  The default is
        /// false.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDryRun")]
        public System.Nullable<bool> IsDryRun { get; set; }
        
        /// <value>
        /// The set of module streams to enable.
        /// </value>
        [JsonProperty(PropertyName = "enable")]
        public System.Collections.Generic.List<ModuleStreamDetails> Enable { get; set; }
        
        /// <value>
        /// The set of module streams to disable.
        /// </value>
        [JsonProperty(PropertyName = "disable")]
        public System.Collections.Generic.List<ModuleStreamDetails> Disable { get; set; }
        
        /// <value>
        /// The set of module stream profiles to install.
        /// </value>
        [JsonProperty(PropertyName = "install")]
        public System.Collections.Generic.List<ModuleStreamProfileDetails> Install { get; set; }
        
        /// <value>
        /// The set of module stream profiles to remove.
        /// </value>
        [JsonProperty(PropertyName = "remove")]
        public System.Collections.Generic.List<ModuleStreamProfileDetails> Remove { get; set; }
        
    }
}
