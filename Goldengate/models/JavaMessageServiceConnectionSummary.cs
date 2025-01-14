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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// Summary of the Java Message Service Connection.
    /// 
    /// </summary>
    public class JavaMessageServiceConnectionSummary : ConnectionSummary
    {
        
        /// <value>
        /// The Java Message Service technology type.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TechnologyType is required.")]
        [JsonProperty(PropertyName = "technologyType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<JavaMessageServiceConnection.TechnologyTypeEnum> TechnologyType { get; set; }
        
        /// <value>
        /// If set to true, Java Naming and Directory Interface (JNDI) properties should be provided.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShouldUseJndi is required.")]
        [JsonProperty(PropertyName = "shouldUseJndi")]
        public System.Nullable<bool> ShouldUseJndi { get; set; }
        
        /// <value>
        /// The Connection Factory can be looked up using this name.
        /// e.g.: 'ConnectionFactory'
        /// 
        /// </value>
        [JsonProperty(PropertyName = "jndiConnectionFactory")]
        public string JndiConnectionFactory { get; set; }
        
        /// <value>
        /// The URL that Java Message Service will use to contact the JNDI provider.
        /// e.g.: 'tcp://myjms.host.domain:61616?jms.prefetchPolicy.all=1000'
        /// 
        /// </value>
        [JsonProperty(PropertyName = "jndiProviderUrl")]
        public string JndiProviderUrl { get; set; }
        
        /// <value>
        /// The implementation of javax.naming.spi.InitialContextFactory interface
        /// that the client uses to obtain initial naming context.
        /// e.g.: 'org.apache.activemq.jndi.ActiveMQInitialContextFactory'
        /// 
        /// </value>
        [JsonProperty(PropertyName = "jndiInitialContextFactory")]
        public string JndiInitialContextFactory { get; set; }
        
        /// <value>
        /// Specifies the identity of the principal (user) to be authenticated.
        /// e.g.: 'admin2'
        /// 
        /// </value>
        [JsonProperty(PropertyName = "jndiSecurityPrincipal")]
        public string JndiSecurityPrincipal { get; set; }
        
        /// <value>
        /// Connectin URL of the Java Message Service, specifying the protocol, host, and port.
        /// e.g.: 'mq://myjms.host.domain:7676'
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectionUrl")]
        public string ConnectionUrl { get; set; }
        
        /// <value>
        /// The of Java class implementing javax.jms.ConnectionFactory interface
        /// supplied by the Java Message Service provider.
        /// e.g.: 'com.stc.jmsjca.core.JConnectionFactoryXA'
        /// 
        /// </value>
        [JsonProperty(PropertyName = "connectionFactory")]
        public string ConnectionFactory { get; set; }
        
        /// <value>
        /// Security protocol for Java Message Service. If not provided, default is PLAIN.
        /// Optional until 2024-06-27, in the release after it will be made required.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "securityProtocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<JavaMessageServiceConnection.SecurityProtocolEnum> SecurityProtocol { get; set; }
        
        /// <value>
        /// Authentication type for Java Message Service.  If not provided, default is NONE.
        /// Optional until 2024-06-27, in the release after it will be made required.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "authenticationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<JavaMessageServiceConnection.AuthenticationTypeEnum> AuthenticationType { get; set; }
        
        /// <value>
        /// The username Oracle GoldenGate uses to connect to the Java Message Service.
        /// This username must already exist and be available by the Java Message Service to be connected to.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <value>
        /// Deprecated: this field will be removed in future versions. Either specify the private IP in the connectionString or host 
        /// field, or make sure the host name is resolvable in the target VCN.
        /// <br/>
        /// The private IP address of the connection's endpoint in the customer's VCN, typically a
        /// database endpoint or a big data endpoint (e.g. Kafka bootstrap server).
        /// In case the privateIp is provided, the subnetId must also be provided.
        /// In case the privateIp (and the subnetId) is not provided it is assumed the datasource is publicly accessible.
        /// In case the connection is accessible only privately, the lack of privateIp will result in not being able to access the connection.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateIp")]
        public string PrivateIp { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the security credentials are stored associated to the principal.
        /// Note: When provided, 'jndiSecurityCredentials' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "jndiSecurityCredentialsSecretId")]
        public string JndiSecurityCredentialsSecretId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the password is stored,
        /// that Oracle GoldenGate uses to connect the associated Java Message Service.
        /// Note: When provided, 'password' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "passwordSecretId")]
        public string PasswordSecretId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the content of the TrustStore file is stored.
        /// Note: When provided, 'trustStore' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "trustStoreSecretId")]
        public string TrustStoreSecretId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the TrustStore password is stored.
        /// Note: When provided, 'trustStorePassword' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "trustStorePasswordSecretId")]
        public string TrustStorePasswordSecretId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the content of the KeyStore file is stored.
        /// Note: When provided, 'keyStore' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "keyStoreSecretId")]
        public string KeyStoreSecretId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the KeyStore password is stored.
        /// Note: When provided, 'keyStorePassword' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "keyStorePasswordSecretId")]
        public string KeyStorePasswordSecretId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Secret where the password is stored for the cert inside of the Keystore.
        /// In case it differs from the KeyStore password, it should be provided.
        /// Note: When provided, 'sslKeyPassword' field must not be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sslKeyPasswordSecretId")]
        public string SslKeyPasswordSecretId { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "JAVA_MESSAGE_SERVICE";
    }
}
