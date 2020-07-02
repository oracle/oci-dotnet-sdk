/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Moq;
using Oci.Common.Model;
using Xunit;

namespace Oci.Common.Waiters
{
    [ExcludeFromCodeCoverage]
    public class WaiterAgentTests : BaseTest
    {
        private readonly Mock<IOciRequest> requestMock;
        private readonly Mock<IOciResponse> responseMock;

        public WaiterAgentTests()
        {
            requestMock = new Mock<IOciRequest>();
            responseMock = new Mock<IOciResponse>();
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void ExecuteWithSuccessfulResponse()
        {
            Mock<Func<IOciRequest, Task<IOciResponse>>> queryMock = new Mock<Func<IOciRequest, Task<IOciResponse>>>();
            queryMock.Setup(method => method(It.IsAny<IOciRequest>())).ReturnsAsync(responseMock.Object);

            var agent = new WaiterAgent<IOciRequest, IOciResponse>(
                requestMock.Object,
                queryMock.Object,
                _ => true
                );

            var response = agent.Execute(new WaiterConfiguration());
            queryMock.Verify(mock => mock.Invoke(It.IsAny<IOciRequest>()), Times.Exactly(1));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void ExecuteWithUndesiredResponseState()
        {
            Mock<Func<IOciRequest, Task<IOciResponse>>> queryMock = new Mock<Func<IOciRequest, Task<IOciResponse>>>();
            queryMock.Setup(method => method(It.IsAny<IOciRequest>())).ReturnsAsync(responseMock.Object);

            var agent = new WaiterAgent<IOciRequest, IOciResponse>(
                requestMock.Object,
                queryMock.Object,
                _ => false
                );

            var waiterConfig = new WaiterConfiguration()
            {
                // no sleep time
                GetNextDelayInSeconds = retryAttempt => 0
            };

            try
            {
                agent.Execute(waiterConfig);
            }
            catch (WaitConditionFailedException) { }

            queryMock.Verify(mock => mock.Invoke(It.IsAny<IOciRequest>()), Times.Exactly(waiterConfig.MaxAttempts + 1));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void ExecuteWithNonSuccessfulResponseStates()
        {
            WaiterConfiguration waitConfig = new WaiterConfiguration();
            Mock<Func<IOciRequest, Task<IOciResponse>>> queryMock = new Mock<Func<IOciRequest, Task<IOciResponse>>>();
            queryMock.Setup(method => method(It.IsAny<IOciRequest>())).ThrowsAsync(new OciException(System.Net.HttpStatusCode.BadGateway, "", "", ""));

            var agent = new WaiterAgent<IOciRequest, IOciResponse>(
                requestMock.Object,
                queryMock.Object,
                _ => false
                );

            Assert.Throws<OciException>(() => agent.Execute(waitConfig));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void ExecuteWithAllowed404s()
        {
            WaiterConfiguration waitConfig = new WaiterConfiguration();
            Mock<Func<IOciRequest, Task<IOciResponse>>> queryMock = new Mock<Func<IOciRequest, Task<IOciResponse>>>();
            queryMock.Setup(method => method(It.IsAny<IOciRequest>())).ThrowsAsync(new OciException(System.Net.HttpStatusCode.BadGateway, "", "", "", new OciException(System.Net.HttpStatusCode.NotFound, "", "", "")));

            var agent = new WaiterAgent<IOciRequest, IOciResponse>(
                requestMock.Object,
                queryMock.Object,
                _ => false,
                allow404s: true
                );

            var response = agent.Execute(waitConfig);

            Assert.Null(response);
            queryMock.Verify(mock => mock.Invoke(It.IsAny<IOciRequest>()), Times.Exactly(1));
        }
    }
}
