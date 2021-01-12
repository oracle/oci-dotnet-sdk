/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using Xunit;

namespace Oci.Common.Utils
{
    [ExcludeFromCodeCoverage]
    public class JsonConverterUtilsTests : BaseTest
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        [Theory]
        [InlineData("{\"dateTimeValue\":null}")]
        [InlineData("{\"dateTimeValue\":\"05/07/2020 18:27:08\"}")]
        [InlineData("{\"dateTimeValue\":\"2020-05-07T18:27:08.123Z\"}")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void DeserializeDateTime(string content)
        {
            ClassWithDateTime result = JsonConvert.DeserializeObject<ClassWithDateTime>(
                content, new JsonSerializerSettings { ContractResolver = new CustomResolver(), NullValueHandling = NullValueHandling.Ignore });

            logger.Info(result.DateTimeValue);
        }

        [Theory]
        [InlineData("11/24/2020 15:05:15Z", "{\"DateTimeValue\":\"2020-11-24T15:05:15.000Z\"}")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void SerializeDateTime(string value, string expectedValue)
        {
            var objWithDateTime = new ClassWithDateTime
            {
                DateTimeValue = DateTime.Parse(value)
            };
            var objJson = JsonConvert.SerializeObject(objWithDateTime, new JsonSerializerSettings { ContractResolver = new CustomResolver(), NullValueHandling = NullValueHandling.Ignore });
            Assert.Equal(expectedValue, objJson);
        }
    }

    public class ClassWithDateTime
    {
        public Nullable<DateTime> DateTimeValue { get; set; }
    }


}
