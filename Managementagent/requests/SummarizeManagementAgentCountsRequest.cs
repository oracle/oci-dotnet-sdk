/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.ManagementagentService.Models;

namespace Oci.ManagementagentService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/managementagent/SummarizeManagementAgentCounts.cs.html">here</a> to see an example of how to use SummarizeManagementAgentCounts request.
    /// </example>
    public class SummarizeManagementAgentCountsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the compartment to which a request will be scoped.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The field by which to group Management Agents. Currently, only one groupBy dimension is supported at a time.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GroupBy is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "groupBy", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<ManagementAgentGroupBy> GroupBy { get; set; }
        
        /// <value>
        /// When set to true then agents that have at least one plugin deployed will be returned. When set to false only agents that have no plugins deployed will be returned.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "hasPlugins")]
        public System.Nullable<bool> HasPlugins { get; set; }
        
        /// <value>
        /// A filter to return either agents or gateway types depending upon install type selected by user. By default both install type will be returned.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "installType")]
        public System.Nullable<InstallTypes> InstallType { get; set; }
        
        /// <value>
        /// if set to true then it fetches resources for all compartments where user has access to else only on the compartment specified.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentIdInSubtree")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }
        
        /// <value>
        /// The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
