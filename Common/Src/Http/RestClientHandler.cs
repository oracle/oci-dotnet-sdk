/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

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

            SslProtocols = SslProtocols.Tls12;
            ClientCertificateOptions = ClientCertificateOption.Automatic;
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
