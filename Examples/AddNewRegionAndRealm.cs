/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.Auth;
using Oci.IdentityService;
using Oci.IdentityService.Requests;

namespace Oci.Examples
{
    /**
    * This sample demonstrates how to use the SDK with new regions (and realms) without upgrading the SDK.
    */
    public class NewRegionAndRealmExample
    {
        const string OciConfigProfileName = "DEFAULT";
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static async Task MainRegionAndRealm()
        {
            // Accepts profile name and creates a auth provider based on config file
            var provider = new ConfigFileAuthenticationDetailsProvider(OciConfigProfileName);
            // Create a client for the service to enable using its APIs
            var client = new IdentityClient(provider, new ClientConfiguration());

            // Assume a new region us-foo-1 is launched in OC2 realm
            // Register the new region
            var fooRegion = Region.Register("us-foo-1", Realm.OC2);

            // If the config file contains a value for region, then it will be picked up automatically by the SDK,
            // else set it up manually by calling setRegion
            logger.Info($"Setting region to {fooRegion.RegionId}");
            client.SetRegion(fooRegion);

            // Use the client to make calls to the endpoint for the new region
            await ListAllRegions(client);

            // Now, assume a new region us-bar-1 is launched in OCX realm
            // (having secondLevelDomain oracle-baz-cloud.com)
            // Register the new region and realm
            var barRegion = Region.Register("us-bar-1", Realm.Register("ocx", "oracle-baz-cloud.com"));

            // Call setRegion to use the endpoint in the new region
            logger.Info($"Setting region to {barRegion.RegionId}");
            client.SetRegion(barRegion);

            // Use the client to make calls to the endpoint for the new region
            await ListAllRegions(client);
        }

        private static async Task ListAllRegions(IdentityClient client)
        {
            logger.Info("Querying for list of regions");

            var response = await client.ListRegions(new ListRegionsRequest { });
            foreach (var region in response.Items)
            {
                logger.Info($"Region: {region.Name}");
            }
        }
    }
}
