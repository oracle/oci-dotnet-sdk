/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
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
    public class ConfigFileAuthenticationDetailsProviderTests : BaseTest
    {

        [Theory]
        [InlineData("[DEFAULT]\nuser = flower\nfingerprint = le:ss:CO\nkey_file = /Users/flower/key.pem\ntenancy = plant\nregion = me-forest-1", "plant", "flower", "le:ss:CO")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestConfigProviderInstantiation(string profile, string tenancy, string user, string fingerprint)
        {
            string path = @".\testconfig" + DateTime.Now.ToFileTimeUtc();
            try
            {
                File.WriteAllText(path, profile);
                var config = new ConfigFileAuthenticationDetailsProvider(path, "DEFAULT");
                //Makes sure IAuthenticationDetailsProvider is instantiated if authentication_type is absent in config
                //Following values won't match if provider is not a configfileauthenticationdetail provider.
                Assert.Equal(config.TenantId, tenancy);
                Assert.Equal(config.UserId, user);
                Assert.Equal(config.Fingerprint, fingerprint);
                Assert.Null(config.GetDelegationToken());
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
