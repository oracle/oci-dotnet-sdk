/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatascienceService.Models;

namespace Oci.DatascienceService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/datascience/UpdateModelDefinedMetadatumArtifact.cs.html">here</a> to see an example of how to use UpdateModelDefinedMetadatumArtifact request.
    /// </example>
    public class UpdateModelDefinedMetadatumArtifactRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the model.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModelId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "modelId")]
        public string ModelId { get; set; }
        
        /// <value>
        /// The name of the model metadatum in the metadata.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MetadatumKeyName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "metadatumKeyName")]
        public string MetadatumKeyName { get; set; }
        
        /// <value>
        /// The content length of the body.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-length")]
        public System.Nullable<long> ContentLength { get; set; }
        
        /// <value>
        /// The model defined metadata artifact to upload.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModelDefinedMetadatumArtifact is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public System.IO.Stream ModelDefinedMetadatumArtifact { get; set; }
        
        /// <value>
        /// Unique Oracle assigned identifier for the request. If you need to contact Oracle about a particular request, then provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// This header allows you to specify a filename during upload. This file name is used to dispose of the file contents
        /// while downloading the file. If this optional field is not populated in the request, then the OCID of the model is used for the file
        /// name when downloading.
        /// Example: {&quot;Content-Disposition&quot;: &quot;attachment&quot;           &quot;filename&quot;=&quot;model.tar.gz&quot;           &quot;Content-Length&quot;: &quot;2347&quot;           &quot;Content-Type&quot;: &quot;application/gzip&quot;}
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-disposition")]
        public string ContentDisposition { get; set; }
        
        /// <value>
        /// For optimistic concurrency control. In the PUT or DELETE call
        /// for a resource, set the `if-match` parameter to the value of the
        /// etag from a previous GET or POST response for that resource.
        /// The resource is updated or deleted only if the `etag` you
        /// provide matches the resource's current `etag` value.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "if-match")]
        public string IfMatch { get; set; }
    }
}
