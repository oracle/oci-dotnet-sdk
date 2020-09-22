/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Net.Http;
using System.Security.Authentication;
using System.Threading;
using System.Threading.Tasks;

namespace Oci.Common.Http
{
    /// <summary>A handler for RestClient.</summary>
    public class RestClientHandler : HttpClientHandler
    {
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public RestClientHandler(RequestCallback callback)
        {
            this.callback = callback;
            ClientCertificateOptions = ClientCertificateOption.Automatic;
            try
            {
                SslProtocols = SslProtocols.Tls12;
            }
            catch (PlatformNotSupportedException e)
            {
                var msg = "Please upgrade to .NET Framework 4.7.2 or higher." +
                "Or make sure TLS 1.2 is enabled in your operating system. If your API calls to OCI succeed then TLS 1.2 is enabled";
                logger.Warn($"Received exception as SslProtocols property is not supported on this platform: {e}, {msg}");
            }
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            //
            // Invoke request receptor (callback) so that consumer get an oppotunity to add custom headers.
            //
            this.callback?.Invoke(request);
            logger.Debug("Dumping HttpRequest:\n{0}", request.ToString());
            return base.SendAsync(request, cancellationToken);
        }

        private readonly RequestCallback callback;
    }

    public delegate void RequestCallback(HttpRequestMessage request);
}
