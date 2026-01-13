/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Oci.Common.Model;
using Xunit;

namespace Oci.Common.Http.Internal
{
    [ExcludeFromCodeCoverage]
    public class ResponseHelperTests : BaseTest
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestReadEntityWithValidJSONResponse()
        {
            var testObject = new TestObject() { TestName = "TestReadEntityWithValidJSONResponse" };
            var jsonString = JsonConvert.SerializeObject(testObject);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var dummyResponse = new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.OK,
                Content = content
            };

            var returnedEntity = ResponseHelper.ReadEntity<TestObject>(dummyResponse);

            Assert.Equal(testObject.TestName, returnedEntity.TestName);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestReadEntityWithBinaryContent()
        {
            var dummyBinaryString = Encoding.Unicode.GetString(Encoding.Unicode.GetBytes("Dummy String"));
            var content = new StringContent(dummyBinaryString);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            var dummyResponse = new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.OK,
                Content = content
            };

            var returnedStream = ResponseHelper.ReadEntity<Stream>(dummyResponse);

            Assert.Equal(dummyBinaryString, new StreamReader(returnedStream).ReadToEnd());
        }

        [Theory]
        [InlineData(HttpStatusCode.BadRequest, "Bad Request")]
        [InlineData(HttpStatusCode.InternalServerError, "Internal Service Error")]
        [InlineData(HttpStatusCode.NotFound, "Resource Not Found")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestHandleNonSuccessfulResponseWithCodeAndMessage(HttpStatusCode errorStatusCode, string errorMessage)
        {
            var dummyErrorObject = new ErrorCodeAndMessage(errorStatusCode.ToString(), errorMessage);
            var jsonString = JsonConvert.SerializeObject(dummyErrorObject);
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var dummyResponse = new HttpResponseMessage()
            {
                StatusCode = errorStatusCode,
                Content = content
            };

            var exception = Assert.Throws<OciException>(
                () => ResponseHelper.HandleNonSuccessfulResponse(dummyResponse));

            Assert.Equal(errorStatusCode, exception.StatusCode);
            Assert.Equal(errorMessage, exception.Message);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestHandleNonSuccessfulResponseReasonPhrase()
        {
            var dummyStatusCode = HttpStatusCode.BadRequest;
            var dummyReasonPhrase = "Bad Request";
            var content = new StringContent("");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var dummyResponse = new HttpResponseMessage
            {
                StatusCode = dummyStatusCode,
                ReasonPhrase = dummyReasonPhrase,
                Content = content
            };

            var exception = Assert.Throws<OciException>(
                () => ResponseHelper.HandleNonSuccessfulResponse(dummyResponse));
            Assert.Equal(dummyStatusCode, exception.StatusCode);
            Assert.Equal(dummyReasonPhrase, exception.Message);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestHandleNonSuccessfulDefaultMessage()
        {
            var dummyStatusCode = (HttpStatusCode)555;
            var content = new StringContent("");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var dummyResponse = new HttpResponseMessage
            {
                StatusCode = dummyStatusCode,
                Content = content
            };

            var exception = Assert.Throws<OciException>(
                () => ResponseHelper.HandleNonSuccessfulResponse(dummyResponse));
            Assert.Equal(dummyStatusCode, exception.StatusCode);
            Assert.Equal(ResponseHelper.DEFAULT_OCI_EXCEPTION_MESSAGE, exception.Message);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestReadEntityWithJsonParseErrors()
        {
            var jsonString = "{\"somekey\": {\"foo-key\": \"bar\"}}";
            var content = new StringContent(jsonString);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var dummyResponse = new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(jsonString)
            };

            Assert.Throws<InvalidCastException>(
                () => ResponseHelper.ReadEntity<ClassWithDictionary>(dummyResponse));
        }

        [Theory]
        [InlineData(HttpStatusCode.NotFound)]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestReadEntityForNonSuccessfulStatusCodesWithParseErrors(HttpStatusCode statusCode)
        {
            var jsonString = JsonConvert.SerializeObject("Dummy String");

            var dummyResponse = new HttpResponseMessage()
            {
                StatusCode = statusCode,
                Content = new StringContent(jsonString)
            };

            Assert.Throws<InvalidCastException>(
                () => ResponseHelper.ReadEntity<TestObject>(dummyResponse));
        }

        [Theory]
        [InlineData("{\"dictionaryValue\": {}}", 0)]
        [InlineData("{\"dictionaryValue\": {\"foo-key\": {\"bar-key\": \"foobar\"}}}", 1)]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestReadDictionaryValue(string value, int expectedCount)
        {
            var content = new StringContent(value);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var dummyResponse = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = content
            };

            var result = ResponseHelper.ReadEntity<ClassWithDictionary>(dummyResponse);

            Assert.Equal(expectedCount, result.DictionaryValue.Count);
            if (result.DictionaryValue.Count > 0)
            {
                Assert.Equal("foobar", result.DictionaryValue["foo-key"]["bar-key"]);
            }
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestEnumRefInHeader()
        {
            var content = new StringContent("");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var dummyResponse = new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.OK,
                Content = content
            };
            dummyResponse.Headers.Add("lifecycleState", "CREATING");
            var result = Converter.FromHttpResponseMessage<TestEnumRef>(dummyResponse);
            Assert.Equal(EnumRef.LifecycleStateEnum.Creating, result.LifecycleState);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestTopLevelEnumInHeader()
        {
            var content = new StringContent("");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var dummyResponse = new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.OK,
                Content = content
            };
            dummyResponse.Headers.Add("option", "OPTION1");
            var result = Converter.FromHttpResponseMessage<TestTopLevelEnum>(dummyResponse);
            Assert.Equal(TopLevelEnum.Option1, result.Option);
        }

        private class TestObject
        {
            [JsonProperty("testName")]
            public string TestName { get; set; }
        }

        private class ErrorCodeAndMessage
        {
            [JsonProperty("code")]
            public readonly string Code;

            [JsonProperty("message")]
            public readonly string Message;

            public ErrorCodeAndMessage(string code, string message)
            {
                this.Code = code;
                this.Message = message;
            }
        }

        private class ClassWithDictionary
        {
            [JsonProperty("dictionaryValue")]
            public Dictionary<string, Dictionary<string, Object>> DictionaryValue { get; set; }
        }

        public class EnumRef
        {
            public enum LifecycleStateEnum
            {
                [EnumMember(Value = "CREATING")]
                Creating,
                [EnumMember(Value = "ACTIVE")]
                Active,
                [EnumMember(Value = "FAILED")]
                Failed
            }
        }

        public class TestEnumRef : Oci.Common.OciResponse
        {
            [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "lifecycleState")]
            public System.Nullable<EnumRef.LifecycleStateEnum> LifecycleState { get; set; }
        }

        public enum TopLevelEnum
        {
            [EnumMember(Value = "OPTION1")]
            Option1,
            [EnumMember(Value = "OPTION2")]
            Option2
        }

        public class TestTopLevelEnum : Oci.Common.OciResponse
        {
            [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "option")]
            public System.Nullable<TopLevelEnum> Option { get; set; }
        }
    }
}
