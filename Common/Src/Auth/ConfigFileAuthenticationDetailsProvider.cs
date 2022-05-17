/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.IO;
using System.Security;
using Oci.Common.Utils;
using Org.BouncyCastle.Crypto.Parameters;

namespace Oci.Common.Auth
{
    /// <summary>An authentication details provider implementation that reads all authentication information from config file.</summary>
    public class ConfigFileAuthenticationDetailsProvider : IAuthenticationDetailsProvider, IRegionProvider, IUserDelegationDetailsProvider
    {
        public Region Region
        {
            get
            {
                return (authProvider as IRegionProvider)?.Region;
            }
        }
        public string TenantId
        {
            get
            {
                if (authProvider is IUserDelegationDetailsProvider)
                {
                    return (authProvider as IUserDelegationDetailsProvider).TenantId;
                }
                else
                {
                    return (authProvider as IAuthenticationDetailsProvider)?.TenantId;
                }
            }
        }
        public string Fingerprint
        {
            get
            {
                return (authProvider as IAuthenticationDetailsProvider)?.Fingerprint;
            }
        }
        public string UserId { get { return (authProvider as IAuthenticationDetailsProvider)?.UserId; } }
        public string KeyId { get { return (authProvider as IBasicAuthenticationDetailsProvider)?.KeyId; } }
        public char[] PassPhraseCharacters { get { return (authProvider as IBasicAuthenticationDetailsProvider)?.PassPhraseCharacters; } }

        /// <summary>Constructor. Reads from the config file at default location.</summary>
        public ConfigFileAuthenticationDetailsProvider(string profile, FilePrivateKeySupplier keySupplier = null) : this(ConfigFileReader.ParseDefault(profile), keySupplier) { }

        /// <summary>Constructor. Reads from the config file at given location.</summary>
        public ConfigFileAuthenticationDetailsProvider(string configurationFilePath, string profile, FilePrivateKeySupplier keySupplier = null) : this(ConfigFileReader.Parse(configurationFilePath, profile), keySupplier) { }

        /// <summary>
        /// Constructor. Reads from a ConfigFile object.
        /// If ConfigFile specifies an instance principal authentication, auth provider will use instance principals with delegation token. Otherwise,
        /// If a FilePrivateKeySupplier is provided, it will be used to obtain private key. Otherwise,
        /// a FilePrivateKeySupplier object will be created based on information from configFile.
        /// If additional security checks on the private key file are needed, provide a FileSecurePrivateKeySupplier object.
        /// </summary>
        public ConfigFileAuthenticationDetailsProvider(ConfigFile configFile, FilePrivateKeySupplier keySupplier = null)
        {

            string authenticationType = configFile.GetValue(ConfigUtils.AUTH_TYPE_IDENTIFIER);
            if (authenticationType?.Equals(ConfigUtils.AUTH_TYPE_INSTANCE_PRINCIPAL) == true)
            {
                logger.Info("Choosing Config-Instanceprincipals authentication details provider");
                authProvider = new ConfigFileInstancePrincipalsAuthenticationDetailsProvider(configFile);
            }
            else
            {
                logger.Info("Choosing Configuration authentication details provider");
                if (keySupplier == null)
                {
                    string pemFilePath = configFile.GetValue(ConfigUtils.KEY_FILE) ?? throw new InvalidDataException($"missing {ConfigUtils.KEY_FILE} in config. {CONFIG_FILE_DEBUG_INFORMATION_LOG}");
                    SecureString passPhrase = StringUtils.StringToSecureString(configFile.GetValue(ConfigUtils.PASS_PHRASE));
                    SetupConfigFileAuthenticationDetailsProvider(configFile, new FilePrivateKeySupplier(pemFilePath, passPhrase));
                }
                else
                {
                    SetupConfigFileAuthenticationDetailsProvider(configFile, keySupplier);
                }
            }
        }
        public RsaKeyParameters GetPrivateKey()
        {
            return (authProvider as IBasicAuthenticationDetailsProvider)?.GetPrivateKey();
        }

        public string GetDelegationToken()
        {
            return (authProvider as IUserDelegationDetailsProvider)?.GetDelegationToken();
        }

        private void SetupConfigFileAuthenticationDetailsProvider(ConfigFile configFile, FilePrivateKeySupplier keySupplier)
        {
            var provider = new SimpleAuthenticationDetailsProvider();
            provider.Fingerprint = configFile.GetValue(ConfigUtils.FINGERPRINT) ?? throw new InvalidDataException($"missing {ConfigUtils.FINGERPRINT} in config. {CONFIG_FILE_DEBUG_INFORMATION_LOG}");
            provider.TenantId = configFile.GetValue(ConfigUtils.TENANCY) ?? throw new InvalidDataException($"missing {ConfigUtils.TENANCY} in config. {CONFIG_FILE_DEBUG_INFORMATION_LOG}");
            provider.UserId = configFile.GetValue(ConfigUtils.USER) ?? throw new InvalidDataException($"missing {ConfigUtils.USER} in config. {CONFIG_FILE_DEBUG_INFORMATION_LOG}");
            provider.PrivateKeySupplier = keySupplier;
            Oci.Common.Region region;
            ConfigUtils.SetRegion(configFile, out region);
            provider.Region = region;
            authProvider = provider;
        }

        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private IBasicAuthenticationDetailsProvider authProvider;

        private const string CONFIG_FILE_DEBUG_INFORMATION_LOG = "For more information about OCI configuration file and how to get required information, see https://docs.oracle.com/en-us/iaas/Content/API/Concepts/sdkconfig.htm";
    }
}
