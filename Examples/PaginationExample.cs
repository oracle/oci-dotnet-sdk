/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.Auth;
using Oci.IdentityService;
using Oci.IdentityService.Models;
using Oci.IdentityService.Requests;
using Oci.IdentityService.Responses;

namespace Oci.Examples
{
    /**
    * This class demonstrates the different pagination mechanisms available in the OCI SDK for .NET. It covers three
    * ways of doing pagination:
    *
    * <ul>
    *   <li>Manually handling next page tokens</li>
    *   <li>Using the paginator exposed by each service client to iterate through responses to service calls</li>
    *   <li>Using the paginator exposed by each sertvice client to iterate through the models/resources returned by service calls</li>
    * </ul>
    *
    * This class also makes the following assumptions:
    *
    * <ul>
    *   <li>
    *      The configuration file used by service clients will be sourced from the default
    *      location (~/.oci/config) and the DEFAULT profile will be used
    *   </li>
    *   <li>
    *      The ListUsers operation in Identity service will be used to demonstrate pagination, so you should ensure that
    *      you have permissions to call this operation
    *   </li>
    *   <li>The region used is us-phoenix-1</li>
    * <ul>
    */

    public class PaginationExample
    {
        const string OciConfigProfileName = "DEFAULT";
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static async Task MainPagination()
        {
            string compartmentId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID");

            logger.Info("Starting Pagination example");

            // Accepts profile name and creates a auth provider based on config file
            var provider = new ConfigFileAuthenticationDetailsProvider(OciConfigProfileName);
            // Create a client for the service to enable using its APIs
            var identityClient = new IdentityClient(provider, new ClientConfiguration());

            try
            {
                await DoManualPagination(identityClient, compartmentId);
                DoPaginateWithResponsePaginator(identityClient, compartmentId);
                DoPaginateWithRecordPaginator(identityClient, compartmentId);
            }
            catch (Exception e)
            {
                logger.Info($"Received exception due to {e.Message}");
            }
            finally
            {
                logger.Info("ending Pagination example");
                identityClient.Dispose();
            }
        }

        /**
        * This method demonstrates how to do pagination yourself by manually managing the next page
        * tokens returned by service responses
        *
        * @param identityClient the client used to make service calls
        * @param compartmentId the OCID of the compartment we'll issue the ListUsers request against. This should be your tenancy OCID
        */
        private static async Task DoManualPagination(IdentityClient identityClient, string compartmentId)
        {
            logger.Info("Manual Pagination");
            logger.Info("==================");

            string nextPageToken = null;
            ListUsersRequest listUsersRequest = null;
            ListUsersResponse listUsersResponse = null;
            do
            {
                listUsersRequest = new ListUsersRequest
                {
                    CompartmentId = compartmentId,
                    Page = nextPageToken
                };
                listUsersResponse = await identityClient.ListUsers(listUsersRequest);
                foreach (User user in listUsersResponse.Items)
                {
                    logger.Info($"user: {user.Name}");
                }
                nextPageToken = listUsersResponse.OpcNextPage;
            } while (nextPageToken != null);

            logger.Info("\n\n");
        }

        /**
        * This method demonstrates how to do pagination by using the Paginator offered by the service client. Each service
        * client has a getPaginators() method which will return a Paginator. The Paginator will have methods which vend a
        * {@link java.lang.Iterable} that can be used to iterate over either Response objects returned by a service call or
        * resources/records being listed.
        *
        * This method demonstrates how to iterate over the Response objects using the Paginator. The methods used to
        * get an iterable over Response objects are always of the form <operation>ResponseEnumerator().
        */
        private static void DoPaginateWithResponsePaginator(IdentityClient identityClient, string compartmentId)
        {
            logger.Info("Pagination Using Response Paginator");
            logger.Info("===================================");

            ListUsersRequest listUsersRequest = new ListUsersRequest
            {
                CompartmentId = compartmentId
            };

            // Note that the iterable is over the Response objects
            IEnumerable<ListUsersResponse> responseEnumerable = identityClient.Paginators.ListUsersResponseEnumerator(listUsersRequest);
            foreach (ListUsersResponse listUsersResponse in responseEnumerable)
            {
                foreach (User user in listUsersResponse.Items)
                {
                    logger.Info($"user: {user.Name}");
                }
            }

            logger.Info("\n\n");
        }

        /**
        * This method demonstrates how to do pagination by using the Paginator offered by the service client. Each service
        * client has a getPaginators() method which will return a Paginator. The Paginator will have methods which vend a
        * {@link java.lang.Iterable} that can be used to iterate over either Response objects returned by a service call or
        * resources/records being listed.
        *
        * This method demonstrates how to iterate over the resources/records using the Paginator. The methods used to
        * get an enumerable over resources/records are always of the form <operation>RecordEnumerator().
        */
        private static void DoPaginateWithRecordPaginator(IdentityClient identityClient, string compartmentId)
        {
            logger.Info("Pagination Using Record Paginator");
            logger.Info("===================================");

            ListUsersRequest listUsersRequest = new ListUsersRequest
            {
                CompartmentId = compartmentId
            };

            // Note that the iterable is over the model object
            IEnumerable<User> recordEnumerable = identityClient.Paginators.ListUsersRecordEnumerator(listUsersRequest);
            foreach (User user in recordEnumerable)
            {
                logger.Info($"user: {user.Name}");
            }

            logger.Info("\n\n");
        }
    }
}
