/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatacatalogService.Models;

namespace Oci.DatacatalogService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datacatalog/AsynchronousExportDataAsset.cs.html">here</a> to see an example of how to use AsynchronousExportDataAsset request.
    /// </example>
    public class AsynchronousExportDataAssetRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Unique catalog identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CatalogId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "catalogId")]
        public string CatalogId { get; set; }
        
        /// <value>
        /// Unique data asset key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataAssetKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "dataAssetKey")]
        public string DataAssetKey { get; set; }
        
        /// <value>
        /// Details needed by the Data Asset export request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AsynchronousExportDataAssetDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public AsynchronousExportDataAssetDetails AsynchronousExportDataAssetDetails { get; set; }
        
        /// <value>
        /// Type of export.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExportType is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "exportType", Oci.Common.Http.CollectionFormatType.Multi)]
        public System.Collections.Generic.List<DataAssetImportExportTypeFilter> ExportType { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
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
    }
}
