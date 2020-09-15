/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using Xunit;

namespace Oci.Common
{
    [ExcludeFromCodeCoverage]
    public class RegionTests : BaseTest
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

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
            Region newRegion = Region.Register(existingRegionId, Realm.OC1);
            Assert.True(AreRegionsSame(newRegion, existingRegion));
            Assert.Equal(regionsCount, Region.Values().Length);
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
