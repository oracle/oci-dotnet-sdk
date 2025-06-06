/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ManagementagentService.Models
{
    /// <summary>
    /// A Prometheus emitter data source.
    /// 
    /// </summary>
    public class CreatePrometheusEmitterDataSourceDetails : CreateDataSourceDetails
    {
        
        /// <value>
        /// The url through which the Prometheus Exporter publishes its metrics. (http only)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Url is required.")]
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        
        /// <value>
        /// The OCI monitoring namespace to which scraped metrics should be uploaded.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Namespace is required.")]
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// Comma separated metric name list. The complete set of desired scraped metrics. Use this property to limit the set of metrics uploaded if required.
        /// </value>
        [JsonProperty(PropertyName = "allowMetrics")]
        public string AllowMetrics { get; set; }
        
        /// <value>
        /// The url of the network proxy that provides access to the Prometheus Exporter's endpoint (url required property).
        /// </value>
        [JsonProperty(PropertyName = "proxyUrl")]
        public string ProxyUrl { get; set; }
        
        /// <value>
        /// Number in milliseconds. The timeout for connecting to the Prometheus Exporter's endpoint.
        /// </value>
        [JsonProperty(PropertyName = "connectionTimeout")]
        public System.Nullable<int> ConnectionTimeout { get; set; }
        
        /// <value>
        /// Number in milliseconds. The timeout for reading the response from the Prometheus Exporter's endpoint.
        /// </value>
        [JsonProperty(PropertyName = "readTimeout")]
        public System.Nullable<int> ReadTimeout { get; set; }
        
        /// <value>
        /// Number in kilobytes. The limit on the data being sent, not to exceed the agent's fixed limit of 400 (KB).
        /// </value>
        [JsonProperty(PropertyName = "readDataLimitInKilobytes")]
        public System.Nullable<int> ReadDataLimitInKilobytes { get; set; }
        
        /// <value>
        /// Number in minutes. The scraping occurs at the specified interval.
        /// </value>
        [JsonProperty(PropertyName = "scheduleMins")]
        public System.Nullable<int> ScheduleMins { get; set; }
        
        /// <value>
        /// OCI monitoring resource group to assign the metric to.
        /// </value>
        [JsonProperty(PropertyName = "resourceGroup")]
        public string ResourceGroup { get; set; }
        
        /// <value>
        /// The names of other user-supplied properties expressed as fixed values to be used as dimensions for every uploaded datapoint.
        /// </value>
        [JsonProperty(PropertyName = "metricDimensions")]
        public System.Collections.Generic.List<MetricDimension> MetricDimensions { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "PROMETHEUS_EMITTER";
    }
}
