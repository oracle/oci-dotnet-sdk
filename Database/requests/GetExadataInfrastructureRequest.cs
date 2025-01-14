/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatabaseService.Models;

namespace Oci.DatabaseService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/database/GetExadataInfrastructure.cs.html">here</a> to see an example of how to use GetExadataInfrastructure request.
    /// </example>
    public class GetExadataInfrastructureRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The Exadata infrastructure [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExadataInfrastructureId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "exadataInfrastructureId")]
        public string ExadataInfrastructureId { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        ///
        /// <value>
        /// If provided, the specified fields will be excluded in the response.
        /// </value>
        ///
        public enum ExcludedFieldsEnum {
            [EnumMember(Value = "multiRackConfigurationFile")]
            MultiRackConfigurationFile
        };

        /// <value>
        /// If provided, the specified fields will be excluded in the response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "excludedFields", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<ExcludedFieldsEnum> ExcludedFields { get; set; }
    }
}
