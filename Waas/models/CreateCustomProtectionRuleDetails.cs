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


namespace Oci.WaasService.Models
{
    /// <summary>
    /// The required data to create a custom protection rule.
    /// For more information about custom protection rules, see [Custom Protection Rules](https://docs.cloud.oracle.com/iaas/Content/WAF/Tasks/customprotectionrules.htm).
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// </summary>
    public class CreateCustomProtectionRuleDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment in which to create the custom protection rule.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly name for the custom protection rule.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A description for the Custom Protection rule.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The template text of the custom protection rule. All custom protection rules are expressed in ModSecurity Rule Language.
        /// <br/>
        /// Additionally, each rule must include two placeholder variables that are updated by the WAF service upon publication of the rule.
        /// <br/>
        /// `id: {{id_1}}` - This field is populated with a unique rule ID generated by the WAF service which identifies a `SecRule`. More than one `SecRule` can be defined in the `template` field of a CreateCustomSecurityRule call. The value of the first `SecRule` must be `id: {{id_1}}` and the `id` field of each subsequent `SecRule` should increase by one, as shown in the example.
        /// <br/>
        /// `ctl:ruleEngine={{mode}}` - The action to be taken when the criteria of the `SecRule` are met, either `OFF`, `DETECT` or `BLOCK`. This field is automatically populated with the corresponding value of the `action` field of the `CustomProtectionRuleSetting` schema when the `WafConfig` is updated.
        /// <br/>
        /// *Example: *    SecRule REQUEST_COOKIES &quot;regex matching SQL injection - part 1/2&quot; \\          &quot;phase:2,                                                 \\          msg:'Detects chained SQL injection attempts 1/2.',        \\          id: {{id_1}},                                             \\          ctl:ruleEngine={{mode}},                                  \\          deny&quot;  SecRule REQUEST_COOKIES &quot;regex matching SQL injection - part 2/2&quot; \\          &quot;phase:2,                                                 \\          msg:'Detects chained SQL injection attempts 2/2.',        \\          id: {{id_2}},                                             \\          ctl:ruleEngine={{mode}},                                  \\          deny&quot;  The example contains two SecRules each having distinct regex expression to match the Cookie header value during the second input analysis phase.For more information about custom protection rules, see [Custom Protection Rules](https://docs.cloud.oracle.com/Content/WAF/Tasks/customprotectionrules.htm).For more information about ModSecurity syntax, see [Making Rules: The Basic Syntax](https://www.modsecurity.org/CRS/Documentation/making.html).For more information about ModSecurity's open source WAF rules, see [Mod Security's OWASP Core Rule Set documentation](https://www.modsecurity.org/CRS/Documentation/index.html).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Template is required.")]
        [JsonProperty(PropertyName = "template")]
        public string Template { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
