/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.AilanguageService.Models;

namespace Oci.AilanguageService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/ailanguage/DetectLanguageEntities.cs.html">here</a> to see an example of how to use DetectLanguageEntities request.
    /// </example>
    public class DetectLanguageEntitiesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The details to make a Entity detect call.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DetectLanguageEntitiesDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public DetectLanguageEntitiesDetails DetectLanguageEntitiesDetails { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// Named Entity Recognition model versions. By default user will get output from V2.1 implementation.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "modelVersion")]
        public System.Nullable<NerModelVersion> ModelVersion { get; set; }
        
        /// <value>
        /// If this parameter is set to true, you only get PII (Personally identifiable information) entities
        /// like PhoneNumber, Email, Person, and so on. Default value is false.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isPii")]
        public System.Nullable<bool> IsPii { get; set; }
    }
}
