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


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// Query Properties applicable to JMX type of collection method
    /// </summary>
    public class JmxUpdateQueryProperties : MetricExtensionUpdateQueryProperties
    {
        
        /// <value>
        /// JMX Managed Bean Query or Metric Service Table name
        /// </value>
        [JsonProperty(PropertyName = "managedBeanQuery")]
        public string ManagedBeanQuery { get; set; }
        
        /// <value>
        /// List of JMX attributes or Metric Service Table columns separated by semi-colon
        /// </value>
        [JsonProperty(PropertyName = "jmxAttributes")]
        public string JmxAttributes { get; set; }
        
        /// <value>
        /// Semi-colon separated list of key properties from Managed Bean ObjectName to be used as key metrics
        /// </value>
        [JsonProperty(PropertyName = "identityMetric")]
        public string IdentityMetric { get; set; }
        
        /// <value>
        /// Prefix for an auto generated metric, in case multiple rows with non unique key values are returned
        /// </value>
        [JsonProperty(PropertyName = "autoRowPrefix")]
        public string AutoRowPrefix { get; set; }
        
        /// <value>
        /// Indicates if Metric Service is enabled on server domain
        /// </value>
        [JsonProperty(PropertyName = "isMetricServiceEnabled")]
        public System.Nullable<bool> IsMetricServiceEnabled { get; set; }
        
        [JsonProperty(PropertyName = "collectionMethod")]
        private readonly string collectionMethod = "JMX";
    }
}
