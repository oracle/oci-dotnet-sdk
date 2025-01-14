/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.LoganalyticsService.Models;

namespace Oci.LoganalyticsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/loganalytics/RegisterLookup.cs.html">here</a> to see an example of how to use RegisterLookup request.
    /// </example>
    public class RegisterLookupRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The Logging Analytics namespace used for the request.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "NamespaceName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "namespaceName")]
        public string NamespaceName { get; set; }
        
        ///
        /// <value>
        /// The lookup type.  Valid values are Lookup, Dictionary or Module.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "Lookup")]
            Lookup,
            [EnumMember(Value = "Dictionary")]
            Dictionary,
            [EnumMember(Value = "Module")]
            Module
        };

        /// <value>
        /// The lookup type.  Valid values are Lookup, Dictionary or Module.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "type")]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// file containing data for lookup creation
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RegisterLookupContentFileBody is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public System.IO.Stream RegisterLookupContentFileBody { get; set; }
        
        /// <value>
        /// A filter to return only log analytics entities whose name matches the entire name given. The match
        /// is case-insensitive.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The description for a created lookup.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The character encoding of the uploaded file.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "charEncoding")]
        public string CharEncoding { get; set; }
        
        /// <value>
        /// A flag indicating whether or not the new lookup should be hidden.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isHidden")]
        public System.Nullable<bool> IsHidden { get; set; }
        
        /// <value>
        /// A token that uniquely identifies a request so it can be retried in case of a timeout or
        /// server error without risk of executing that same action again. Retry tokens expire after 24
        /// hours, but can be invalidated before then due to conflicting operations. For example, if a resource
        /// has been deleted and purged from the system, then a retry of the original creation request
        /// might be rejected.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// A value of `100-continue` requests preliminary verification of the request method, path, and headers before the request body is sent.
        /// If no error results from such verification, the server will send a 100 (Continue) interim response to indicate readiness for the request body.
        /// The only allowed value for this parameter is \"100-Continue\" (case-insensitive).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "expect")]
        public string Expect { get; set; }
    }
}
