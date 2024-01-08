/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    public class FunctionsEmphemeralResourcePrincipalsExample
    {
        public static async Task MainResourcePrincipals()
        {
            IdentityClient client = null;
            try
            {
                var resourcePrincipalsProvider = ResourcePrincipalAuthenticationDetailsProvider.GetProvider();
                client = new IdentityClient(resourcePrincipalsProvider, new ClientConfiguration());
                var listRegionsRequest = new ListRegionsRequest();
                ListRegionsResponse listRegionsResponse = await client.ListRegions(listRegionsRequest);
                Console.WriteLine("List Regions");
                Console.WriteLine("=============");
                foreach (Oci.IdentityService.Models.Region reg in listRegionsResponse.Items)
                {
                    Console.WriteLine($"{reg.Key} : {reg.Name}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occured in Resource Principals Example: {e}");
            }
            finally
            {
                client?.Dispose();
            }
        }
    }
}
