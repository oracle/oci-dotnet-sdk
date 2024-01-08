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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The details required to save a user assessment.
    /// </summary>
    public class CreateUserAssessmentDetails 
    {
        
        /// <value>
        /// The OCID of the compartment that contains the user assessment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The description of the user assessment.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The display name of the user assessment.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// To schedule the assessment for saving periodically, specify the schedule in this attribute.
        /// Create or schedule one assessment per compartment. If not defined, the assessment runs immediately.
        ///  Format -
        ///   <version-string>;<version-specific-schedule>
        /// <br/>
        ///   Allowed version strings - \"v1\"
        ///   v1's version specific schedule -<ss> <mm> <hh> <day-of-week> <day-of-month>
        ///   Each of the above fields potentially introduce constraints. A workrequest is created only
        ///   when clock time satisfies all the constraints. Constraints introduced:
        ///   1. seconds = <ss> (So, the allowed range for <ss> is [0, 59])
        ///   2. minutes = <mm> (So, the allowed range for <mm> is [0, 59])
        ///   3. hours = <hh> (So, the allowed range for <hh> is [0, 23])
        ///   <day-of-week> can be either '*' (without quotes or a number between 1(Monday) and 7(Sunday))
        ///   4. No constraint introduced when it is '*'. When not, day of week must equal the given value
        ///   <day-of-month> can be either '*' (without quotes or a number between 1 and 28)
        ///   5. No constraint introduced when it is '*'. When not, day of month must equal the given value
        /// 
        /// </value>
        [JsonProperty(PropertyName = "schedule")]
        public string Schedule { get; set; }
        
        /// <value>
        /// The OCID of the target database on which the user assessment is to be run.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetId is required.")]
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
