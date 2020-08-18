/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Security;
using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.Auth;
using Oci.DatabaseService;
using Oci.DatabaseService.Requests;
using Oci.DatabaseService.Responses;

namespace Oci.Examples
{
    // This example demonstrates the use of private key file with additional security requirements,
    // and it lists DbSystems available in the compartment.
    public class EncryptedKeyAuthenticationExample
    {
        const string OciConfigProfileName = "DEFAULT";
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        static async Task MainEncryptedKeyAuthentication(string[] args)
        {
            string compartmentId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID");
            DatabaseClient databaseClient = null;

            logger.Info("Starting example");

            try
            {
                // Instead of hardcoding the values here,
                // keyPath and passPhrase should be obtained through environment variables or
                // parameters to this function.
                // The caller is responsible for securely providing the values.
                string keyPath = "/path/to/some/api_key_with_passphrase.pem";
                char[] chars = { 's', 'o', 'm', 'e', 'p', 'a', 's', 's', 'p', 'h', 'r', 'a', 's', 'e' };
                SecureString passPhrase = new SecureString();
                foreach (char c in chars)
                {
                    passPhrase.AppendChar(c);
                }

                // Build FileSecurePrivateKeySupplier
                // It ensures that private key length is at least 2048,
                // private key is encrypted with a passphrase, and
                // only CBC chaining mode is allowed
                FileSecurePrivateKeySupplier keySupplier = new FileSecurePrivateKeySupplier(keyPath, passPhrase);

                // There are a few ways to provide config information.
                // 1. In addition to normal profile parameter, also provide the keySupplier.
                var providerFromFileAndSupplier = new ConfigFileAuthenticationDetailsProvider(OciConfigProfileName, keySupplier);
                // 2. Provide a custom config path plus keySupplier.
                var providerFromCustomFileAndSupplier = new ConfigFileAuthenticationDetailsProvider("/some/custom/path/to/config", OciConfigProfileName, keySupplier);
                // 3. Build a ConfigFile object plus keySupplier.
                ConfigFile.ConfigAccumulator accumulator = new ConfigFile.ConfigAccumulator();
                Dictionary<string, string> entries = new Dictionary<string, string>();
                entries.Add("user", "ocid1.user.oc1..somefakeuserocid");
                entries.Add("fingerprint", "somefakefingerprint");
                entries.Add("tenancy", "ocid1.tenancy.oc1..somefaketenancyocid");
                entries.Add("region", "us-phoenix-1");
                accumulator.configurationByProfile.Add(OciConfigProfileName, entries); ;
                ConfigFile configFile = new ConfigFile(accumulator, OciConfigProfileName);
                var providerFromConfigAndSupplier = new ConfigFileAuthenticationDetailsProvider(configFile, keySupplier);

                // Create Database service client with any of the authentication details providers above
                databaseClient = new DatabaseClient(providerFromFileAndSupplier);
                // databaseClient = new DatabaseClient(providerFromCustomFileAndSupplier);
                // databaseClient = new DatabaseClient(providerFromConfigAndSupplier);

                // Call ListDbSystems Operation
                ListDbSystemsRequest listDbSystemsRequest = new ListDbSystemsRequest
                {
                    CompartmentId = compartmentId
                };
                ListDbSystemsResponse listDbSystemsResponse = await databaseClient.ListDbSystems(listDbSystemsRequest);
                logger.Info($"Found {listDbSystemsResponse.Items.Count} DbSystems");
                foreach (var dbSystem in listDbSystemsResponse.Items)
                {
                    logger.Info($"DbSystem Name: {dbSystem.DisplayName}");
                }
            }
            catch (Exception e)
            {
                logger.Error($"Got exception: {e.Message}");
            }
            finally
            {
                if (databaseClient != null)
                {
                    databaseClient.Dispose();
                }
            }
            logger.Info("End Example");
        }
    }
}
