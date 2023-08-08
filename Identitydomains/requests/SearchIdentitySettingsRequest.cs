/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.IdentitydomainsService.Models;

namespace Oci.IdentitydomainsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/identitydomains/SearchIdentitySettings.cs.html">here</a> to see an example of how to use SearchIdentitySettings request.
    /// </example>
    public class SearchIdentitySettingsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The Authorization field value consists of credentials containing the authentication information of the user agent for the realm of the resource being requested.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "authorization")]
        public string Authorization { get; set; }
        
        /// <value>
        /// An endpoint-specific schema version number to use in the Request. Allowed version values are Earliest Version or Latest Version as specified in each REST API endpoint description, or any sequential number inbetween. All schema attributes/body parameters are a part of version 1. After version 1, any attributes added or deprecated will be tagged with the version that they were added to or deprecated in. If no version is provided, the latest schema version is returned.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "resource_type_schema_version")]
        public string ResourceTypeSchemaVersion { get; set; }
        
        /// <value>
        /// Parameters for searching IdentitySettings
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public IdentitySettingsSearchRequest IdentitySettingsSearchRequest { get; set; }
        
        /// <value>
        /// A token you supply to uniquely identify the request and provide idempotency if the request is retried. Idempotency tokens expire after 24 hours.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
        
        /// <value>
        /// The value of the `opc-next-page` response header from the previous 'List' call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The maximum number of items to return in a paginated 'List' call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
    }
}
