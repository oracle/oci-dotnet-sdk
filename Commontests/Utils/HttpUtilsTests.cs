/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
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
            Assert.True(string.IsNullOrEmpty(HttpUtils.BuildQueryString(new List<string>())));
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
            var queries = new List<string>();
            queries.Add("foo=bar");
            Assert.Equal("foo=bar", HttpUtils.BuildQueryString(queries));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void BuildQueryString_TwoQueries()
        {
            var queries = new List<string>();
            queries.Add("foo1=bar1");
            queries.Add("foo2=bar2");
            var actualQueryString = HttpUtils.BuildQueryString(queries);
            Assert.True("foo1=bar1&foo2=bar2".Equals(actualQueryString), $"Actual query string: {actualQueryString}");
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void EncodeQueryParam_DateTime()
        {
            var dt = DateTime.Now;
            var escapedString = HttpUtils.EncodeQueryParam("key", dt, Oci.Common.Http.CollectionFormatType.Csv);
            Assert.True(escapedString.Contains(":"), $"Escaped string {escapedString} should contain \":\"");
            Assert.False(escapedString.Contains("%3A"), $"Escaped string {escapedString} should not contain \"%3A\"");
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void EncodeQueryParam_String()
        {
            var str = "string with space and #";
            var escapedString = HttpUtils.EncodeQueryParam("key", str, Oci.Common.Http.CollectionFormatType.Csv);
            Assert.False(escapedString.Contains(" "), $"Escaped string {escapedString} should not contain \" \"");
            Assert.False(escapedString.Contains("#"), $"Escaped string {escapedString} should not contain \"#\"");
            Assert.True(escapedString.Contains("%20"), $"Escaped string {escapedString} should contain \"%20\"");
            Assert.True(escapedString.Contains("%23"), $"Escaped string {escapedString} should contain \"%23\"");
        }

        [Theory]
        [MemberData(nameof(CollectionFormatTestData))]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void EncodeQueryParam_CollectionFormatCsv(List<string> queryValues, Oci.Common.Http.CollectionFormatType collectionFormat, string expectedQuery)
        {
            //var queryValues = new List<string>() { "val1", "val2" };
            var queryString = HttpUtils.EncodeQueryParam("key", queryValues, collectionFormat);
            Assert.Equal(expectedQuery, queryString);
        }

        public static IEnumerable<object[]> CollectionFormatTestData()
        {
            yield return new object[] { new List<string> { "val&1%", "val#2" }, Oci.Common.Http.CollectionFormatType.Csv, "key=val%261%25,val%232" };
            yield return new object[] { new List<string> { "val&1", "val #2" }, Oci.Common.Http.CollectionFormatType.Multi, "key=val%261&key=val%20%232" };
            yield return new object[] { new List<string> { "val&1", "val#2" }, Oci.Common.Http.CollectionFormatType.Pipes, "key=val%261%7Cval%232" };
            yield return new object[] { new List<string> { "val&1", "val#2" }, Oci.Common.Http.CollectionFormatType.Ssv, "key=val%261%20val%232" };
            yield return new object[] { new List<string> { "val&1", "val#2" }, Oci.Common.Http.CollectionFormatType.Tsv, "key=val%261%09val%232" };
        }
    }
}
