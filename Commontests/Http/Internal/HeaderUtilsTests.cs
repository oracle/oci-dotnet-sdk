/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using Xunit;

namespace Oci.Common.Http.Internal
{
    [ExcludeFromCodeCoverage]
    public class HeaderUtilsTests : BaseTest
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static IEnumerable<object[]> GetDataForToValue()
        {
            yield return new object[] { "2", typeof(int) };
            yield return new object[] { "2", typeof(long) };
            yield return new object[] { "2", typeof(float) };
            yield return new object[] { "2", typeof(double) };
            yield return new object[] { "2", typeof(string) };
            yield return new object[] { "true", typeof(bool) };
            yield return new object[] { "2", typeof(BigInteger) };
            yield return new object[] { "2020-04-09T09:29:01.551-07:00", typeof(DateTime) };
            yield return new object[] { "bytes 1-5/6", typeof(Oci.Common.Model.Range) };
        }

        public static IEnumerable<object[]> GetDataForFromValue()
        {
            yield return new object[] { (int)2 };
            yield return new object[] { (long)2 };
            yield return new object[] { (float)2 };
            yield return new object[] { (double)2 };
            yield return new object[] { "abc" };
            yield return new object[] { true };
            yield return new object[] { new BigInteger(2) };
            yield return new object[] { DateTime.Now };
            yield return new object[] { Oci.Common.Model.Range.ParseRange("bytes 1-5/6") };
        }

        [Theory]
        [MemberData(nameof(GetDataForToValue))]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestToValue(string strValue, Type type)
        {
            var convertedValue = HeaderUtils.ToValue(strValue, type);
            Assert.True(type.Equals(convertedValue.GetType()));
        }

        [Theory]
        [MemberData(nameof(GetDataForFromValue))]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestFromValue(dynamic value)
        {
            var convertedValue = HeaderUtils.FromValue(value);
            Assert.True(convertedValue.GetType().Equals(typeof(string)));
        }
    }
}
