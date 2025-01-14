/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CoreService.Models;

namespace Oci.CoreService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/core/GetFastConnectProviderServiceKey.cs.html">here</a> to see an example of how to use GetFastConnectProviderServiceKey request.
    /// </example>
    public class GetFastConnectProviderServiceKeyRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the provider service.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProviderServiceId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "providerServiceId")]
        public string ProviderServiceId { get; set; }
        
        /// <value>
        /// The provider service key that the provider gives you when you set up a virtual circuit connection
        /// from the provider to Oracle Cloud Infrastructure. You can set up that connection and get your
        /// provider service key at the provider's website or portal. For the portal location, see the `description`
        /// attribute of the {@link FastConnectProviderService}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProviderServiceKeyName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "providerServiceKeyName")]
        public string ProviderServiceKeyName { get; set; }
    }
}
