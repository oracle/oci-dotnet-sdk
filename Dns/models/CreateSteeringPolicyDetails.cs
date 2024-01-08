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


namespace Oci.DnsService.Models
{
    /// <summary>
    /// The body for defining a new steering policy.
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class CreateSteeringPolicyDetails 
    {
        
        /// <value>
        /// The OCID of the compartment containing the steering policy.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly name for the steering policy. Does not have to be unique and can be changed.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The Time To Live (TTL) for responses from the steering policy, in seconds.
        /// If not specified during creation, a value of 30 seconds will be used.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ttl")]
        public System.Nullable<int> Ttl { get; set; }
        
        /// <value>
        /// The OCID of the health check monitor providing health data about the answers of the
        /// steering policy. A steering policy answer with `rdata` matching a monitored endpoint
        /// will use the health data of that endpoint. A steering policy answer with `rdata` not
        /// matching any monitored endpoint will be assumed healthy.
        /// <br/>
        /// 
        /// **Note:** To use the Health Check monitoring feature in a steering policy, a monitor
        /// must be created using the Health Checks service first. For more information on how to
        /// create a monitor, please see [Managing Health Checks](https://docs.cloud.oracle.com/iaas/Content/HealthChecks/Tasks/managinghealthchecks.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "healthCheckMonitorId")]
        public string HealthCheckMonitorId { get; set; }
                ///
        /// <value>
        /// A set of predefined rules based on the desired purpose of the steering policy. Each
        /// template utilizes Traffic Management's rules in a different order to produce the desired
        /// results when answering DNS queries.
        /// <br/>
        /// 
        /// **Example: ** The FAILOVER template determines answers by filtering the policy's answersusing the FILTER rule first, then the following rules in succession: HEALTH, PRIORITY,and LIMIT. This gives the domain dynamic failover capability.It is **strongly recommended** to use a template other than CUSTOM when creatinga steering policy.All templates require the rule order to begin with an unconditional FILTER rule that keepsanswers contingent upon answer.isDisabled != true, except for CUSTOM. A definedHEALTH rule must follow the FILTER rule if the policy references a healthCheckMonitorId.The last rule of a template must must be a LIMIT rule. For more information about templatesand code examples, see [Traffic Management API Guide](https://docs.cloud.oracle.com/iaas/Content/TrafficManagement/Concepts/trafficmanagementapi.htm).**Template Types*** FAILOVER - Uses health check information on your endpoints to determine which DNS answersto serve. If an endpoint fails a health check, the answer for that endpoint will be removedfrom the list of available answers until the endpoint is detected as healthy.* LOAD_BALANCE - Distributes web traffic to specified endpoints based on defined weights.* ROUTE_BY_GEO - Answers DNS queries based on the query's geographic location. For a list of geographiclocations to route by, see [Traffic Management Geographic Locations](https://docs.cloud.oracle.com/iaas/Content/TrafficManagement/Reference/trafficmanagementgeo.htm).* ROUTE_BY_ASN - Answers DNS queries based on the query's originating ASN.* ROUTE_BY_IP - Answers DNS queries based on the query's IP address.* CUSTOM - Allows a customized configuration of rules.
        /// </value>
        ///
        public enum TemplateEnum {
            [EnumMember(Value = "FAILOVER")]
            Failover,
            [EnumMember(Value = "LOAD_BALANCE")]
            LoadBalance,
            [EnumMember(Value = "ROUTE_BY_GEO")]
            RouteByGeo,
            [EnumMember(Value = "ROUTE_BY_ASN")]
            RouteByAsn,
            [EnumMember(Value = "ROUTE_BY_IP")]
            RouteByIp,
            [EnumMember(Value = "CUSTOM")]
            Custom
        };

        /// <value>
        /// A set of predefined rules based on the desired purpose of the steering policy. Each
        /// template utilizes Traffic Management's rules in a different order to produce the desired
        /// results when answering DNS queries.
        /// <br/>
        /// 
        /// **Example: ** The FAILOVER template determines answers by filtering the policy's answersusing the FILTER rule first, then the following rules in succession: HEALTH, PRIORITY,and LIMIT. This gives the domain dynamic failover capability.It is **strongly recommended** to use a template other than CUSTOM when creatinga steering policy.All templates require the rule order to begin with an unconditional FILTER rule that keepsanswers contingent upon answer.isDisabled != true, except for CUSTOM. A definedHEALTH rule must follow the FILTER rule if the policy references a healthCheckMonitorId.The last rule of a template must must be a LIMIT rule. For more information about templatesand code examples, see [Traffic Management API Guide](https://docs.cloud.oracle.com/iaas/Content/TrafficManagement/Concepts/trafficmanagementapi.htm).**Template Types*** FAILOVER - Uses health check information on your endpoints to determine which DNS answersto serve. If an endpoint fails a health check, the answer for that endpoint will be removedfrom the list of available answers until the endpoint is detected as healthy.* LOAD_BALANCE - Distributes web traffic to specified endpoints based on defined weights.* ROUTE_BY_GEO - Answers DNS queries based on the query's geographic location. For a list of geographiclocations to route by, see [Traffic Management Geographic Locations](https://docs.cloud.oracle.com/iaas/Content/TrafficManagement/Reference/trafficmanagementgeo.htm).* ROUTE_BY_ASN - Answers DNS queries based on the query's originating ASN.* ROUTE_BY_IP - Answers DNS queries based on the query's IP address.* CUSTOM - Allows a customized configuration of rules.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Template is required.")]
        [JsonProperty(PropertyName = "template")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TemplateEnum> Template { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// 
        /// **Example: ** {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// 
        /// **Example: ** {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// The set of all answers that can potentially issue from the steering policy.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "answers")]
        public System.Collections.Generic.List<SteeringPolicyAnswer> Answers { get; set; }
        
        /// <value>
        /// The series of rules that will be processed in sequence to reduce the pool of answers
        /// to a response for any given request.
        /// <br/>
        /// 
        /// The first rule receives a shuffled list of all answers, and every other rule receives
        /// the list of answers emitted by the one preceding it. The last rule populates the
        /// response.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "rules")]
        public System.Collections.Generic.List<SteeringPolicyRule> Rules { get; set; }
        
    }
}
