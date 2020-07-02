/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Oci.Common
{
    public class Services
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public static Service GetServiceByName(string serviceName)
        {
            Service service = null;
            if (!SERVICE_CACHE.TryGetValue(serviceName, out service))
            {
                logger.Info($"Service {serviceName} not found.");
            }
            return service;
        }

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
