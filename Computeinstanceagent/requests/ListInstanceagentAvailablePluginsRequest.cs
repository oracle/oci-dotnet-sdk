/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.ComputeinstanceagentService.Models;

namespace Oci.ComputeinstanceagentService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/computeinstanceagent/ListInstanceagentAvailablePlugins.cs.html">here</a> to see an example of how to use ListInstanceagentAvailablePlugins request.
    /// </example>
    public class ListInstanceagentAvailablePluginsRequest : Oci.Common.IOciRequest
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
        /// The image (OS) for the compute instance.
        /// <br/>
        /// If no match is found, all plugins are returned.
        /// <br/>
        /// Examples: `CentOS`, `Oracle Linux`, `Oracle Autonomous Linux`, `Canonical Ubuntu`, `Windows Server`
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OsName is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "osName")]
        public string OsName { get; set; }
        
        /// <value>
        /// The OS version for the instance.
        /// <br/>
        /// If no match is found, all plugins are returned.
        /// <br/>
        /// Examples: `7.9`, `8` for CentOS and Oracle Linux. `20.04`, `20.04 Minimal` for Canonical Ubuntu.
        /// `2012 R2 Datacenter`, `2019 Standard` for Windows Server.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OsVersion is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "osVersion")]
        public string OsVersion { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request,
        /// please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// For list pagination. The value of the `opc-next-page` response header from the previous \"List\"
        /// call. For important details about how pagination works, see
        /// [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// For list pagination. The maximum number of results per page, or items to return in a paginated
        /// \"List\" call. For important details about how pagination works, see
        /// [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. You can provide one sort order (`sortOrder`). Default order for
        /// `TIMECREATED` is descending.
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
        /// `TIMECREATED` is descending.
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
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`). The `DISPLAYNAME` sort order
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
        /// The sort order to use, either ascending (`ASC`) or descending (`DESC`). The `DISPLAYNAME` sort order
        /// is case sensitive.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        /// <value>
        /// The plugin name.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "name")]
        public string Name { get; set; }
    }
}
