/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.IdentitydomainsService.Models
{
    /// <summary>
    /// Managed App
    /// </summary>
    public class AppExtensionManagedappApp 
    {
        
        /// <value>
        /// If true, the accounts of the application are managed through an ICF connector bundle
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "connected")]
        public System.Nullable<bool> Connected { get; set; }
        
        /// <value>
        /// If true, the managed app can be authoritative.
        /// <br/>
        /// **Added In:** 17.4.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "canBeAuthoritative")]
        public System.Nullable<bool> CanBeAuthoritative { get; set; }
        
        /// <value>
        /// If true, sync from the managed app will be performed as authoritative sync.
        /// <br/>
        /// **Added In:** 17.4.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "isAuthoritative")]
        public System.Nullable<bool> IsAuthoritative { get; set; }
        
        /// <value>
        /// If true, the managed app is an On-Premise app.
        /// <br/>
        /// **Added In:** 19.1.4
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "isOnPremiseApp")]
        public System.Nullable<bool> IsOnPremiseApp { get; set; }
        
        /// <value>
        /// If true, the managed app is a directory.
        /// <br/>
        /// **Added In:** 19.1.4
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "isDirectory")]
        public System.Nullable<bool> IsDirectory { get; set; }
        
        /// <value>
        /// If true, the managed app supports schema discovery.
        /// <br/>
        /// **Added In:** 19.1.4
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "isSchemaDiscoverySupported")]
        public System.Nullable<bool> IsSchemaDiscoverySupported { get; set; }
        
        /// <value>
        /// If true, the managed app supports schema customization.
        /// <br/>
        /// **Added In:** 19.1.4
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "isSchemaCustomizationSupported")]
        public System.Nullable<bool> IsSchemaCustomizationSupported { get; set; }
        
        /// <value>
        /// If true, sync run-time operations are enabled for this App.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "enableSync")]
        public System.Nullable<bool> EnableSync { get; set; }
        
        /// <value>
        /// If true, send sync summary as notification upon job completion.
        /// <br/>
        /// **Added In:** 20.1.3
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "enableSyncSummaryReportNotification")]
        public System.Nullable<bool> EnableSyncSummaryReportNotification { get; set; }
        
        /// <value>
        /// If true, send activation email to new users created from authoritative sync.
        /// <br/>
        /// **Added In:** 19.2.1
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "enableAuthSyncNewUserNotification")]
        public System.Nullable<bool> EnableAuthSyncNewUserNotification { get; set; }
        
        /// <value>
        /// If true, admin has granted consent to perform managed app run-time operations.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "adminConsentGranted")]
        public System.Nullable<bool> AdminConsentGranted { get; set; }
        
        /// <value>
        /// If true, the managed app requires 3-legged OAuth for authorization.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "isThreeLeggedOAuthEnabled")]
        public System.Nullable<bool> IsThreeLeggedOAuthEnabled { get; set; }
        
        /// <value>
        /// If true, indicates that Oracle Identity Cloud Service can use two-legged OAuth to connect to this ManagedApp.
        /// <br/>
        /// **Added In:** 18.2.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "isTwoLeggedOAuthEnabled")]
        public System.Nullable<bool> IsTwoLeggedOAuthEnabled { get; set; }
        
        /// <value>
        /// Three legged OAuth provider name in Oracle Identity Cloud Service.
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: true
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        /// </value>
        [JsonProperty(PropertyName = "threeLeggedOAuthProviderName")]
        public string ThreeLeggedOAuthProviderName { get; set; }
        
        /// <value>
        /// The most recent DateTime that the configuration of this App was updated. AppServices updates this timestamp whenever AppServices updates an App's configuration with respect to synchronization.
        /// <br/>
        /// **Added In:** 18.2.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: true
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: dateTime
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "syncConfigLastModified")]
        public string SyncConfigLastModified { get; set; }
        
        /// <value>
        /// If true, then the account form will be displayed in the Oracle Identity Cloud Service UI to interactively create or update an account for this App. If a value is not specified for this attribute, a default value of \\\"false\\\" will be assumed as the value for this attribute.
        /// <br/>
        /// **Added In:** 18.4.2
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - idcsSearchable: false
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: boolean
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "accountFormVisible")]
        public System.Nullable<bool> AccountFormVisible { get; set; }
        
        /// <value>
        /// IdentityBridges associated with this App
        /// <br/>
        /// **Added In:** 19.1.4
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: true
        ///  - multiValued: true
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: request
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "identityBridges")]
        public System.Collections.Generic.List<AppIdentityBridges> IdentityBridges { get; set; }
        
        [JsonProperty(PropertyName = "connectorBundle")]
        public AppConnectorBundle ConnectorBundle { get; set; }
        
        /// <value>
        /// ConnectorBundle configuration properties
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [name]
        ///  - idcsSearchable: true
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "bundleConfigurationProperties")]
        public System.Collections.Generic.List<AppBundleConfigurationProperties> BundleConfigurationProperties { get; set; }
        
        /// <value>
        /// Object classes
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [value]
        ///  - idcsSearchable: true
        ///  - multiValued: true
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "objectClasses")]
        public System.Collections.Generic.List<AppObjectClasses> ObjectClasses { get; set; }
        
        [JsonProperty(PropertyName = "bundlePoolConfiguration")]
        public AppBundlePoolConfiguration BundlePoolConfiguration { get; set; }
        
        [JsonProperty(PropertyName = "flatFileConnectorBundle")]
        public AppFlatFileConnectorBundle FlatFileConnectorBundle { get; set; }
        
        /// <value>
        /// Flat file connector bundle configuration properties
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsCompositeKey: [name]
        ///  - idcsSearchable: true
        ///  - multiValued: true
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: complex
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "flatFileBundleConfigurationProperties")]
        public System.Collections.Generic.List<AppFlatFileBundleConfigurationProperties> FlatFileBundleConfigurationProperties { get; set; }
        
        [JsonProperty(PropertyName = "threeLeggedOAuthCredential")]
        public AppThreeLeggedOAuthCredential ThreeLeggedOAuthCredential { get; set; }
        
    }
}
