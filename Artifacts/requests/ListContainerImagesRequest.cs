/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.ArtifactsService.Models;

namespace Oci.ArtifactsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/artifacts/ListContainerImages.cs.html">here</a> to see an example of how to use ListContainerImages request.
    /// </example>
    public class ListContainerImagesRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// When set to true, the hierarchy of compartments is traversed
        /// and all compartments and subcompartments in the tenancy are
        /// inspected depending on the the setting of `accessLevel`.
        /// Default is false. Can only be set to true when calling the API
        /// on the tenancy (root compartment).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentIdInSubtree")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the given display name exactly.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A filter to return a container image summary only for the specified container image OCID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "imageId")]
        public string ImageId { get; set; }
        
        /// <value>
        /// A filter to return container images based on whether there are any associated versions.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "isVersioned")]
        public System.Nullable<bool> IsVersioned { get; set; }
        
        /// <value>
        /// A filter to return container images only for the specified container repository OCID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "repositoryId")]
        public string RepositoryId { get; set; }
        
        /// <value>
        /// A filter to return container images or container image signatures that match the repository name.
        /// <br/>
        /// Example: foo or foo*
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "repositoryName")]
        public string RepositoryName { get; set; }
        
        /// <value>
        /// A filter to return container images that match the version.
        /// <br/>
        /// Example: foo or foo*
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "version")]
        public string Version { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the given lifecycle state name exactly.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public string LifecycleState { get; set; }
        
        /// <value>
        /// For list pagination. The maximum number of results per page, or items to return in a paginated
        /// \"List\" call. For important details about how pagination works, see
        /// [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// <br/>
        /// Example: 50
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// For list pagination. The value of the `opc-next-page` response header from the previous \"List\"
        /// call. For important details about how pagination works, see
        /// [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// If you need to contact Oracle about a particular request, please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. You can provide one sort order (`sortOrder`). Default order for
        /// TIMECREATED is descending. Default order for DISPLAYNAME is ascending. The DISPLAYNAME
        /// sort order is case sensitive.
        /// <br/>
        /// **Note:** In general, some \"List\" operations (for example, `ListInstances`) let you
        /// optionally filter by availability domain if the scope of the resource type is within a
        /// single availability domain. If you call one of these \"List\" operations without specifying
        /// an availability domain, the resources are grouped by availability domain, then sorted.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "TIMECREATED")]
            Timecreated,
            [EnumMember(Value = "DISPLAYNAME")]
            Displayname
        };

        /// <value>
        /// The field to sort by. You can provide one sort order (`sortOrder`). Default order for
        /// TIMECREATED is descending. Default order for DISPLAYNAME is ascending. The DISPLAYNAME
        /// sort order is case sensitive.
        /// <br/>
        /// **Note:** In general, some \"List\" operations (for example, `ListInstances`) let you
        /// optionally filter by availability domain if the scope of the resource type is within a
        /// single availability domain. If you call one of these \"List\" operations without specifying
        /// an availability domain, the resources are grouped by availability domain, then sorted.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`). The DISPLAYNAME sort order
        /// is case sensitive.
        /// 
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`). The DISPLAYNAME sort order
        /// is case sensitive.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
    }
}
