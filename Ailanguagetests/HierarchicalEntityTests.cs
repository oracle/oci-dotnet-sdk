/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Oci.AilanguageService.Models;
using Oci.Common.Http.Internal;
using Oci.Common.Utils;
using Xunit;

namespace Oci.AilanguageService.Tests
{
    public class HierarchicalEntityTests
    {
        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            ContractResolver = new CustomResolver(),
            NullValueHandling = NullValueHandling.Ignore
        };

        [Fact]
        [Trait("Category", "Unit")]
        public void Deserialize_SingleObjectMetaInfo_SuccessfullyDeserializes()
        {
            var json = @"
            {
                ""offset"": 10,
                ""length"": 12,
                ""text"": ""Central Park"",
                ""type"": ""LOC"",
                ""subType"": ""GPE"",
                ""score"": 0.98,
                ""metaInfo"": {
                    ""offset"": 10,
                    ""length"": 12,
                    ""text"": ""Central Park"",
                    ""subType"": ""GPE"",
                    ""score"": 0.98
                }
            }";

            var entity = JsonConvert.DeserializeObject<HierarchicalEntity>(json, Settings);

            Assert.NotNull(entity);
            Assert.Equal("Central Park", entity.Text);
            Assert.NotNull(entity.MetaInfo);
            Assert.Equal("Central Park", entity.MetaInfo.Text);
            Assert.Equal(10, entity.MetaInfo.Offset);
            Assert.Equal(12, entity.MetaInfo.Length);
            Assert.Equal("GPE", entity.MetaInfo.SubType);
            Assert.Equal(0.98, entity.MetaInfo.Score);
            Assert.Null(entity.MetaInfo.AdditionalMetaInfos);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void Deserialize_ArrayMetaInfo_SingleElement_SuccessfullyDeserializes()
        {
            var json = @"
            {
                ""offset"": 0,
                ""length"": 10,
                ""text"": ""Bob Smith"",
                ""type"": ""PER"",
                ""score"": 0.95,
                ""metaInfo"": [
                    {
                        ""offset"": 0,
                        ""length"": 10,
                        ""text"": ""Bob Smith"",
                        ""subType"": ""PERSON"",
                        ""score"": 0.95
                    }
                ]
            }";

            var entity = JsonConvert.DeserializeObject<HierarchicalEntity>(json, Settings);

            Assert.NotNull(entity);
            Assert.NotNull(entity.MetaInfo);
            Assert.Equal("Bob Smith", entity.MetaInfo.Text);
            Assert.Equal(0, entity.MetaInfo.Offset);
            Assert.Equal(10, entity.MetaInfo.Length);
            Assert.Equal("PERSON", entity.MetaInfo.SubType);
            Assert.Null(entity.MetaInfo.AdditionalMetaInfos);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void Deserialize_ArrayMetaInfo_MultipleElements_PopulatesFirstAndAdditional()
        {
            // Issue #382 reproduction: compound date/time expressions returning metaInfo array
            var json = @"
            {
                ""offset"": 3,
                ""length"": 14,
                ""text"": ""Tuesday Jan 20"",
                ""type"": ""DATETIME"",
                ""score"": 0.99,
                ""metaInfo"": [
                    {
                        ""offset"": 3,
                        ""length"": 7,
                        ""text"": ""Tuesday"",
                        ""subType"": ""DAY_OF_WEEK"",
                        ""score"": 0.99
                    },
                    {
                        ""offset"": 11,
                        ""length"": 6,
                        ""text"": ""Jan 20"",
                        ""subType"": ""DATE"",
                        ""score"": 0.99
                    }
                ]
            }";

            var entity = JsonConvert.DeserializeObject<HierarchicalEntity>(json, Settings);

            Assert.NotNull(entity);
            Assert.NotNull(entity.MetaInfo);
            Assert.Equal("Tuesday", entity.MetaInfo.Text);
            Assert.Equal("DAY_OF_WEEK", entity.MetaInfo.SubType);
            Assert.NotNull(entity.MetaInfo.AdditionalMetaInfos);
            Assert.Single(entity.MetaInfo.AdditionalMetaInfos);
            Assert.Equal("Jan 20", entity.MetaInfo.AdditionalMetaInfos[0].Text);
            Assert.Equal("DATE", entity.MetaInfo.AdditionalMetaInfos[0].SubType);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void Deserialize_EmptyArrayMetaInfo_ReturnsNullMetaInfo()
        {
            var json = @"
            {
                ""offset"": 5,
                ""length"": 3,
                ""text"": ""IRS"",
                ""type"": ""ORG"",
                ""score"": 0.92,
                ""metaInfo"": []
            }";

            var entity = JsonConvert.DeserializeObject<HierarchicalEntity>(json, Settings);

            Assert.NotNull(entity);
            Assert.Null(entity.MetaInfo);
        }

        [Fact]
        [Trait("Category", "Unit")]
        public void Deserialize_NullOrMissingMetaInfo_ReturnsNullMetaInfo()
        {
            var jsonNull = @"{ ""text"": ""IRS"", ""metaInfo"": null }";
            var entityNull = JsonConvert.DeserializeObject<HierarchicalEntity>(jsonNull, Settings);
            Assert.NotNull(entityNull);
            Assert.Null(entityNull.MetaInfo);

            var jsonMissing = @"{ ""text"": ""IRS"" }";
            var entityMissing = JsonConvert.DeserializeObject<HierarchicalEntity>(jsonMissing, Settings);
            Assert.NotNull(entityMissing);
            Assert.Null(entityMissing.MetaInfo);
        }
    }
}
