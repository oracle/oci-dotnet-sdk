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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Provides the information used to update a scheduled job.
    /// </summary>
    public class UpdateScheduledJobDetails 
    {
        
        /// <value>
        /// User-friendly name for the scheduled job. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// User-specified description for the scheduled job. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The type of scheduling frequency for the job.
        /// </value>
        [JsonProperty(PropertyName = "scheduleType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ScheduleTypes> ScheduleType { get; set; }
        
        /// <value>
        /// The desired time of the next execution of this scheduled job (in [RFC 3339](https://tools.ietf.org/rfc/rfc3339) format).
        /// </value>
        [JsonProperty(PropertyName = "timeNextExecution")]
        public System.Nullable<System.DateTime> TimeNextExecution { get; set; }
        
        /// <value>
        /// The frequency schedule for a recurring scheduled job.
        /// </value>
        [JsonProperty(PropertyName = "recurringRule")]
        public string RecurringRule { get; set; }
        
        /// <value>
        /// The list of operations this scheduled job needs to perform.
        /// A scheduled job supports only one operation type, unless it is one of the following:
        /// * UPDATE_PACKAGES
        /// * UPDATE_ALL
        /// * UPDATE_SECURITY
        /// * UPDATE_BUGFIX
        /// * UPDATE_ENHANCEMENT
        /// * UPDATE_OTHER
        /// * UPDATE_KSPLICE_USERSPACE
        /// * UPDATE_KSPLICE_KERNEL
        /// 
        /// </value>
        [JsonProperty(PropertyName = "operations")]
        public System.Collections.Generic.List<ScheduledJobOperation> Operations { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// The amount of time in minutes to wait until retrying the scheduled job. If set, the service will automatically
        /// retry a failed scheduled job after the interval. For example, you could set the interval to [2,5,10]. If the 
        /// initial execution of the job fails, the service waits 2 minutes and then retries. If that fails, the service 
        /// waits 5 minutes and then retries. If that fails, the service waits 10 minutes and then retries.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "retryIntervals")]
        public System.Collections.Generic.List<int> RetryIntervals { get; set; }
        
    }
}
