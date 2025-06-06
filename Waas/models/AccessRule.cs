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
    /// A content access rule. An access rule specifies an action to take if a set of criteria is matched by a request.
    /// </summary>
    public class AccessRule 
    {
        
        /// <value>
        /// The unique name of the access rule.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The list of access rule criteria. The rule would be applied only for the requests that matched all the listed conditions.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Criteria is required.")]
        [JsonProperty(PropertyName = "criteria")]
        public System.Collections.Generic.List<AccessRuleCriteria> Criteria { get; set; }
                ///
        /// <value>
        /// The action to take when the access criteria are met for a rule. If unspecified, defaults to `ALLOW`.
        /// <br/>
        /// - **ALLOW:** Takes no action, just logs the request.
        /// <br/>
        /// - **DETECT:** Takes no action, but creates an alert for the request.
        /// <br/>
        /// - **BLOCK:** Blocks the request by returning specified response code or showing error page.
        /// <br/>
        /// - **BYPASS:** Bypasses some or all challenges.
        /// <br/>
        /// - **REDIRECT:** Redirects the request to the specified URL. These fields are required when `REDIRECT` is selected: `redirectUrl`, `redirectResponseCode`.
        /// <br/>
        /// - **SHOW_CAPTCHA:** Show a CAPTCHA Challenge page instead of the requested page.
        /// <br/>
        /// Regardless of action, no further rules are processed once a rule is matched.
        /// </value>
        ///
        public enum ActionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ALLOW")]
            Allow,
            [EnumMember(Value = "DETECT")]
            Detect,
            [EnumMember(Value = "BLOCK")]
            Block,
            [EnumMember(Value = "BYPASS")]
            Bypass,
            [EnumMember(Value = "REDIRECT")]
            Redirect,
            [EnumMember(Value = "SHOW_CAPTCHA")]
            ShowCaptcha
        };

        /// <value>
        /// The action to take when the access criteria are met for a rule. If unspecified, defaults to `ALLOW`.
        /// <br/>
        /// - **ALLOW:** Takes no action, just logs the request.
        /// <br/>
        /// - **DETECT:** Takes no action, but creates an alert for the request.
        /// <br/>
        /// - **BLOCK:** Blocks the request by returning specified response code or showing error page.
        /// <br/>
        /// - **BYPASS:** Bypasses some or all challenges.
        /// <br/>
        /// - **REDIRECT:** Redirects the request to the specified URL. These fields are required when `REDIRECT` is selected: `redirectUrl`, `redirectResponseCode`.
        /// <br/>
        /// - **SHOW_CAPTCHA:** Show a CAPTCHA Challenge page instead of the requested page.
        /// <br/>
        /// Regardless of action, no further rules are processed once a rule is matched.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Action is required.")]
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ActionEnum> Action { get; set; }
                ///
        /// <value>
        /// The method used to block requests if `action` is set to `BLOCK` and the access criteria are met. If unspecified, defaults to `SET_RESPONSE_CODE`.
        /// </value>
        ///
        public enum BlockActionEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "SET_RESPONSE_CODE")]
            SetResponseCode,
            [EnumMember(Value = "SHOW_ERROR_PAGE")]
            ShowErrorPage
        };

        /// <value>
        /// The method used to block requests if `action` is set to `BLOCK` and the access criteria are met. If unspecified, defaults to `SET_RESPONSE_CODE`.
        /// </value>
        [JsonProperty(PropertyName = "blockAction")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<BlockActionEnum> BlockAction { get; set; }
        
        /// <value>
        /// The response status code to return when `action` is set to `BLOCK`, `blockAction` is set to `SET_RESPONSE_CODE`, and the access criteria are met. If unspecified, defaults to `403`. The list of available response codes: `200`, `201`, `202`, `204`, `206`, `300`, `301`, `302`, `303`, `304`, `307`, `400`, `401`, `403`, `404`, `405`, `408`, `409`, `411`, `412`, `413`, `414`, `415`, `416`, `422`, `444`, `494`, `495`, `496`, `497`, `499`, `500`, `501`, `502`, `503`, `504`, `507`.
        /// </value>
        [JsonProperty(PropertyName = "blockResponseCode")]
        public System.Nullable<int> BlockResponseCode { get; set; }
        
        /// <value>
        /// The message to show on the error page when `action` is set to `BLOCK`, `blockAction` is set to `SHOW_ERROR_PAGE`, and the access criteria are met. If unspecified, defaults to 'Access to the website is blocked.'
        /// </value>
        [JsonProperty(PropertyName = "blockErrorPageMessage")]
        public string BlockErrorPageMessage { get; set; }
        
        /// <value>
        /// The error code to show on the error page when `action` is set to `BLOCK`, `blockAction` is set to `SHOW_ERROR_PAGE`, and the access criteria are met. If unspecified, defaults to 'Access rules'.
        /// </value>
        [JsonProperty(PropertyName = "blockErrorPageCode")]
        public string BlockErrorPageCode { get; set; }
        
        /// <value>
        /// The description text to show on the error page when `action` is set to `BLOCK`, `blockAction` is set to `SHOW_ERROR_PAGE`, and the access criteria are met. If unspecified, defaults to 'Access blocked by website owner. Please contact support.'
        /// </value>
        [JsonProperty(PropertyName = "blockErrorPageDescription")]
        public string BlockErrorPageDescription { get; set; }
                ///
        ///
        public enum BypassChallengesEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "JS_CHALLENGE")]
            JsChallenge,
            [EnumMember(Value = "DEVICE_FINGERPRINT_CHALLENGE")]
            DeviceFingerprintChallenge,
            [EnumMember(Value = "HUMAN_INTERACTION_CHALLENGE")]
            HumanInteractionChallenge,
            [EnumMember(Value = "CAPTCHA")]
            Captcha
        };

        /// <value>
        /// The list of challenges to bypass when `action` is set to `BYPASS`. If unspecified or empty, all challenges are bypassed.
        /// <br/>
        /// - **JS_CHALLENGE:** Bypasses JavaScript Challenge.
        /// <br/>
        /// - **DEVICE_FINGERPRINT_CHALLENGE:** Bypasses Device Fingerprint Challenge.
        /// <br/>
        /// - **HUMAN_INTERACTION_CHALLENGE:** Bypasses Human Interaction Challenge.
        /// <br/>
        /// - **CAPTCHA:** Bypasses CAPTCHA Challenge.
        /// </value>
        [JsonProperty(PropertyName = "bypassChallenges", ItemConverterType = typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Collections.Generic.List<BypassChallengesEnum> BypassChallenges { get; set; }
        
        /// <value>
        /// The target to which the request should be redirected, represented as a URI reference. Required when `action` is `REDIRECT`.
        /// </value>
        [JsonProperty(PropertyName = "redirectUrl")]
        public string RedirectUrl { get; set; }
                ///
        /// <value>
        /// The response status code to return when `action` is set to `REDIRECT`.
        /// <br/>
        /// - **MOVED_PERMANENTLY:** Used for designating the permanent movement of a page (numerical code - 301).
        /// <br/>
        /// - **FOUND:** Used for designating the temporary movement of a page (numerical code - 302).
        /// </value>
        ///
        public enum RedirectResponseCodeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "MOVED_PERMANENTLY")]
            MovedPermanently,
            [EnumMember(Value = "FOUND")]
            Found
        };

        /// <value>
        /// The response status code to return when `action` is set to `REDIRECT`.
        /// <br/>
        /// - **MOVED_PERMANENTLY:** Used for designating the permanent movement of a page (numerical code - 301).
        /// <br/>
        /// - **FOUND:** Used for designating the temporary movement of a page (numerical code - 302).
        /// </value>
        [JsonProperty(PropertyName = "redirectResponseCode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RedirectResponseCodeEnum> RedirectResponseCode { get; set; }
        
        /// <value>
        /// The title used when showing a CAPTCHA challenge when `action` is set to `SHOW_CAPTCHA` and the request is challenged.
        /// </value>
        [JsonProperty(PropertyName = "captchaTitle")]
        public string CaptchaTitle { get; set; }
        
        /// <value>
        /// The text to show in the header when showing a CAPTCHA challenge when `action` is set to `SHOW_CAPTCHA` and the request is challenged.
        /// </value>
        [JsonProperty(PropertyName = "captchaHeader")]
        public string CaptchaHeader { get; set; }
        
        /// <value>
        /// The text to show in the footer when showing a CAPTCHA challenge when `action` is set to `SHOW_CAPTCHA` and the request is challenged.
        /// </value>
        [JsonProperty(PropertyName = "captchaFooter")]
        public string CaptchaFooter { get; set; }
        
        /// <value>
        /// The text to show on the label of the CAPTCHA challenge submit button when `action` is set to `SHOW_CAPTCHA` and the request is challenged.
        /// </value>
        [JsonProperty(PropertyName = "captchaSubmitLabel")]
        public string CaptchaSubmitLabel { get; set; }
        
        /// <value>
        /// An object that represents an action to apply to an HTTP response headers if all rule criteria will be matched regardless of `action` value.
        /// </value>
        [JsonProperty(PropertyName = "responseHeaderManipulation")]
        public System.Collections.Generic.List<HeaderManipulationAction> ResponseHeaderManipulation { get; set; }
        
    }
}
