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


namespace Oci.DelegateaccesscontrolService.Models
{
    /// <summary>
    /// Details of the Delegated Resource Access Request approval.
    /// </summary>
    public class ApproveDelegatedResourceAccessRequestDetails 
    {
        
        /// <value>
        /// Comment by the approver during approval.
        /// </value>
        [JsonProperty(PropertyName = "approverComment")]
        public string ApproverComment { get; set; }
        
        /// <value>
        /// Message that needs to be displayed to the operator.
        /// </value>
        [JsonProperty(PropertyName = "additionalMessage")]
        public string AdditionalMessage { get; set; }
        
        /// <value>
        /// Access start time that is actually approved by the customer in [RFC 3339](https://tools.ietf.org/html/rfc3339)timestamp format, e.g. '2020-05-22T21:10:29.600Z'.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeApprovedForAccess")]
        public System.Nullable<System.DateTime> TimeApprovedForAccess { get; set; }
        
    }
}
