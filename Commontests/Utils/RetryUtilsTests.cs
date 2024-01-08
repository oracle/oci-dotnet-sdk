/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Oci.Common.Utils
{
    [ExcludeFromCodeCoverage]
    public class RetryUtilsTests : BaseTest
    {

        [Theory]
        [InlineData("True", true)]
        [InlineData("False", false)]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("Abc", false)]
        [InlineData("tRuE", true)]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestDefaultSDKRetryEnvVariable(string defaultSdkRetryEnvVar, bool expectedEnvVar)
        {
            Environment.SetEnvironmentVariable("OCI_SDK_DEFAULT_RETRY_ENABLED", defaultSdkRetryEnvVar);
            Assert.Equal(RetryUtils.IsDefaultRetryConfigurationEnabled(), expectedEnvVar);
        }
    }
}
