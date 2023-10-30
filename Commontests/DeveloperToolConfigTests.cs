/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

using Oci.Common.DeveloperToolConfigurations;
using Oci.Common.Utils;

using Xunit;

namespace Oci.Common
{
    [ExcludeFromCodeCoverage]
    public class DeveloperToolConfigTests : BaseTest
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly string developerToolConfigBlob = @"
            {
                ""regions"": [
                    {
                        ""realmKey"" : ""fooR1"",
                        ""realmDomainComponent"" : ""fooR1.com"",
                        ""regionKey"" : ""foo1"",
                        ""regionIdentifier"" : ""us-foo1-dev""
                    },
                    {
                        ""realmKey"" : ""fooR2"",
                        ""realmDomainComponent"" : ""fooR2.com"",
                        ""regionKey"" : ""foo2"",
                        ""regionIdentifier"" : ""us-foo2-dev""
                    }
                ],
                ""services"": [
                    ""core"",
                    ""identity"",
                    ""apigateway"",
                    ""object-storage""
                ],
                ""developerToolConfigurationProvider"": ""foo"",
                ""allowOnlyDeveloperToolConfigurationRegions"": ""false""
            }";

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestDeveloperToolConfigTestWithOnlyDeveloperConfigRegionsEnabled()
        {
            Environment.SetEnvironmentVariable("OCI_ALLOW_ONLY_DEVELOPER_TOOL_CONFIGURATION_REGIONS", "True");
            Environment.SetEnvironmentVariable("OCI_DEVELOPER_TOOL_CONFIGURATION_FILE_PATH", "~/.oci/test1-developer-tool-config.json");
            Directory.CreateDirectory(FileUtils.ExpandUserHome(Path.Combine("~", ".oci")));
            var developerToolConfigPath = FileUtils.ExpandUserHome(Path.Combine("~", ".oci", "test1-developer-tool-config.json"));
            try
            {
                File.WriteAllText(developerToolConfigPath, developerToolConfigBlob);
                // Check if file written successfully
                Assert.True(File.Exists(developerToolConfigPath));

                //re-init developerTool Config
                DeveloperToolConfiguration.ReInitialize();
                // Test Service exists in OciEnabledServiceSet
                Assert.Contains("core", DeveloperToolConfiguration.OciEnabledServiceSet);

                // Test if service names with non-alphabets are handled correctly
                Assert.True(DeveloperToolConfiguration.IsServiceEnabled("Object-Storage"));

                // Test if disallowed service are blocked
                Assert.False(DeveloperToolConfiguration.IsServiceEnabled("Audit"));

                // Test if Service Provider is set
                Assert.Equal("foo", DeveloperToolConfiguration.DeveloperToolConfigurationProvider);

                // Check that known hard coded regions are removed
                Assert.DoesNotContain(Region.US_ASHBURN_1, Region.Values());

                // Check developerToolConfig region exists
                Assert.True(Array.Exists(Region.Values(), region => region.RegionId.Equals("us-foo1-dev")));

            }
            finally
            {
                File.Delete(developerToolConfigPath);
                Environment.SetEnvironmentVariable("OCI_ALLOW_ONLY_DEVELOPER_TOOL_CONFIGURATION_REGIONS", "False");
                //reset developerToolConfigPath
                DeveloperToolConfiguration.ReInitialize();
            }
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestDeveloperToolConfigTestWithOnlyDeveloperToolConfigRegionsDisabled()
        {
            Environment.SetEnvironmentVariable("OCI_DEVELOPER_TOOL_CONFIGURATION_FILE_PATH", "~/.oci/test2-developer-tool-config.json");
            Directory.CreateDirectory(FileUtils.ExpandUserHome(Path.Combine("~", ".oci")));
            var developerToolConfigPath = FileUtils.ExpandUserHome(Path.Combine("~", ".oci", "test2-developer-tool-config.json"));
            try
            {
                File.WriteAllText(developerToolConfigPath, developerToolConfigBlob);
                Assert.True(File.Exists(developerToolConfigPath));

                //re-init Developer Tool Config
                DeveloperToolConfiguration.ReInitialize();

                // Test Service exists in OciEnabledServiceSet
                Assert.Contains("core", DeveloperToolConfiguration.OciEnabledServiceSet);

                // Test if service names with non-alphabets are handled correctly
                Assert.True(DeveloperToolConfiguration.IsServiceEnabled("Object-Storage"));

                // Test if disallowed service are blocked
                Assert.False(DeveloperToolConfiguration.IsServiceEnabled("Audit"));

                // Test if Service Provider is set
                Assert.Equal("foo", DeveloperToolConfiguration.DeveloperToolConfigurationProvider);

                // Check that known hard coded Regions exist
                Assert.NotNull(Region.FromRegionCodeOrId("us-phoenix-1"));
                Assert.NotNull(Region.FromRegionCodeOrId("us-foo1-dev"));
            }
            finally
            {
                File.Delete(developerToolConfigPath);
                //reset developerToolConfigPath Config
                DeveloperToolConfiguration.ReInitialize();
            }
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestNoDeveloperToolConfigPresentTest()
        {
            try
            {
                Environment.SetEnvironmentVariable("OCI_DEVELOPER_TOOL_CONFIGURATION_FILE_PATH", "~/.oci/test3-developer-tool-config.json");

                //re-init DeveloperTool Config
                DeveloperToolConfiguration.ReInitialize();
                // Test OciEnabledServiceSet exists and is Empty
                Assert.True(DeveloperToolConfiguration.OciEnabledServiceSet.Count == 0);

                // Test all service enabled
                Assert.True(DeveloperToolConfiguration.IsServiceEnabled("audit"));

                // Test if Service Provider is set
                Assert.Equal("", DeveloperToolConfiguration.DeveloperToolConfigurationProvider);

            }
            finally
            {
                //reset DeveloperTool Config
                DeveloperToolConfiguration.ReInitialize();
            }
        }
    }
}