/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Oci.Common.Utils
{
    [ExcludeFromCodeCoverage]
    public class HttpUtilsTests : BaseTest
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void BuildQueryString_EmptyQuery()
        {
            Assert.True(string.IsNullOrEmpty(HttpUtils.BuildQueryString(new Dictionary<string, string>())));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void BuildQueryString_NullInput()
        {
            Assert.True(string.IsNullOrEmpty(HttpUtils.BuildQueryString(null)));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void BuildQueryString_OneQuery()
        {
            var queries = new Dictionary<string, string>();
            queries.Add("foo", "bar");
            Assert.Equal("foo=bar", HttpUtils.BuildQueryString(queries));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void BuildQueryString_TwoQueries()
        {
            var queries = new Dictionary<string, string>();
            queries.Add("foo1", "bar1");
            queries.Add("foo2", "bar2");
            var actualQueryString = HttpUtils.BuildQueryString(queries);
            Assert.True("foo1=bar1&foo2=bar2".Equals(actualQueryString), $"Actual query string: {actualQueryString}");
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void EncodeQueryParam_DateTime()
        {
            var dt = DateTime.Now;
            var escapedString = HttpUtils.EncodeQueryParam(dt);
            Assert.True(escapedString.Contains(":"), $"Escaped string {escapedString} should contain \":\"");
            Assert.False(escapedString.Contains("%3A"), $"Escaped string {escapedString} should contain \"%3A\"");
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void EncodeQueryParam_String()
        {
            var str = "string with space";
            var escapedString = HttpUtils.EncodeQueryParam(str);
            Assert.False(escapedString.Contains(" "), $"Escaped string {escapedString} should not contain \" \"");
            Assert.True(escapedString.Contains("%20"), $"Escaped string {escapedString} should contain \"%20\"");
        }
    }
}
