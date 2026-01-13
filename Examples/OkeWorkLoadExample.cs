/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Threading.Tasks;
using Oci.Common.Auth;
using Oci.ContainerengineService;
using Oci.ContainerengineService.Requests;
using Oci.ContainerengineService.Responses;

namespace Oci.Examples
{
    public class OkeWorkLoadAuthExample
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public static async Task MainOKE()
        {
            logger.Info("Starting example");
            try
            {
                // Get the Default OKE workload Auth provider
                // The OkeWorkloadIdentityAuthenticationDetailsProvider provides different mechanisms to define the serviceAccountTokenSupplier
                //  * Using OkeWorkloadIdentityAuthenticationDetailsProvider.GetProvider(IServiceAccountTokenSupplier: serviceAccountTokenSupplier) -> Lets you provide your own implementation
                //  * Using OkeWorkloadIdentityAuthenticationDetailsProvider.GetProvider(token: <token-string>) -> Lets you create a SuppliedServiceAccountTokenProvider using this token
                //  * Using OkeWorkloadIdentityAuthenticationDetailsProvider.GetProvider(tokenPath: <path to token file>) -> Lets you create a DefaultServiceAccountTokenSupplier using this token file
                var provider = OkeWorkloadIdentityAuthenticationDetailsProvider.GetProvider();
                using var client = new ContainerEngineClient(provider);
                //client.SetEndpoint(Environment.GetEnvironmentVariable("OCI_OKE_ENDPOINT"));
                logger.Info("ContainerEngineClient created.");

                // Create Cluster
                CreateClusterRequest createClusterRequest = new()
                {
                    CreateClusterDetails = new()
                    {
                        CompartmentId = "<compartmentId>",
                        Name = "<name>",
                        KubernetesVersion = "<kubernetesVersion>",
                        VcnId = "<vcnId>"
                    }
                };
                logger.Info("createClusterRequest created.");
                CreateClusterResponse createClusterResponse = await CreateClusterExample(client, createClusterRequest);
                logger.Info($"Response from CreateClusterExample with OPC Work Request ID:{createClusterResponse.OpcWorkRequestId}");

                // Get Cluster
                GetClusterRequest getClusterRequest = new()
                {
                    ClusterId = "<Cluster ID>"
                };
                logger.Info("getClusterRequest created.");
                GetClusterResponse getClusterResponse = await GetClusterExample(client, getClusterRequest);
                logger.Info($"Response from GetClusterExample, got cluster with ID:{getClusterResponse.Cluster.Id} with Lifecycle State:{getClusterResponse.Cluster.LifecycleState}");
            }
            catch (Exception e)
            {
                logger.Error($"Failed OkeWorkLoadAuth example: {e.Message}");
            }
        }

        public static async Task<CreateClusterResponse> CreateClusterExample(ContainerEngineClient client, CreateClusterRequest createClusterRequest)
        {
            logger.Info("Starting CreateClusterExample");
            try
            {
                return await client.CreateCluster(createClusterRequest);
            }
            catch (Exception e)
            {
                logger.Error($"Failed at CreateClusterExample:\n{e}");
                throw;
            }
        }

        public static async Task<GetClusterResponse> GetClusterExample(ContainerEngineClient client, GetClusterRequest getClusterRequest)
        {
            logger.Info("Starting GetClusterExample");
            try
            {
                return await client.GetCluster(getClusterRequest);
            }
            catch (Exception e)
            {
                logger.Error($"Failed at GetClusterExample:\n{e}");
                throw;
            }
        }
    }
}