/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Oci.Common.Auth;
using Xunit;

namespace Oci.Common.Utils
{
    [ExcludeFromCodeCoverage]
    public class SessionTokenAuthenticationDetailsProviderTests : BaseTest
    {

        [Theory]
        [InlineData("[DEFAULT]\nuser = flower\nfingerprint = le:ss:CO\nkey_file = /Users/flower/key.pem\ntenancy = plant\nregion = me-forest-1")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestNoSessionTokenFilePathProvided(string profile)
        {
            string path = @".\testconfig" + DateTime.Now.ToFileTimeUtc();
            try
            {
                File.WriteAllText(path, profile);
                Assert.ThrowsAny<InvalidDataException>(() => new SessionTokenAuthenticationDetailsProvider(path, "DEFAULT"));
            }
            finally
            {
                File.Delete(path);
            }
        }

        [Theory]
        [InlineData("[DEFAULT]\nuser = flower\nfingerprint = le:ss:CO\nkey_file = /Users/flower/key.pem\ntenancy = plant\nregion = me-forest-1\nsecurity_token_file = no_such_token_file")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestNoSessionTokenFileProvided(string profile)
        {
            string path = @".\testconfig" + DateTime.Now.ToFileTimeUtc();
            try
            {
                File.WriteAllText(path, profile);
                Assert.ThrowsAny<FileNotFoundException>(() => new SessionTokenAuthenticationDetailsProvider(path, "DEFAULT"));
            }
            finally
            {
                File.Delete(path);
            }
        }

        [Theory]
        [InlineData("[DEFAULT]\nuser = flower\nfingerprint = le:ss:CO\nkey_file = /Users/flower/key.pem\ntenancy = plant\nregion = me-forest-1\nsecurity_token_file = testTokenFile", "ABCDEF@12345")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestValidSessionTokenFileProvided(string profile, string tokenData)
        {
            string path = @".\testconfig" + DateTime.Now.ToFileTimeUtc();
            string tokenPath = "testTokenFile";
            try
            {
                File.WriteAllText(path, profile);
                File.WriteAllText(tokenPath, tokenData);
                var provider = new SessionTokenAuthenticationDetailsProvider(path, "DEFAULT");
                Assert.Equal("ST$" + tokenData, provider.KeyId);
            }
            finally
            {
                File.Delete(path);
                File.Delete(tokenPath);
            }
        }

        [Theory]
        [InlineData("[DEFAULT]\nuser = flower\nfingerprint = le:ss:CO\nkey_file = /Users/flower/key.pem\ntenancy = plant\nregion = me-forest-1\nsecurity_token_file = testTokenFile", "ABCDEF@12345", "12345@ABCDE")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestSessionTokenRefresh(string profile, string tokenData, string newTokenData)
        {
            string path = @".\testconfig" + DateTime.Now.ToFileTimeUtc();
            string tokenPath = "testTokenFile";
            try
            {
                File.WriteAllText(path, profile);
                File.WriteAllText(tokenPath, tokenData);
                var provider = new SessionTokenAuthenticationDetailsProvider(path, "DEFAULT");
                Assert.Equal("ST$" + tokenData, provider.KeyId);

                File.WriteAllText(tokenPath, newTokenData);
                Assert.Equal(newTokenData, provider.Refresh());
                Assert.Equal("ST$" + newTokenData, provider.KeyId);
            }
            finally
            {
                File.Delete(path);
                File.Delete(tokenPath);
            }
        }
    }
}