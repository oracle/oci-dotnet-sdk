/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Diagnostics.CodeAnalysis;
using Oci.Common.Internal;
using Xunit;

namespace Oci.Common
{
    [ExcludeFromCodeCoverage]
    public class EndpointBuilderTest : BaseTest
    {
        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestCreateEndpointWithRealmSpecificEndpointTemplateInUse()
        {
            Environment.SetEnvironmentVariable("OCI_REALM_SPECIFIC_SERVICE_ENDPOINT_TEMPLATE_ENABLED", "true");
            Service testService = new Service
            {
                ServiceName = "EndpointBuilderTest1",
                ServiceEndpointPrefix = "foobar",
                ServiceEndpointTemplate = "http://{serviceEndpointPrefix}.{region}.{secondLevelDomain}",
                EndpointServiceName = "endpointbuildertest"
            };
            testService.AddServiceEndpointTemplateForRealm("oc1", "http://{fooParameter+Dot}{serviceEndpointPrefix}.{region}.{secondLevelDomain}");
            testService.AddServiceEndpointTemplateForRealm("oc3", "http://{barParameter+Dot}{serviceEndpointPrefix}.{region}.{secondLevelDomain}");
            Assert.Equal("http://{fooParameter+Dot}foobar.us-phoenix-1.oraclecloud.com", EndpointBuilder.CreateEndpoint(testService, Region.US_PHOENIX_1));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestCreateEndpointWithRealmSpecificEndpointWithTemplateMissing()
        {
            Environment.SetEnvironmentVariable("OCI_REALM_SPECIFIC_SERVICE_ENDPOINT_TEMPLATE_ENABLED", "true");
            Service testService = new Service
            {
                ServiceName = "EndpointBuilderTest2",
                ServiceEndpointPrefix = "foobar",
                ServiceEndpointTemplate = "http://{serviceEndpointPrefix}.{region}.{secondLevelDomain}",
                EndpointServiceName = "endpointbuildertest"
            };
            Assert.Equal("http://foobar.us-phoenix-1.oraclecloud.com", EndpointBuilder.CreateEndpoint(testService, Region.US_PHOENIX_1));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestCreateEndpointWithRealmSpecificEndpointDisabledWithTemplateInUse()
        {
            Environment.SetEnvironmentVariable("OCI_REALM_SPECIFIC_SERVICE_ENDPOINT_TEMPLATE_ENABLED", "");
            Service testService = new Service
            {
                ServiceName = "EndpointBuilderTest2",
                ServiceEndpointPrefix = "foobar",
                ServiceEndpointTemplate = "http://{serviceEndpointPrefix}.{region}.{secondLevelDomain}",
                EndpointServiceName = "endpointbuildertest"
            };
            testService.AddServiceEndpointTemplateForRealm("oc1", "http://{fooParameter+Dot}{serviceEndpointPrefix}.{region}.{secondLevelDomain}");
            Assert.Equal("http://foobar.us-phoenix-1.oraclecloud.com", EndpointBuilder.CreateEndpoint(testService, Region.US_PHOENIX_1));
        }
    }
}