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
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/opsi/SummarizeConfigurationItems.cs.html">here</a> to see an example of how to use SummarizeConfigurationItems request.
    /// </example>
    public class SummarizeConfigurationItemsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Filter to return configuration items based on configuration type of OPSI configuration.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "opsiConfigType")]
        public System.Nullable<OpsiConfigurationType> OpsiConfigType { get; set; }
        
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
        /// Returns the configuration items filtered by applicable contexts sent in this param. By default configuration items of all applicable contexts are returned.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "configItemsApplicableContext", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<string> ConfigItemsApplicableContext { get; set; }
        
        ///
        /// <value>
        /// Specifies the fields to return in a config item summary.
        /// 
        /// </value>
        ///
        public enum ConfigItemFieldEnum {
            [EnumMember(Value = "name")]
            Name,
            [EnumMember(Value = "value")]
            Value,
            [EnumMember(Value = "defaultValue")]
            DefaultValue,
            [EnumMember(Value = "valueSourceConfig")]
            ValueSourceConfig,
            [EnumMember(Value = "metadata")]
            Metadata,
            [EnumMember(Value = "applicableContexts")]
            ApplicableContexts
        };

        /// <value>
        /// Specifies the fields to return in a config item summary.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "configItemField", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<ConfigItemFieldEnum> ConfigItemField { get; set; }
        
        /// <value>
        /// A filter to return only configuration items that match the entire name.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact
        /// Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
