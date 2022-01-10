/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using Oci.Common.Http.Signing;

namespace Oci.Examples
{
    public class RawRestCallExample
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static async Task MainRaw()
        {
            var namespaceName = Environment.GetEnvironmentVariable("NAMESPACE_NAME");
            var compartmentId = Environment.GetEnvironmentVariable("COMPARTMENT_ID");

            var httpClientHandler = OciHttpClientHandler.FromConfigFile("~/.oci/config", "DEFAULT");
            var GET_BUCKETS_URL = $"https://objectstorage.us-phoenix-1.oraclecloud.com/n/{namespaceName}/b/?compartmentId={compartmentId}";
            var client = new HttpClient(httpClientHandler);
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, new Uri(GET_BUCKETS_URL));

            var response = await client.SendAsync(requestMessage);

            logger.Info($"Is rest call successful: {response.IsSuccessStatusCode}");
            var responseJson = await response.Content.ReadAsStringAsync();
            logger.Info($"Parsed Response: {responseJson}");
        }
    }
}
