/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Oci.Common
{
    /// <summary>
    /// Class to create new serivce instances.
    /// <br/>
    /// This serves to ensure conflicting definitions of services don't get created.
    /// </summary>
    public class Services
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>Get Service instance based on service name.</summary>
        /// <param name="serviceName">service name.</param>
        /// <returns>A service instance.</returns>
        public static Service GetServiceByName(string serviceName)
        {
            Service service = null;
            if (!SERVICE_CACHE.TryGetValue(serviceName, out service))
            {
                logger.Info($"Service {serviceName} not found.");
            }
            return service;
        }

        /// <summary>
        /// Create a new service definition.  If the service has already been registered
        /// with different values, an ArgumentException will be raised.  If the
        /// service has already been registered, the existing definition will be returned.
        /// </summary>
        /// <param name="serviceName">A unique service name.</param>
        /// <param name="serviceEndpointPrefix">The endpoint prefix of the service.</param>
        /// <param name="serviceEndpointTemplate">The endpoint template of the service.</param>
        /// <returns>The service instance created, or existing service instance if found.</returns>
        /// <exception>Throws ArgumentException if service name is already used by a different service instance.</exception>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Service Create(string serviceName, string serviceEndpointPrefix, string serviceEndpointTemplate)
        {
            if (string.IsNullOrEmpty(serviceName))
            {
                throw new ArgumentNullException("serviceName");
            }
            var service = new Service { ServiceName = serviceName, ServiceEndpointPrefix = serviceEndpointPrefix, ServiceEndpointTemplate = serviceEndpointTemplate };
            if (!SERVICE_CACHE.ContainsKey(serviceName))
            {
                logger.Info($"Registering new service: {service.ToString()}");
                SERVICE_CACHE.Add(serviceName, service);
                return service;
            }
            else
            {
                Service existingService = null;
                SERVICE_CACHE.TryGetValue(serviceName, out existingService);
                if (existingService.Equals(service))
                {
                    return existingService;
                }
                else
                {
                    throw new ArgumentException($"Cannot redefine service '{serviceName}'. Existing: '{existingService}', New: '{service}'");
                }
            }
        }

        private static readonly Dictionary<string, Service> SERVICE_CACHE = new Dictionary<string, Service>();

    }
}
