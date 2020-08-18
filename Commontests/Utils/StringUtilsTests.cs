/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Oci.Common.Utils
{
    [ExcludeFromCodeCoverage]
    public class StringUtilsTests : BaseTest
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void NullString()
        {
            Assert.True(null == StringUtils.StringToSecureString(null));
            Assert.True(null == StringUtils.StringToSecureString(""));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void ValidString()
        {
            var testString = "some string";
            var length = testString.Length;
            Assert.True(length == StringUtils.StringToSecureString(testString).Length);
        }
    }
}
