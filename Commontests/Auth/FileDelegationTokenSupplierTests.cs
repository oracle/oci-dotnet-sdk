/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IO;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Oci.Common.Auth
{
    [ExcludeFromCodeCoverage]
    public class FileDelegationTokenSupplierTests : BaseTest
    {
        private const string DELEGATION_TOKEN = "InvalidPass";

        [Theory]
        [InlineData(DELEGATION_TOKEN, DELEGATION_TOKEN)]
        [InlineData("", "")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void DelegationTokenReaderValidPathTest(string actual, string expected)
        {
            string path = @".\delegation_token" + DateTime.Now.ToFileTimeUtc();
            try
            {
                System.IO.File.WriteAllText(path, actual);
                var supplier = new FileDelegationTokenSupplier(path);
                Assert.Equal(supplier.GetKey(), expected);
            }
            finally { File.Delete(path); }

        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("xkcd")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void DelegationTokenReaderInvalidPathTest(string path)
        {
            var supplier = new FileDelegationTokenSupplier(path);
            Assert.ThrowsAny<Exception>(() => supplier.GetKey());
        }
    }
}
