/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

﻿using System.Net.Http;
using Oci.Common.Auth;

namespace Oci.Common.Http.Signing
{
    // This class provides HttpClientHandler based on various inputs. HttpClientHandler
    // adds authorization header for the outgoing requests.
    public class OciHttpClientHandler
    {
        public static HttpClientHandler FromConfigFile(string configPath, string profile)
        {
            return FromConfigFile(configPath, profile, SigningStrategy.STANDARD);
        }

        public static HttpClientHandler FromConfigFile(string configPath, string profile, SigningStrategy signingStrategy)
        {
            var provider = new ConfigFileAuthenticationDetailsProvider(configPath, profile);

            return FromAuthProvider(provider, signingStrategy);
        }

        public static HttpMessageHandler FromAuthProvider(IBasicAuthenticationDetailsProvider provider)
        {
            return FromAuthProvider(provider, SigningStrategy.STANDARD);
        }

        public static HttpClientHandler FromAuthProvider(IBasicAuthenticationDetailsProvider provider, SigningStrategy signingStrategy)
        {
            var requestSigner = new DefaultRequestSigner(provider, signingStrategy);

            return FromRequestSigner(requestSigner);
        }

        public static HttpClientHandler FromRequestSigner(RequestSigner requestSigner)
        {
            return new RestClientHandler((requestMessage) =>
            {
                requestSigner.SignRequest(requestMessage);
            });
        }
    }
}
