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
    // This example demonstrates the following operations
    // * List OCI regions
    // * List region subscriptions
    // * Create a user and a group
    // * Add user to the group
    // * remove user membership and delete the user and group

    public class IdentityExample
    {
        const string OciConfigProfileName = "DEFAULT";
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        const string userName = "oci-dotnetsdk-test-user";

        public static async Task MainIdentity()
        {
            string compartmentId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID");
            // Accepts profile name and creates a auth provider based on config file
            var provider = new ConfigFileAuthenticationDetailsProvider(OciConfigProfileName);
            // Create a client for the service to enable using its APIs
            var client = new IdentityClient(provider, new ClientConfiguration());

            try
            {
                await ListOciRegions(client);
                await ListOciRegionSubscriptions(client, compartmentId);
                await UserAndGroupOps(client, compartmentId);
            }
            catch (Exception e)
            {
                logger.Info($"Received exception due to {e.Message}");
            }
            finally
            {
                client.Dispose();
            }
        }

        private static async Task ListOciRegions(IdentityClient client)
        {
            // List regions
            var listRegionsRequest = new ListRegionsRequest();
            ListRegionsResponse listRegionsResponse = await client.ListRegions(listRegionsRequest);
            logger.Info("List Regions");
            logger.Info("=============");
            foreach (Oci.IdentityService.Models.Region reg in listRegionsResponse.Items)
            {
                logger.Info($"{reg.Key} : {reg.Name}");
            }
        }

        private static async Task ListOciRegionSubscriptions(IdentityClient client, string compartmentId)
        {
            // List RegionSubscriptions
            ListRegionSubscriptionsRequest listRegionSubscriptionsRequest = new ListRegionSubscriptionsRequest
            {
                TenancyId = compartmentId
            };
            ListRegionSubscriptionsResponse listRegionSubscriptionsResponse = await client.ListRegionSubscriptions(listRegionSubscriptionsRequest);
            List<RegionSubscription> regionSubscriptions = listRegionSubscriptionsResponse.Items;
            logger.Info("List RegionSubscriptions");
            logger.Info("=========================");
            foreach (RegionSubscription regionSubscription in regionSubscriptions)
            {
                logger.Info($"{regionSubscription.RegionName} : {regionSubscription.RegionKey}");
            }
        }

        private static async Task UserAndGroupOps(IdentityClient client, string compartmentId)
        {
            // create a test user
            CreateUserDetails createUserDetails = new CreateUserDetails
            {
                CompartmentId = compartmentId,
                Name = userName,
                Description = "testing oci sdk for .NET"
            };
            CreateUserRequest createUserRequest = new CreateUserRequest { CreateUserDetails = createUserDetails };
            CreateUserResponse createUserResponse = await client.CreateUser(createUserRequest);
            User user = createUserResponse.User;
            logger.Info($"user created, Name : {user.Name} , ID : {user.Id}");

            // create a test group
            CreateGroupDetails createGroupDetails = new CreateGroupDetails
            {
                CompartmentId = compartmentId,
                Name = "oci-dotnetsdk-testgroup",
                Description = "testing oci sdk for .NET"
            };
            CreateGroupRequest createGroupRequest = new CreateGroupRequest
            {
                CreateGroupDetails = createGroupDetails
            };
            CreateGroupResponse createGroupResponse = await client.CreateGroup(createGroupRequest);
            logger.Info($"new group created, Name : {createGroupResponse.Group.Name} , Id : {createGroupResponse.Group.Id}");
            Group group = createGroupResponse.Group;

            // add the user to the group
            logger.Info("Adding new user to the new group");
            AddUserToGroupDetails addUserToGroupDetails = new AddUserToGroupDetails
            {
                UserId = user.Id,
                GroupId = group.Id
            };

            AddUserToGroupRequest addUserToGroupRequest = new AddUserToGroupRequest { AddUserToGroupDetails = addUserToGroupDetails };
            AddUserToGroupResponse addUserToGroupResponse = await client.AddUserToGroup(addUserToGroupRequest);
            logger.Info($"Added user: {user.Name} to the group: {group.Name}");

            // remove user from the group
            logger.Info($"removing user: {user.Name} from the group: {group.Name}");
            RemoveUserFromGroupRequest removeUserFromGroupRequest = new RemoveUserFromGroupRequest
            {
                UserGroupMembershipId = addUserToGroupResponse.UserGroupMembership.Id
            };
            await client.RemoveUserFromGroup(removeUserFromGroupRequest);

            // delete the user
            logger.Info($"deleting the user: {user.Name}");
            DeleteUserRequest deleteUserRequest = new DeleteUserRequest { UserId = user.Id };
            await client.DeleteUser(deleteUserRequest);

            // delete the group
            logger.Info($"deleting the group: {group.Name}");
            DeleteGroupRequest deleteGroupRequest = new DeleteGroupRequest { GroupId = group.Id };
            await client.DeleteGroup(deleteGroupRequest);

            logger.Info("Finished delete user and group");
        }
    }
}
