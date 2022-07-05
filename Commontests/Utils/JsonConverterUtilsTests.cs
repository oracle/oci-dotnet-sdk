/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Xunit;

using Newtonsoft.Json.Linq;

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
        [InlineData("11/24/2020 15:05:15Z", "{\"DateTimeValue\":\"2020-11-24T15:05:15.000Z\"}", "en-US")]
        [InlineData("24/11/2020 15:05:15Z", "{\"DateTimeValue\":\"2020-11-24T15:05:15.000Z\"}", "en-IE")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void SerializeDateTime(string value, string expectedValue, string dateTimeCultureCode)
        {
            var objWithDateTime = new ClassWithDateTime
            {
                DateTimeValue = DateTime.Parse(value, new CultureInfo(dateTimeCultureCode))
            };
            var objJson = JsonConvert.SerializeObject(objWithDateTime, new JsonSerializerSettings { ContractResolver = new CustomResolver(), NullValueHandling = NullValueHandling.Ignore });
            Assert.Equal(expectedValue, objJson);
        }

        [Theory]
        [Trait("Category", "Unit")]
        [InlineData("{\"compartmentId\":\"compartmentId\", \"responseEnum\":\"XYZ\"}", "compartmentId", ResponseEnum.UnknownEnumValue)]
        [InlineData("{\"compartmentId\":\"compartmentId2\", \"responseEnum\":\"Value1\"}", "compartmentId2", ResponseEnum.Value1)]
        [DisplayTestMethodNameAttribute]
        public void TestResonseEnumConverter(string content, string expectedCompartmentId, ResponseEnum responseEnum)
        {
            var resonseEnumSummary = JsonConvert.DeserializeObject<ResonseEnumSummary>(content);
            Assert.Equal(expectedCompartmentId, resonseEnumSummary.CompartmentId);
            Assert.Equal(responseEnum, resonseEnumSummary.responseEnum);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestDiscriminatorEnumConverter()
        {
            string content = "{\"attributeName\":\"PATH\", \"attributeValue\":\"XYZ\"}";
            var response = JsonConvert.DeserializeObject<BaseDiscriminatorEnum>(content) as PathMatchCondition;
            Assert.Equal("XYZ", response.AttributeValue);

            string content2 = "{\"attributeName\":\"DOES_NOT_EXIST\", \"attributeValue\":\"XYZ\"}";
            var response2 = JsonConvert.DeserializeObject<BaseDiscriminatorEnum>(content2);
            Assert.Null(response2);
        }
    }

    public class ClassWithDateTime
    {
        public Nullable<DateTime> DateTimeValue { get; set; }
    }

    public enum ResponseEnum
    {
        [EnumMember(Value = null)]
        UnknownEnumValue,
        [EnumMember(Value = "Value1")]
        Value1
    }
    public class ResonseEnumSummary
    {
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }

        [JsonConverter(typeof(ResponseEnumConverter))]
        [JsonProperty(PropertyName = "responseEnum")]
        public System.Nullable<ResponseEnum> responseEnum { get; set; }
    }

    [JsonConverter(typeof(BaseDiscriminatorEnumModelConverter))]
    public class BaseDiscriminatorEnum
    {
        public enum AttributeNameEnum
        {
            [EnumMember(Value = "PATH")]
            Path
        };
    }

    public class BaseDiscriminatorEnumModelConverter : JsonConverter
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(BaseDiscriminatorEnum);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(BaseDiscriminatorEnum);
            var discriminator = jsonObject["attributeName"].Value<string>();
            switch (discriminator)
            {
                case "PATH":
                    obj = new PathMatchCondition();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under BaseDiscriminatorEnum! Returning null value.");
            }
            return obj;
        }
    }
    public class PathMatchCondition : BaseDiscriminatorEnum
    {
        [JsonProperty(PropertyName = "attributeValue")]
        public string AttributeValue { get; set; }
        [JsonProperty(PropertyName = "attributeName")]
        private readonly string attributeName = "PATH";
    }
}