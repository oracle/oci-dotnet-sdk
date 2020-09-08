/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.Diagnostics.CodeAnalysis;
using Xunit;
using System.Text.RegularExpressions;

namespace Oci.Common.Auth
{
    [ExcludeFromCodeCoverage]
    public class SecurityTokenTests : BaseTest
    {
        private string token;
        private SecurityTokenAdapter securityTokenAdapter;
        public SecurityTokenTests()
        {
            token = @"eyJraWQiOiJhc3dfb2MxXzIwMTktMDYtMjciLCJhbGciOiJSUzI1NiJ9.eyJz
            dWIiOiJvY2lkMS5pbnN0YW5jZS5vYzEucGh4LmFueWhxbGpyb2dydjQ3aWNzbW1ydmk3YnMyamVyZ3
            pqZnRoc2Yzb2Zvbm4zbWVhcXRnNzU3ejJoNzdwYSIsIm9wYy1jZXJ0dHlwZSI6Imluc3RhbmNlIiwi
            aXNzIjoiYXV0aFNlcnZpY2Uub3JhY2xlLmNvbSIsImZwcmludCI6IjEzOjg1OkY3OjNGOjY0OjdGOj
            VFOjgzOkI5Ojc5OjlFOjczOjkzOkVFOjE0OjlCOkZDOkYwOjhCOjBDIiwicHR5cGUiOiJpbnN0YW5j
            ZSIsImF1ZCI6Im9jaSIsIm9wYy10YWciOiIiLCJ0dHlwZSI6Ing1MDkiLCJvcGMtaW5zdGFuY2UiOi
            JvY2lkMS5pbnN0YW5jZS5vYzEucGh4LmFueWhxbGpyb2dydjQ3aWNzbW1ydmk3YnMyamVyZ3pqZnRo
            c2Yzb2Zvbm4zbWVhcXRnNzU3ejJoNzdwYSIsImV4cCI6MTU5NzE2NjA4Nywib3BjLWNvbXBhcnRtZW
            50Ijoib2NpZDEuY29tcGFydG1lbnQub2MxLi5hYWFhYWFhYXB5ZDRmYTV2enJxNnV1am10aGU0cDRk
            d3RnZXh3bXVzZXZwaHF0N2o0aHBmaG92d2x1dXEiLCJpYXQiOjE1OTcxNjQ4ODcsImp0aSI6IjM2Zj
            Y2ZjVjLWZlNzEtNDc4Ny04MjViLTg0NzM2NWNlMDJhMiIsInRlbmFudCI6Im9jaWQxLnRlbmFuY3ku
            b2MxLi5hYWFhYWFhYTN2aTNmdDN5aTNzcTRuaGlxbDRudmJ6ano2Z2lwYm43Mmg3d2VybDZuanM2eH
            NxNHdnZHEiLCJqd2siOiJ7XCJraWRcIjpcIjEzOjg1OmY3OjNmOjY0OjdmOjVlOjgzOmI5Ojc5Ojll
            OjczOjkzOmVlOjE0OjliOmZjOmYwOjhiOjBjXCIsXCJuXCI6XCJsMXplTGJVb1ZrRGQ2bjVLZWhaNX
            pwQi1ERlgxWWswakl3WVNrcEpSbDBfZGJTSkw5OTUyWFFxVmJjd0RCcGZLLThJNVhFNXBDaHE5d1NQ
            MTdpbXcwSGgtcG5wdmdqV0xDWDZZV2FlM1hCdFpoNm5MYkRtNG1NWGlZdTJvVWs2aWpZSUlnYkF1Wn
            YtUEtaaDA2NEdGV0VSTXhvSkVwMDdFRWptVGZoZW1mX0NfRFZ1Qmhmc3REcm5DS0lHX3FlR0kyWExN
            N0Jna1lBOHVSUXR6Qzh0QlQySFYyczU4ZXBFNHU1d2NCZkF5MWdFcWxkMjUwRFplUjJMSlJ1djJNS1
            A0RDdEUjVncng1STVWS0ZkTFRVeHNtRVdfRTJFYUI3NmUxWXJvNG9rNjJPcGdOU0E3RERiZFgtQTRp
            akFCb2NUNTZkODY3QnNydnRFak9tWkNqN0RFbHdcIixcImVcIjpcIkFRQUJcIixcImt0eVwiOlwiUl
            NBXCIsXCJhbGdcIjpcIlJTMjU2XCIsXCJ1c2VcIjpcInNpZ1wifSIsIm9wYy10ZW5hbnQiOiJvY2lk
            MS50ZW5hbmN5Lm9jMS4uYWFhYWFhYWEzdmkzZnQzeWkzc3E0bmhpcWw0bnZiemp6NmdpcGJuNzJoN3
            dlcmw2bmpzNnhzcTR3Z2RxIn0.MX3P-fTQF__8Hp8QSh6bFs0oTTGMXB5YOze4NygHvW9P-iXGIqGT
            VNnU__pxvZVPVbTRXoUqBQoNAAzAD4aqYzr6Ds-Swk-uGdmQ86e_kUHZ9WiWXMyyDKZb-5WPpyL1zD
            y6GwenqnDNBJF3LfJ1GgFnkpjRXmM8q9kXFM89VlkPMXz57q-oq_nZryBqunZKMzK4rOrsyzGwdzs4
            T6yrY7ad6zOz5MkwCUrODtjzOiF6toOdApBFJDxbWVibv7lp2t8NibAtz3gqLwPoMgdl_IO9npN1l6
            Xac194bcbHMKgNV0GiNANmS3f0fG7MO91BZsRuPTRkJ29bqb2ebeoWSQ";

            string test = Regex.Replace(token, @"\s+", string.Empty);
            securityTokenAdapter = new SecurityTokenAdapter(test);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void IsValidTest()
        {
            Assert.False(securityTokenAdapter.IsValid());
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void GetStringClaimTest()
        {
            Assert.Equal("instance", securityTokenAdapter.GetStringClaim("ptype"));
        }
    }
}
