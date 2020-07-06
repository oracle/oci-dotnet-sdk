/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IO;
using Oci.Common.Utils;

namespace Oci.Common
{
    /// <summary>Simple implementation to read OCI configuration file.</summary>
    public class ConfigFileReader
    {
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        /// <summary>Default location of the config file.</summary>
        public static readonly string DEFAULT_FILE_PATH = Path.Combine("~", ".oci", "config");
        /// <summary>Fallback location of the config file. If and only if the DEFAULT_FILE_PATH does not exist and CONFIG_FILE_PATH_ENV_VAR_NAME is not set, this fallback location is used.</summary>
        public static readonly string FALLBACK_DEFAULT_FILE_PATH = Path.Combine("~", ".oraclebmc", "config");
        /// <summary>Environment variable name of the config file location. </summary>
        public static readonly string CONFIG_FILE_PATH_ENV_VAR_NAME = "OCI_CONFIG_FILE";

        /// <summary>
        /// Creates a new ConfigFile instance using the configuration at the default location,
        /// using the default profile.
        /// </summary>
        /// <returns>A new ConfigFile instance.</returns>
        public static ConfigFile ParseDefault()
        {
            return ParseDefault(null);
        }

        /// <summary>
        /// Creates a new ConfigFile instance using the configuration at the default location,
        /// using the given profile.
        /// </summary>
        /// <param name="profile">The profile name to load, or null if you want to load the "DEFAULT" profile.</param>
        /// <returns>A new ConfigFile instance.</returns>
        public static ConfigFile ParseDefault(string profile)
        {
            string defaultFile = FileUtils.ExpandUserHome(DEFAULT_FILE_PATH);
            // Check if config file path is set in environment variable. If available, use it as backup config file.
            var filePathEnvVar = System.Environment.GetEnvironmentVariable(CONFIG_FILE_PATH_ENV_VAR_NAME);
            string fallbackConfigFile = filePathEnvVar == null ? FileUtils.ExpandUserHome(FALLBACK_DEFAULT_FILE_PATH) : FileUtils.ExpandUserHome(filePathEnvVar);

            if (File.Exists(defaultFile) && (File.GetAttributes(defaultFile) & FileAttributes.Directory) != FileAttributes.Directory)
            {
                logger.Info($"Loading config file from: {defaultFile}");
                return Parse(defaultFile, profile);
            }
            else if (File.Exists(fallbackConfigFile) && (File.GetAttributes(fallbackConfigFile) & FileAttributes.Directory) != FileAttributes.Directory)
            {
                logger.Info($"Loading config file from: {fallbackConfigFile}");
                return Parse(fallbackConfigFile, profile);
            }
            else
            {
                throw new IOException($"Can't load the default config from '{defaultFile}' or '{fallbackConfigFile}' because it does not exist or it is not a file.");
            }
        }

        /// <summary>
        /// Creates a new ConfigFile instance using the configuration at the given location,
        /// using the DEFAULT profile.
        /// </summary>
        /// <param name="configurationFilePath"> The path to the config file.</param>
        /// <returns>A new ConfigFile instance.</returns>
        public static ConfigFile Parse(string configurationFilePath)
        {
            return Parse(configurationFilePath, null);
        }

        /// <summary>
        /// Creates a new ConfigFile instance using the configuration at the given location,
        /// using the given profile.
        /// </summary>
        /// <param name="configurationFilePath">The path to the config file.</param>
        /// <param name="profile">The profile name to load, or null if you want to load the "DEFAULT" profile.</param>
        /// <returns>A new ConfigFile instance.</returns>
        public static ConfigFile Parse(string configurationFilePath, string profile)
        {
            FileStream file = File.OpenRead(FileUtils.ExpandUserHome(configurationFilePath));
            ConfigFile configFile = Parse(file, profile);
            file.Close();
            return configFile;
        }

        /// <summary>
        /// Creates a new ConfigFile instance using an UTF-8 input stream, and the given profile.
        /// </summary>
        /// <param name="configurationStream">The config file.</param>
        /// <param name="profile">The profile name to load, or null if you want to load the "DEFAULT" profile.</param>
        /// <returns>A new ConfigFile instance.</returns>
        public static ConfigFile Parse(Stream configurationStream, string profile)
        {
            var accumulator = new ConfigFile.ConfigAccumulator();
            using (StreamReader sr = new StreamReader(configurationStream))
            {
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    accumulator.Accept(line);
                }
            }
            if (!accumulator.foundDefaultProfile)
            {
                logger.Info("No DEFAULT profile was specified in the configuration");
            }
            if (profile != null && !accumulator.configurationByProfile.ContainsKey(profile))
            {
                throw new ArgumentException($"No profile named {profile} exists in the configuration file.");
            }
            return new ConfigFile(accumulator, profile);
        }
    }
}
