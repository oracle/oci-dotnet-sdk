/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IO;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Security;
using Newtonsoft.Json;
using Oci.Common.Http.Internal;
using Oci.Common.Http.Signing;
using Oci.Common.Utils;
using Org.BouncyCastle.Crypto.Parameters;

namespace Oci.Common.Auth
{
    public class SessionTokenAuthenticationDetailsProvider : IAuthenticationDetailsProvider, IRegionProvider, IRefreshableOnNotAuthenticatedProvider<string>
    {
        public Region Region { get { return (authProvider as IRegionProvider)?.Region; } }
        public string TenantId { get { return (authProvider as IAuthenticationDetailsProvider)?.TenantId; } }
        public string Fingerprint { get { return (authProvider as IAuthenticationDetailsProvider)?.Fingerprint; } }
        public string UserId { get { return (authProvider as IAuthenticationDetailsProvider)?.UserId; } }
        public string KeyId { get { return "ST$" + this.GetSessionToken(); } }
        public char[] PassPhraseCharacters { get { return (authProvider as IBasicAuthenticationDetailsProvider)?.PassPhraseCharacters; } }
        public RsaKeyParameters GetPrivateKey() { return (authProvider as IBasicAuthenticationDetailsProvider)?.GetPrivateKey(); }

        /// <summary>
        /// Refreshes the authentication data used by the provider.
        /// </summary>
        /// <returns> The refreshed authentication data.</returns>
        public string Refresh()
        {
            skipRefresh = true;
            logger.Info("Refreshing session token");
            HttpClient client = null;
            try
            {
                var signer = new DefaultRequestSigner(this);
                client = new HttpClient();

                var url = $"{Region.FormatDefaultRegionEndpoint(new Service { ServiceName = "auth", ServiceEndpointPrefix = "auth" }, this.Region)}/v1/authentication/refresh";
                logger.Debug($"Url generated for Session Refresh:{url}");

                var httpRequest = new HttpRequestMessage(HttpMethod.Post, new Uri(url));
                var requestBody = new SessionTokenRequest(this.sessionToken);
                httpRequest.Content = ContentHelper.CreateHttpContent(requestBody);
                signer.SignRequest(httpRequest);

                var response = client.SendAsync(httpRequest).Result;
                if (response == null || !response.IsSuccessStatusCode)
                {
                    logger.Error("Received Non-successful response while trying to refresh the Session Auth token. The token may already be expired, please create a new Token!");
                    ResponseHelper.HandleNonSuccessfulResponse(response);
                }
                var securityTokenContent = response.Content.ReadAsStringAsync().Result;
                var tokenResponse = JsonConvert.DeserializeObject<SessionToken>(securityTokenContent, OciJsonSerializerSettings.GetDefaultJsonSerializerSettings());
                this.sessionToken = tokenResponse.Token;
            }
            catch (Exception ex)
            {
                logger.Error($"Refresh of SessionToken failed due to exception: {ex}");
                throw ex;
            }
            finally
            {
                client.Dispose();
                skipRefresh = false;
            }
            return sessionToken;
        }

        /// <summary>Constructor. Reads from the config file at default location.</summary>
        public SessionTokenAuthenticationDetailsProvider(string profile, FilePrivateKeySupplier keySupplier = null) : this(ConfigFileReader.ParseDefault(profile), keySupplier) { }

        /// <summary>Constructor. Reads from the config file at given location.</summary>
        public SessionTokenAuthenticationDetailsProvider(string configurationFilePath, string profile, FilePrivateKeySupplier keySupplier = null) : this(ConfigFileReader.Parse(configurationFilePath, profile), keySupplier) { }

        /// <summary>
        /// Constructor. Reads from a ConfigFile object.
        /// If a FilePrivateKeySupplier is provided, it will be used to obtain private key. Otherwise,
        /// a FilePrivateKeySupplier object will be created based on information from configFile.
        /// If additional security checks on the private key file are needed, provide a FileSecurePrivateKeySupplier object.
        /// </summary>
        public SessionTokenAuthenticationDetailsProvider(ConfigFile configFile, FilePrivateKeySupplier keySupplier = null)
        {
            logger.Info("Setting up SessionTokenAuthenticationDetailsProvider");
            if (keySupplier == null)
            {
                string pemFilePath = configFile.GetValue(ConfigUtils.KEY_FILE) ?? throw new InvalidDataException($"missing {ConfigUtils.KEY_FILE} in config. {CONFIG_FILE_DEBUG_INFORMATION_LOG}");
                SecureString passPhrase = StringUtils.StringToSecureString(configFile.GetValue(ConfigUtils.PASS_PHRASE));
                SetupSessionTokenAuthenticationDetailsProvider(configFile, new FilePrivateKeySupplier(pemFilePath, passPhrase));
            }
            else
            {
                SetupSessionTokenAuthenticationDetailsProvider(configFile, keySupplier);
            }

        }

        public SessionTokenAuthenticationDetailsProvider(SimpleAuthenticationDetailsProvider provider, string sessionToken)
        {
            if (provider.TenantId == null || provider.PrivateKeySupplier == null || provider.Region == null)
            {
                throw new ArgumentException("SimpleAuthentication provider must have a tenantId, a PrivateKeySupplier and a region for creating a SessionTokenAuthenticationDetailsProvider");
            }
            this.authProvider = provider;
            this.sessionToken = sessionToken;
        }

        private void SetupSessionTokenAuthenticationDetailsProvider(ConfigFile configFile, FilePrivateKeySupplier keySupplier)
        {
            var provider = new SimpleAuthenticationDetailsProvider();
            sessionTokenFilePath = configFile.GetValue(ConfigUtils.SESSION_TOKEN_FILE) ?? throw new InvalidDataException($"missing {ConfigUtils.SESSION_TOKEN_FILE} in config. {CONFIG_FILE_DEBUG_INFORMATION_LOG}");
            SetSessionTokenFromFilePath(sessionTokenFilePath);
            provider.TenantId = configFile.GetValue(ConfigUtils.TENANCY) ?? throw new InvalidDataException($"missing {ConfigUtils.TENANCY} in config. {CONFIG_FILE_DEBUG_INFORMATION_LOG}");
            provider.PrivateKeySupplier = keySupplier;
            ConfigUtils.SetRegion(configFile, out Region region);
            provider.Region = region;

            // Optional Parameters
            provider.Fingerprint = configFile.GetValue(ConfigUtils.FINGERPRINT);
            provider.UserId = configFile.GetValue(ConfigUtils.USER);

            authProvider = provider;
        }

        private void SetSessionTokenFromFilePath(string sessionTokenFilePath)
        {
            sessionTokenFilePath = FileUtils.ExpandUserHome(sessionTokenFilePath);
            logger.Info($"Loading session token from: {sessionTokenFilePath}");
            sessionToken = File.ReadAllText(sessionTokenFilePath);
        }

        public DateTime GetSessionTokenExpiryDate()
        {
            var handler = new JwtSecurityTokenHandler();
            var jwt = (JwtSecurityToken)handler.ReadJwtToken(sessionToken);
            return jwt.ValidTo;
        }

        public bool IsSessionTokenValid()
        {
            var expDateTime = GetSessionTokenExpiryDate();
            if (expDateTime != null && expDateTime.CompareTo(DateTime.UtcNow) > 0)
            {
                return true;
            }
            return false;
        }

        private string GetSessionToken()
        {
            return sessionToken;
        }

        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private IBasicAuthenticationDetailsProvider authProvider;
        private volatile string sessionToken;
        private bool skipRefresh = false;
        private string sessionTokenFilePath;
        private const string CONFIG_FILE_DEBUG_INFORMATION_LOG = "For more information about OCI configuration file and how to get required information, see https://docs.oracle.com/en-us/iaas/Content/API/Concepts/sdkconfig.htm";
        internal class SessionToken
        {
            public String Token { get; set; }
        }

        internal class SessionTokenRequest
        {
            public String currentToken;
            public SessionTokenRequest(string token)
            {
                this.currentToken = token;
            }
        }
    }
}