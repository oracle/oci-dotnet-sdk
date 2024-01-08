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


namespace Oci.MonitoringService.Models
{
    /// <summary>
    /// The request details for retrieving metric definitions. Specify optional properties to filter the returned results.
    /// Use an asterisk (&#42;) as a wildcard character, placed anywhere in the string.
    /// For example, to search for all metrics with names that begin with \"disk\", specify \"name\" as \"disk&#42;\".
    /// If no properties are specified, then all metric definitions within the request scope are returned.
    /// 
    /// </summary>
    public class ListMetricsDetails 
    {
        
        /// <value>
        /// The metric name to use when searching for metric definitions.
        /// <br/>
        /// Example: CpuUtilization
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The source service or application to use when searching for metric definitions.
        /// <br/>
        /// Example: oci_computeagent
        /// </value>
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// Resource group that you want to match. A null value returns only metric data that has no resource groups. The specified resource group must exist in the definition of the posted metric. Only one resource group can be applied per metric.
        /// A valid resourceGroup value starts with an alphabetical character and includes only alphanumeric characters, periods (.), underscores (_), hyphens (-), and dollar signs ($).
        /// <br/>
        /// Example: frontend-fleet
        /// </value>
        [JsonProperty(PropertyName = "resourceGroup")]
        public string ResourceGroup { get; set; }
        
        /// <value>
        /// Qualifiers that you want to use when searching for metric definitions.
        /// Available dimensions vary by metric namespace. Each dimension takes the form of a key-value pair.
        /// <br/>
        /// Example: &quot;resourceId&quot;: &quot;ocid1.instance.region1.phx.exampleuniqueID&quot;
        /// </value>
        [JsonProperty(PropertyName = "dimensionFilters")]
        public System.Collections.Generic.Dictionary<string, string> DimensionFilters { get; set; }
        
        /// <value>
        /// Group metrics by these fields in the response. For example, to list all metric namespaces available
        ///           in a compartment, groupBy the \"namespace\" field. Supported fields: namespace, name, resourceGroup.
        /// If `groupBy` is used, then `dimensionFilters` is ignored.
        /// <br/>
        /// Example - group by namespace:
        /// `[ \"namespace\" ]`
        /// 
        /// </value>
        [JsonProperty(PropertyName = "groupBy")]
        public System.Collections.Generic.List<string> GroupBy { get; set; }
                ///
        /// <value>
        /// The field to use when sorting returned metric definitions. Only one sorting level is provided.
        /// <br/>
        /// Example: NAMESPACE
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "NAMESPACE")]
            Namespace,
            [EnumMember(Value = "NAME")]
            Name,
            [EnumMember(Value = "RESOURCEGROUP")]
            Resourcegroup
        };

        /// <value>
        /// The field to use when sorting returned metric definitions. Only one sorting level is provided.
        /// <br/>
        /// Example: NAMESPACE
        /// </value>
        [JsonProperty(PropertyName = "sortBy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SortByEnum> SortBy { get; set; }
                ///
        /// <value>
        /// The sort order to use when sorting returned metric definitions. Ascending (ASC) or
        /// descending (DESC).
        /// <br/>
        /// Example: ASC
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use when sorting returned metric definitions. Ascending (ASC) or
        /// descending (DESC).
        /// <br/>
        /// Example: ASC
        /// </value>
        [JsonProperty(PropertyName = "sortOrder")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
    }
}
