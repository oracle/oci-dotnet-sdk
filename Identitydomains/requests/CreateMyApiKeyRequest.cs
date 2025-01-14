/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/identitydomains/CreateMyApiKey.cs.html">here</a> to see an example of how to use CreateMyApiKey request.
    /// </example>
    public class CreateMyApiKeyRequest : Oci.Common.IOciRequest
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
        /// MyApiKey schema.
        /// <br/>
        /// Before you specify an attribute-value in a request to create a resource, please check the **'mutability'** property of that attribute in the resource-type schema below. Clicking on an attribute-row will expand that row to show the **SCIM++ Properties** of that attribute.
        /// - Your request to create, update or replace a resource may specify in its payload a value for any attribute that is defined as *mutability:readWrite* or *mutability:writeOnly* or *mutability:immutable*:
        ///   - The SCIM APIs to create a resource will ignore silently any value that you specify for an attribute that is defined as *mutability:readOnly*.
        ///   - The SCIM APIs to update or replace a resource will fail with an error 400 Bad Request if you specify a value for an attribute that is defined as *mutability:readOnly*.
        ///   - Similarly, the SCIM APIs to update or replace a resource will fail with an error 400 Bad Request if you specify any value for an attribute that is defined as *mutability:immutable* and that already has a value in the specified resource.
        /// <br/>
        /// Also, before you use the query-parameter attributes to request specific attributes, please check the **'returned'** property of that attribute in the resource-type schema below:
        /// - Your request to read a resource (or to search a resource-type) can specify as the value of attributes any attributes that are defined as *returned:default* or *returned:request* or *returned:always*:
        ///   - If you request a specific set of attributes, the SCIM APIs to read a resource (or to search a resource-type) will return in each resource the set of attributes that you requested, as well as any attribute that is defined as *returned:always*.
        ///   - If you do not request a specific set of attributes, the SCIM APIs to read a resource (or to search a resource-type) will return in each resource the the set of attributes defined as *returned:default*, as well as any attribute that is defined as *returned:always*.
        ///   - The SCIM APIs to read a resource (or to search a resource-type) will ignore silently any request to return an attribute that is defined as *returned:never*.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public MyApiKey MyApiKey { get; set; }
        
        /// <value>
        /// A token you supply to uniquely identify the request and provide idempotency if the request is retried. Idempotency tokens expire after 24 hours.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
    }
}
