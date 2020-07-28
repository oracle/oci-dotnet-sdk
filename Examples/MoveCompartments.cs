/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.Auth;
using Oci.IdentityService;
using Oci.IdentityService.Models;
using Oci.IdentityService.Requests;
using Oci.IdentityService.Responses;

namespace Oci.Examples
{
    public class MoveCompartmentExample
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static async Task MainCompartment()
        {
            logger.Info("Starting example");
            // Create Identity Client
            var provider = new ConfigFileAuthenticationDetailsProvider("DEFAULT");
            var client = new IdentityClient(provider, new ClientConfiguration());
            logger.Info("IdentityClient created");

            try
            {
                var compartmentId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID");
                string sourceCompartmentId = await CreateCompartment(client, compartmentId, "source");
                string targetCompartmentId = await CreateCompartment(client, compartmentId, "target");
                await MoveCompartment(client, sourceCompartmentId, targetCompartmentId);
            }
            catch (Exception e)
            {
                logger.Error($"Failed to move compartments: {e}");
            }
            finally
            {
                client.Dispose();
            }
        }

        private static async Task<string> CreateCompartment(IdentityClient client, string compartmentId, string name)
        {
            CreateCompartmentDetails createCompartmentDetails = new CreateCompartmentDetails
            {
                CompartmentId = compartmentId,
                Name = name + "_dotnetSDK",
                Description = name + " compartment"
            };
            CreateCompartmentRequest createCompartmentRequest = new CreateCompartmentRequest
            {
                CreateCompartmentDetails = createCompartmentDetails
            };
            CreateCompartmentResponse createCompartmentResponse = await client.CreateCompartment(createCompartmentRequest);

            // wait for compartment to be accessible
            await Task.Delay(10000);
            logger.Info($"{name} compartment created, ID: {createCompartmentResponse.Compartment.Id} and state is {createCompartmentResponse.Compartment.LifecycleState}");

            return createCompartmentResponse.Compartment.Id;
        }

        private static async Task MoveCompartment(IdentityClient client, string sourceCompartmentId, string targetCompartmentId)
        {
            MoveCompartmentDetails moveCompartmentDetails = new MoveCompartmentDetails
            {
                TargetCompartmentId = targetCompartmentId
            };
            MoveCompartmentRequest moveCompartmentRequest = new MoveCompartmentRequest
            {
                CompartmentId = sourceCompartmentId,
                MoveCompartmentDetails = moveCompartmentDetails
            };
            MoveCompartmentResponse moveCompartmentResponse = await client.MoveCompartment(moveCompartmentRequest);

            logger.Info("compartment moved successfully");
        }
    }
}
