/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Threading.Tasks;
using Oci.Common.Auth;
using Oci.DatabaseService;
using Oci.DatabaseService.Requests;
using Oci.DatabaseService.Responses;

namespace Oci.Examples
{
    // This example demonstrates the use of EncryptedKeyAuthenticationDetailsProvider
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
                // EncryptedKeyAuthenticationDetailsProvider can accept profile name
                // and creates a auth provider based on config file.
                // It ensures that private key length is at least 2048,
                // private key is encrypted with a passphrase, and
                // only CBC chaining mode is allowed
                var provider = new EncryptedKeyAuthenticationDetailsProvider(OciConfigProfileName);

                // Create Database service client
                databaseClient = new DatabaseClient(provider);

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
