/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Oci.Common.Model
{
    [ExcludeFromCodeCoverage]
    public class RangeTests : BaseTest
    {
        [Theory]
        [InlineData(1, 5)]
        [InlineData(1, null)]
        [InlineData(null, 5)]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void VerifyToString(long? startByte, long? endByte)
        {
            Range range = new Range()
            {
                StartByte = startByte,
                EndByte = endByte
            };

            var rangeStr = range.ToString();
            Assert.StartsWith("bytes=", rangeStr);
            rangeStr = rangeStr.Replace("bytes=", "");

            var byteRanges = rangeStr.Split('-');

            if (startByte.HasValue)
            {
                Assert.Contains(startByte.ToString(), byteRanges[0]);
            }

            if (endByte.HasValue)
            {
                Assert.Contains(endByte.ToString(), byteRanges[1]);
            }
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void VerifyParseRange()
        {
            Assert.Throws<ArgumentException>(() => Range.ParseRange("dummyString"));

            Assert.Throws<ArgumentException>(() => Range.ParseRange("bytes 1111"));

            var range = Range.ParseRange("bytes 1-5/6");

            Assert.Equal(1, range.StartByte);
            Assert.Equal(5, range.EndByte);
            Assert.Equal(6, range.ContentLength);
        }
    }
}
