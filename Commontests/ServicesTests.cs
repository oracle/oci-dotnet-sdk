/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using Xunit;

namespace Oci.Common
{
    [ExcludeFromCodeCoverage]
    [TestCaseOrderer("Oci.Common.PriorityOrderer", "oci-dotnet-sdk_common_test")]
    public class ServicesTests : BaseTest
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private static readonly string NEW_SERVICE_NAME = "FOO";
        private static readonly string NEW_SERVICE_ENDPOINT_PREFIX = "foo";
        private static readonly string NEW_SERVICE_ENDPOINT_TEMPLATE = "{region}.foo.oci.oraclecloud.com";

        [Fact, TestPriority(0)]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void AddNewService()
        {
            Services.Create(NEW_SERVICE_NAME, NEW_SERVICE_ENDPOINT_PREFIX, NEW_SERVICE_ENDPOINT_TEMPLATE);
            var service = Services.GetServiceByName(NEW_SERVICE_NAME);
            Assert.Equal(NEW_SERVICE_NAME, service.ServiceName);
            Assert.Equal(NEW_SERVICE_ENDPOINT_PREFIX, service.ServiceEndpointPrefix);
            Assert.Equal(NEW_SERVICE_ENDPOINT_TEMPLATE, service.ServiceEndpointTemplate);
        }

        [Fact,TestPriority(1)]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void CannotAddWithExistingServiceNameDifferentEndpointPrefix()
        {
            Assert.Throws<ArgumentException>(() => Services.Create(NEW_SERVICE_NAME, NEW_SERVICE_ENDPOINT_PREFIX + "New", NEW_SERVICE_ENDPOINT_TEMPLATE));
        }

        [Fact,TestPriority(2)]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void CannotAddWithExistingServiceNameDifferentEndpointTemplate()
        {
            Assert.Throws<ArgumentException>(() => Services.Create(NEW_SERVICE_NAME, NEW_SERVICE_ENDPOINT_PREFIX, NEW_SERVICE_ENDPOINT_TEMPLATE + "New"));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void CannotAddWithNullServiceName()
        {
            Assert.Throws<ArgumentNullException>(() => Services.Create(null, NEW_SERVICE_ENDPOINT_PREFIX + "New", NEW_SERVICE_ENDPOINT_TEMPLATE));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void CannotAddWithEmptyServiceName()
        {
            Assert.Throws<ArgumentNullException>(() => Services.Create(string.Empty, NEW_SERVICE_ENDPOINT_PREFIX + "New", NEW_SERVICE_ENDPOINT_TEMPLATE));
        }
    }
}
