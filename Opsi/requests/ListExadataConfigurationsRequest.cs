/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.OpsiService.Models;

namespace Oci.OpsiService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/opsi/ListExadataConfigurations.cs.html">here</a> to see an example of how to use ListExadataConfigurations request.
    /// </example>
    public class ListExadataConfigurationsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Optional list of exadata insight resource [OCIDs](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "exadataInsightId", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> ExadataInsightId { get; set; }
        
        /// <value>
        /// Filter by one or more Exadata types.
        /// Possible value are DBMACHINE, EXACS, and EXACC.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "exadataType", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> ExadataType { get; set; }
        
        /// <value>
        /// For list pagination. The maximum number of results per page, or items to
        /// return in a paginated \"List\" call.
        /// For important details about how pagination works, see
        /// [List Pagination](https://docs.cloud.oracle.com/Content/API/Concepts/usingapi.htm#nine).
        /// Example: 50
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// For list pagination. The value of the `opc-next-page` response header from
        /// the previous \"List\" call. For important details about how pagination works,
        /// see [List Pagination](https://docs.cloud.oracle.com/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        ///
        /// <value>
        /// Exadata configuration list sort options. If `fields` parameter is selected, the `sortBy` parameter must be one of the fields specified.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "exadataName")]
            ExadataName,
            [EnumMember(Value = "exadataDisplayName")]
            ExadataDisplayName,
            [EnumMember(Value = "exadataType")]
            ExadataType
        };

        /// <value>
        /// Exadata configuration list sort options. If `fields` parameter is selected, the `sortBy` parameter must be one of the fields specified.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// A list of tag filters to apply.  Only resources with a defined tag matching the value will be returned.
        /// Each item in the list has the format \"{namespace}.{tagName}.{value}\".  All inputs are case-insensitive.
        /// Multiple values for the same key (i.e. same namespace and tag name) are interpreted as \"OR\".
        /// Values for different keys (i.e. different namespaces, different tag names, or both) are interpreted as \"AND\".
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "definedTagEquals", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> DefinedTagEquals { get; set; }
        
        /// <value>
        /// A list of tag filters to apply.  Only resources with a freeform tag matching the value will be returned.
        /// The key for each tag is \"{tagName}.{value}\".  All inputs are case-insensitive.
        /// Multiple values for the same tag name are interpreted as \"OR\".  Values for different tag names are interpreted as \"AND\".
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "freeformTagEquals", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> FreeformTagEquals { get; set; }
        
        /// <value>
        /// A list of tag existence filters to apply.  Only resources for which the specified defined tags exist will be returned.
        /// Each item in the list has the format \"{namespace}.{tagName}.true\" (for checking existence of a defined tag)
        /// or \"{namespace}.true\".  All inputs are case-insensitive.
        /// Currently, only existence (\"true\" at the end) is supported. Absence (\"false\" at the end) is not supported.
        /// Multiple values for the same key (i.e. same namespace and tag name) are interpreted as \"OR\".
        /// Values for different keys (i.e. different namespaces, different tag names, or both) are interpreted as \"AND\".
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "definedTagExists", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> DefinedTagExists { get; set; }
        
        /// <value>
        /// A list of tag existence filters to apply.  Only resources for which the specified freeform tags exist the value will be returned.
        /// The key for each tag is \"{tagName}.true\".  All inputs are case-insensitive.
        /// Currently, only existence (\"true\" at the end) is supported. Absence (\"false\" at the end) is not supported.
        /// Multiple values for different tag names are interpreted as \"AND\".
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "freeformTagExists", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> FreeformTagExists { get; set; }
        
        /// <value>
        /// A flag to search all resources within a given compartment and all sub-compartments.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentIdInSubtree")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact
        /// Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
