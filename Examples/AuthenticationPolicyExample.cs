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

namespace Oci.Examples
{
    /**
    * An example for using the Authentication Policy api, which is a part of the OCI Platform APIs.
    * Steps:
    * 1. Get the Authentication-Policy for your tenant
    * 2. Update the Authentication-Policy for your tenant
    */
    public class AuthenticationPolicyExample
    {
        const string OciConfigProfileName = "DEFAULT";
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static async Task MainAuthenticationPolicy()
        {
            string tenantId = Environment.GetEnvironmentVariable("OCI_TENANT_ID");
            // Accepts profile name and creates a auth provider based on config file
            var provider = new ConfigFileAuthenticationDetailsProvider(OciConfigProfileName);
            // Create a client for the service to enable using its APIs
            var client = new IdentityClient(provider, new ClientConfiguration());

            await QueryAuthenticationPolicy(tenantId, client);
            await UpdateAuthenticationPolicy(tenantId, client);
        }

        private static async Task QueryAuthenticationPolicy(string tenantId, IdentityClient client)
        {
            var getAuthenticationPolicyRequest = new GetAuthenticationPolicyRequest
            {
                CompartmentId = tenantId
            };
            var response = await client.GetAuthenticationPolicy(getAuthenticationPolicyRequest);

            logger.Info($"Minimum password length of Authentication Policy is {response.AuthenticationPolicy.PasswordPolicy.MinimumPasswordLength}");
        }

        private static async Task UpdateAuthenticationPolicy(string tenantId, IdentityClient client)
        {
            var passwordPolicy = new PasswordPolicy
            {
                MinimumPasswordLength = 15, // note that this is changed from the default
                IsLowercaseCharactersRequired = true,
                IsUppercaseCharactersRequired = true,
                IsNumericCharactersRequired = true,
                IsSpecialCharactersRequired = true,
                IsUsernameContainmentAllowed = false
            };
            var updateAuthenticationPolicyDetails = new UpdateAuthenticationPolicyDetails
            {
                PasswordPolicy = passwordPolicy
            };
            var updateAuthenticationPolicyRequest = new UpdateAuthenticationPolicyRequest
            {
                UpdateAuthenticationPolicyDetails = updateAuthenticationPolicyDetails,
                CompartmentId = tenantId
            };
            var response = await client.UpdateAuthenticationPolicy(updateAuthenticationPolicyRequest);

            logger.Info($"The new minimum password length of Authentication Policy is {response.AuthenticationPolicy.PasswordPolicy.MinimumPasswordLength}");
        }
    }
}
