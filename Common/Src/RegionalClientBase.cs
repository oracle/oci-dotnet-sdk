/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using Oci.Common.Auth;
using Oci.Common.Http;
using Oci.Common.Http.Signing;

namespace Oci.Common
{
    /// <summary>An abstract class for a regional service client.</summary>
    public abstract class RegionalClientBase : ClientBase
    {
        protected new static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public RegionalClientBase(IBasicAuthenticationDetailsProvider authProvider) : base(authProvider)
        { }

        public RegionalClientBase(IBasicAuthenticationDetailsProvider authProvider, RequestSigner requestSigner) : base(authProvider, requestSigner)
        { }

        public RegionalClientBase(IBasicAuthenticationDetailsProvider authProvider, ClientConfiguration clientConfiguration) : base(authProvider, clientConfiguration)
        { }

        public RegionalClientBase(IBasicAuthenticationDetailsProvider authProvider, ClientConfiguration clientConfiguration, RequestSigner requestSigner) : base(authProvider, clientConfiguration, requestSigner)
        { }

        /// <summary>Set endpoint through region.</summary>
        /// <param name="region">The region used to set endpoint.</param>
        public void SetRegion(Region region)
        {
            string endpoint = region.GetEndpoint(this.service);
            SetEndpoint(endpoint);
        }

        /// <summary>Set endpoint through regionId.</summary>
        /// <param name="region">The region id used to set endpoint.</param>
        public void SetRegion(string regionId)
        {
            regionId = regionId.ToLower(new CultureInfo("en"));
            try
            {
                Region regionToUse = Region.FromRegionId(regionId);
                SetRegion(regionToUse);
            }
            catch (ArgumentException)
            {
                logger.Info($"Unknown regionId {regionId}, falling back to default endpoint format");
                String endpoint = Region.FormatDefaultRegionEndpoint(this.service, regionId);
                SetEndpoint(endpoint);
            }
        }
    }
}
