/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

using Oci.Common.Alloy;
using Oci.Common.Utils;

using Xunit;

namespace Oci.Common
{
    [ExcludeFromCodeCoverage]
    public class AlloyConfigTests : BaseTest
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly string alloyConfigBlob = @"
            {
                ""regions"": [
                    {
                        ""realmKey"" : ""fooR1"",
                        ""realmDomainComponent"" : ""fooR1.com"",
                        ""regionKey"" : ""foo1"",
                        ""regionIdentifier"" : ""us-foo1-alloy""
                    },
                    {
                        ""realmKey"" : ""fooR2"",
                        ""realmDomainComponent"" : ""fooR2.com"",
                        ""regionKey"" : ""foo2"",
                        ""regionIdentifier"" : ""us-foo2-alloy""
                    }
                ],
                ""services"": [
                    ""core"",
                    ""identity"",
                    ""apigateway"",
                    ""object-storage""
                ],
                ""alloyProvider"": ""foo"",
                ""ociRegionCoexist"": ""True""
            }";

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestAlloyConfigTestWithoutOCIRegionCoexist()
        {
            Environment.SetEnvironmentVariable("OCI_ALLOY_REGION_COEXIST", "False");
            Environment.SetEnvironmentVariable("OCI_ALLOY_CONFIG_FILE_PATH", "~/.oci/test1-alloy-config.json");
            Directory.CreateDirectory(FileUtils.ExpandUserHome(Path.Combine("~", ".oci")));
            var alloyConfigPath = FileUtils.ExpandUserHome(Path.Combine("~", ".oci", "test1-alloy-config.json"));
            try
            {
                File.WriteAllText(alloyConfigPath, alloyConfigBlob);
                // Check if file written successfully
                Assert.True(File.Exists(alloyConfigPath));

                //re-init Alloy Config
                AlloyConfiguration.ReInitialize();
                // Test Service exists in OciEnabledServiceSet
                Assert.Contains("core", AlloyConfiguration.OciEnabledServiceSet);

                // Test if service names with non-alphabets are handled correctly
                Assert.True(AlloyConfiguration.IsServiceEnabled("Object-Storage"));

                // Test if disallowed service are blocked
                Assert.False(AlloyConfiguration.IsServiceEnabled("Audit"));

                // Test if Service Provider is set
                Assert.Equal("foo", AlloyConfiguration.OciAlloyProvider);

                // Check that known hard coded regions are removed
                Assert.DoesNotContain(Region.US_ASHBURN_1, Region.Values());

                // Check Alloy region exists
                Assert.True(Array.Exists(Region.Values(), region => region.RegionId.Equals("us-foo1-alloy")));

            }
            finally
            {
                File.Delete(alloyConfigPath);
                //reset Alloy Config
                AlloyConfiguration.ReInitialize();
            }
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestAlloyConfigTestWithOCIRegionCoexist()
        {


            Environment.SetEnvironmentVariable("OCI_ALLOY_CONFIG_FILE_PATH", "~/.oci/test2-alloy-config.json");
            Directory.CreateDirectory(FileUtils.ExpandUserHome(Path.Combine("~", ".oci")));
            var alloyConfigPath = FileUtils.ExpandUserHome(Path.Combine("~", ".oci", "test2-alloy-config.json"));
            try
            {
                File.WriteAllText(alloyConfigPath, alloyConfigBlob);
                Assert.True(File.Exists(alloyConfigPath));

                //re-init Alloy Config
                AlloyConfiguration.ReInitialize();

                // Test Service exists in OciEnabledServiceSet
                Assert.Contains("core", AlloyConfiguration.OciEnabledServiceSet);

                // Test if service names with non-alphabets are handled correctly
                Assert.True(AlloyConfiguration.IsServiceEnabled("Object-Storage"));

                // Test if disallowed service are blocked
                Assert.False(AlloyConfiguration.IsServiceEnabled("Audit"));

                // Test if Service Provider is set
                Assert.Equal("foo", AlloyConfiguration.OciAlloyProvider);

                // Check that known hard coded Regions exist
                Assert.NotNull(Region.FromRegionCodeOrId("us-phoenix-1"));
                Assert.NotNull(Region.FromRegionCodeOrId("us-foo1-alloy"));
            }
            finally
            {
                File.Delete(alloyConfigPath);
                Environment.SetEnvironmentVariable("OCI_ALLOY_REGION_COEXIST", "False");
                //reset Alloy Config
                AlloyConfiguration.ReInitialize();
            }
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestNoAlloyConfigPresentTest()
        {
            try
            {
                Environment.SetEnvironmentVariable("OCI_ALLOY_CONFIG_FILE_PATH", "~/.oci/test3-alloy-config.json");

                //re-init Alloy Config
                AlloyConfiguration.ReInitialize();
                // Test OciEnabledServiceSet exists and is Empty
                Assert.True(AlloyConfiguration.OciEnabledServiceSet.Count == 0);

                // Test all service enabled
                Assert.True(AlloyConfiguration.IsServiceEnabled("audit"));

                // Test if Service Provider is set
                Assert.Equal("", AlloyConfiguration.OciAlloyProvider);

            }
            finally
            {
                //reset Alloy Config
                AlloyConfiguration.ReInitialize();
            }
        }
    }
}