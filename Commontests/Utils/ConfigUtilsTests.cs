/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Xunit;

namespace Oci.Common.Utils
{
    [ExcludeFromCodeCoverage]
    public class ConfigUtilsTests : BaseTest
    {
        private const string ENV_REGION_ID = "oci-envregion-id";

        [Theory]
        [InlineData("[DEFAULT]\nuser = ocid1.user.oc1..aa\nfingerprint = 8b:03\nkey_file = /Users/bunny/.oci/oci_api_key.pem\ntenancy = ocid1.tenancy.oc1..aaa\nregion = me-dubai-1\npass_phrase = xx", "me-dubai-1")]
        [InlineData("[DEFAULT]\nuser = ocid1.user.oc1..aa\nfingerprint = 8b:03\nkey_file = /Users/bunny/.oci/oci_api_key.pem\ntenancy = ocid1.tenancy.oc1..aaa\nregion = me-invalidregion-1\npass_phrase = xx", "me-invalidregion-1")]
        [InlineData("[DEFAULT]\nuser = ocid1.user.oc1..aa\nfingerprint = 8b:03\nkey_file = /Users/bunny/.oci/oci_api_key.pem\ntenancy = ocid1.tenancy.oc1..aaa\npass_phrase = xx", "uk-london-1")]
        [InlineData("[DEFAULT]\nuser = ocid1.user.oc1..aa\nfingerprint = 8b:03\nkey_file = /Users/bunny/.oci/oci_api_key.pem\ntenancy = ocid1.tenancy.oc1..aaa\npass_phrase = xx", ENV_REGION_ID)]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void SetRegionTest(string profile, string expectedRegionId)
        {
            string path = @".\testconfig" + DateTime.Now.ToFileTimeUtc();
            try
            {
                File.WriteAllText(path, profile);
                Region region;
                var config = ConfigFileReader.Parse(path);
                //test retrieving region not present in config but from env variable.
                if (String.IsNullOrEmpty(config.GetValue("region")))
                {
                    Environment.SetEnvironmentVariable(ConfigUtils.REGION_ENV_VAR_NAME, expectedRegionId);
                }
                ConfigUtils.SetRegion(config, out region);
                Assert.Equal(region.RegionId, expectedRegionId);
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
