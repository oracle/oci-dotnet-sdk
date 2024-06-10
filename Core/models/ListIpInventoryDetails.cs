/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Required input parameters for retrieving IP Inventory data within the specified compartments of a region.
    /// 
    /// </summary>
    public class ListIpInventoryDetails 
    {
        
        /// <value>
        /// Lists the selected regions.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RegionList is required.")]
        [JsonProperty(PropertyName = "regionList")]
        public System.Collections.Generic.List<string> RegionList { get; set; }
        
        /// <value>
        /// List the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartments.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentList is required.")]
        [JsonProperty(PropertyName = "compartmentList")]
        public System.Collections.Generic.List<string> CompartmentList { get; set; }
        
        /// <value>
        /// List of selected filters.
        /// </value>
        [JsonProperty(PropertyName = "overrideFilters")]
        public System.Nullable<bool> OverrideFilters { get; set; }
        
        /// <value>
        /// The CIDR utilization of a VCN.
        /// </value>
        [JsonProperty(PropertyName = "utilization")]
        public System.Nullable<float> Utilization { get; set; }
        
        /// <value>
        /// List of overlapping VCNs.
        /// </value>
        [JsonProperty(PropertyName = "overlappingVcnsOnly")]
        public System.Nullable<bool> OverlappingVcnsOnly { get; set; }
        
        /// <value>
        /// List of IP address types used.
        /// </value>
        [JsonProperty(PropertyName = "addressTypeList")]
        public System.Collections.Generic.List<AddressType> AddressTypeList { get; set; }
                ///
        ///
        public enum ResourceTypeListEnum {
            [EnumMember(Value = "Resource")]
            Resource
        };

        /// <value>
        /// List of VCN resource types.
        /// </value>
        [JsonProperty(PropertyName = "resourceTypeList", ItemConverterType = typeof(StringEnumConverter))]
        public System.Collections.Generic.List<ResourceTypeListEnum> ResourceTypeList { get; set; }
        
        /// <value>
        /// Filters the results for the specified string.
        /// </value>
        [JsonProperty(PropertyName = "searchKeyword")]
        public string SearchKeyword { get; set; }
                ///
        /// <value>
        /// Provide the sort order (`sortOrder`) to sort the fields such as TIMECREATED in descending or descending order, and DISPLAYNAME in case sensitive.     
        /// <br/>
        /// **Note:** For some \"List\" operations (for example, `ListInstances`), sort resources by an availability domain when the resources belong to a single availability domain. 
        /// If you sort the \"List\" operations without specifying
        /// an availability domain, the resources are grouped by availability domains and then sorted.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "DISPLAYNAME")]
            Displayname,
            [EnumMember(Value = "UTILIZATION")]
            Utilization,
            [EnumMember(Value = "DNS_HOSTNAME")]
            DnsHostname,
            [EnumMember(Value = "REGION")]
            Region
        };

        /// <value>
        /// Provide the sort order (`sortOrder`) to sort the fields such as TIMECREATED in descending or descending order, and DISPLAYNAME in case sensitive.     
        /// <br/>
        /// **Note:** For some \"List\" operations (for example, `ListInstances`), sort resources by an availability domain when the resources belong to a single availability domain. 
        /// If you sort the \"List\" operations without specifying
        /// an availability domain, the resources are grouped by availability domains and then sorted.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sortBy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SortByEnum> SortBy { get; set; }
                ///
        /// <value>
        /// Specifies the sort order to use. Select either ascending (`ASC`) or descending (`DESC`) order. The DISPLAYNAME sort order
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
        /// Specifies the sort order to use. Select either ascending (`ASC`) or descending (`DESC`) order. The DISPLAYNAME sort order
        /// is case sensitive.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sortOrder")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        /// <value>
        /// Most List operations paginate results. Results are paginated for the ListInstances operations. When you call a paginated List operation, the response indicates more pages of results by including the opc-next-page header.
        /// For more information, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "paginationOffset")]
        public System.Nullable<int> PaginationOffset { get; set; }
        
        /// <value>
        /// Specifies the maximum number of results displayed per page for a paginated \"List\" call. For more information, see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// Example: 50
        /// </value>
        [JsonProperty(PropertyName = "paginationLimit")]
        public System.Nullable<int> PaginationLimit { get; set; }
        
    }
}