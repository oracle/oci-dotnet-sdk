/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;

using Oci.Common.Model;
using Oci.Common.Utils;

using Newtonsoft.Json;
using Xunit;

[assembly: CollectionBehavior(DisableTestParallelization = true)]
namespace Oci.Common
{
    [ExcludeFromCodeCoverage]
    public class RegionTests : BaseTest
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void RegisterNewRegionFromEnvVariable()
        {
            Region.ResetEnvironmentVariableInUse();
            string regionMetadataEnvVar = "{ \"realmKey\" : \"RTC\",\"realmDomainComponent\" : \"foobar-oraclecloud.com\",\"regionKey\" : \"hhh\",\"regionIdentifier\" : \"us-hhh-1\"}";
            Environment.SetEnvironmentVariable("OCI_REGION_METADATA", regionMetadataEnvVar);
            if (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("OCI_REGION_METADATA")))
            {
                Region regionFromEnvVar = Region.FromRegionCodeOrId("hhh");
                Region US_HHH_TST = Region.Register("us-hhh-1", Realm.Register("RTC", "foobar-oraclecloud.com"), "hhh");
                Assert.True(AreRegionsSame(regionFromEnvVar, US_HHH_TST));
            }
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void RegisterNewRegionFromConfigFileTest()
        {
            Region.ResetConfigFileInUse();
            string regionBlob = "[{ \"realmKey\" : \"RTC\",\"realmDomainComponent\" : \"foobar-oraclecloud.com\",\"regionKey\" : \"atl\",\"regionIdentifier\" : \"ap-atl-1\"}]";
            DirectoryInfo dir = Directory.CreateDirectory(FileUtils.ExpandUserHome(Path.Combine("~", ".oci")));
            var regionConfigFilePath = FileUtils.ExpandUserHome(Path.Combine("~", ".oci", "regions-config.json"));
            try
            {
                File.WriteAllText(regionConfigFilePath, regionBlob);
                if (File.Exists(regionConfigFilePath))
                {
                    Region regionFromConfigFile = Region.FromRegionCodeOrId("atl");
                    Region US_ATLANTA_TST = Region.Register("ap-atl-1", Realm.Register("RTC", "foobar-oraclecloud.com"), "atl");
                    Assert.True(AreRegionsSame(regionFromConfigFile, US_ATLANTA_TST));
                }
            }
            catch (Exception e)
            {
                Assert.True(false, $"RegisterNewRegionFromConfigFileTest failed due to exception:{e}");
            }
            finally
            {
                File.Delete(regionConfigFilePath);
            }
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void RegisterFromIMDS()
        {
            // if IMDS can't be reached, this test takes >15 seconds
            Region regionFromIMDS = Region.RegisterRegionFromInstanceMetadataService();
            RegionSchema regionSchemaFromIMDS = Region.GetRegionSchemaFromInstanceMetaDataService();
            if (regionFromIMDS != null && regionSchemaFromIMDS != null)
            {
                Assert.Equal(regionFromIMDS.RegionId, regionSchemaFromIMDS.regionIdentifier.ToLower());
                Assert.Equal(regionFromIMDS.RegionCode, regionSchemaFromIMDS.regionKey.ToLower());
                Assert.Equal(regionFromIMDS.Realm.RealmId, regionSchemaFromIMDS.realmKey);
                Assert.Equal(regionFromIMDS.Realm.SecondLevelDomain, regionSchemaFromIMDS.realmDomainComponent);
            }
            else
            {
                Assert.True(regionFromIMDS == null && regionSchemaFromIMDS == null);
            }
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void ValidRegions()
        {
            foreach (var region in Region.Values())
            {
                logger.Info($"Validating region {region.RegionId}");
                Assert.True(AreRegionsSame(region, Region.FromRegionId(region.RegionId)));
            }
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void RegisterNewRegion()
        {
            string newRegionId = "us-foo-1";
            int regionsCount = Region.Values().Length;
            Region newRegion = Region.Register(newRegionId, Realm.OC3);
            Assert.Equal(newRegionId, newRegion.RegionId);
            Assert.Null(newRegion.RegionCode);
            Assert.Equal(Realm.OC3.RealmId, newRegion.Realm.RealmId);
            Assert.Equal(Realm.OC3.SecondLevelDomain, newRegion.Realm.SecondLevelDomain);
            Assert.Equal(regionsCount + 1, Region.Values().Length);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void RegisterNewRegionWithRegionCode()
        {
            string newRegionId = "us-foo-2";
            string newRegionCode = "foo-region-code";
            int regionsCount = Region.Values().Length;
            Region newRegion = Region.Register(newRegionId, Realm.OC3, newRegionCode);
            Assert.Equal(newRegionId, newRegion.RegionId);
            Assert.Equal(newRegionCode, newRegion.RegionCode);
            Assert.Equal(Realm.OC3.RealmId, newRegion.Realm.RealmId);
            Assert.Equal(Realm.OC3.SecondLevelDomain, newRegion.Realm.SecondLevelDomain);
            Assert.Equal(regionsCount + 1, Region.Values().Length);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void RegisterExistingRegion()
        {
            string existingRegionId = "us-phoenix-1";
            int regionsCount = Region.Values().Length;
            Region existingRegion = Region.FromRegionId(existingRegionId);
            var existingRegionIds = new List<string>();
            foreach (var region in Region.Values())
            {
                existingRegionIds.Add(region.RegionId);
            }

            Region newRegion = Region.Register(existingRegionId, Realm.OC1);
            var newRegionIds = new List<string>();
            foreach (var region in Region.Values())
            {
                newRegionIds.Add(region.RegionId);
            }
            Assert.True(AreRegionsSame(newRegion, existingRegion));
            Assert.True(regionsCount == Region.Values().Length, $"Regions don't Match! \nExisting Regions: {String.Join(",", existingRegionIds)} \nNew Regions: {String.Join(",", newRegionIds)}");
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void RegisterWithExistingRegionIdDifferentRealm()
        {
            string existingRegionId = "us-phoenix-1";
            int regionsCount = Region.Values().Length;
            Assert.Throws<ArgumentException>(() => Region.Register(existingRegionId, Realm.OC2));
        }

        [Theory]
        [InlineData("us-phoenix-1", "phx")]
        [InlineData("eu-frankfurt-1", "fra")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void FromRegionIdOrCodeTest(string regionId, string regionCode)
        {
            var region = Region.FromRegionCodeOrId(regionId);
            Assert.Equal(regionId, region.RegionId);

            region = Region.FromRegionCodeOrId(regionCode);
            Assert.Equal(regionCode, region.RegionCode);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void FromRegionIdOrCodeExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => Region.FromRegionCodeOrId("invalid"));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void ValidateAllKnownRegions()
        {
            var regionsJsonFile = "Regions.json";
            Assert.True(File.Exists(regionsJsonFile), $"Regions json file \"{regionsJsonFile}\" not found.");
            try
            {
                var content = File.ReadAllText(regionsJsonFile);
                Assert.True(!String.IsNullOrEmpty(content), $"Regions json file \"{regionsJsonFile}\" is empty.");

                var allRegions = JsonConvert.DeserializeObject<List<RegionSchema>>(content);
                Assert.True(allRegions != null, $"Failed to get regions information from \"{regionsJsonFile}\".");
                List<string> region_ids = new List<string>();
                foreach (var region in Region.Values())
                {
                    region_ids.Add(region.RegionId.ToLower());
                }
                foreach (RegionSchema region in allRegions)
                {
                    if (region != null && region.isValid())
                    {
                        Assert.True(region_ids.Contains(region.regionIdentifier.ToLower()), $"Region {region.regionIdentifier} not found in known regions.");
                    }
                }
            }
            catch (Exception e)
            {
                logger.Warn($"Exception in ValidateAllKnownRegions(): {e}");
            }
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void testCustomSecondLevelDomain()
        {
            Environment.SetEnvironmentVariable(Region.OCI_DEFAULT_REALM, "foobar.com");
            Service service = new Service
            {
                ServiceName = "AUDIT",
                ServiceEndpointPrefix = "audit",
                ServiceEndpointTemplate = "https://audit.{region}.{secondLevelDomain}"
            };
            const string expectedEndpoint = "https://audit.xyz.foobar.com";
            Assert.Equal(Region.FormatDefaultRegionEndpoint(service, "xyz"), expectedEndpoint);
            Assert.Throws<ArgumentNullException>(() => Region.FormatDefaultRegionEndpoint(service, ""));
            Assert.Throws<ArgumentNullException>(() => Region.FormatDefaultRegionEndpoint(null, "xyz"));
        }

        private bool AreRegionsSame(Region r1, Region r2)
        {
            if (!r1.RegionId.Equals(r2.RegionId))
            {
                logger.Error($"RegionId: {r1.RegionId} : {r1.RegionId}");
                return false;
            }
            if (r1.RegionCode != null && !r1.RegionCode.Equals(r2.RegionCode))
            {
                logger.Error($"RegionCode: {r1.RegionCode} : {r1.RegionCode}");
                return false;
            }
            if (!r1.Realm.RealmId.Equals(r2.Realm.RealmId))
            {
                logger.Error($"Realm.RealmId: {r1.Realm.RealmId} : {r1.Realm.RealmId}");
                return false;
            }
            if (!r1.Realm.SecondLevelDomain.Equals(r2.Realm.SecondLevelDomain))
            {
                logger.Error($"Realm.RealmId: {r1.Realm.SecondLevelDomain} : {r1.Realm.SecondLevelDomain}");
                return false;
            }
            return true;
        }
    }
}
