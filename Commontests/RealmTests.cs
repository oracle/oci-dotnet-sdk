/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IO;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;

using Oci.Common.Model;

using Newtonsoft.Json;
using Xunit;

namespace Oci.Common
{
    [ExcludeFromCodeCoverage]
    public class RealmTests : BaseTest
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private static readonly string NEW_REALM_ID = "foo";
        private static readonly string NEW_SECOND_LEVEL_DOMAIN = "oracle-foo-cloud.com";

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void NoDuplicateRealmId()
        {
            var realmIds = new HashSet<string>();
            foreach (Realm realm in Realm.Values())
            {
                Assert.DoesNotContain(realm.RealmId, realmIds);
                realmIds.Add(realm.RealmId);
            }
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void KnownRealms()
        {
            Assert.Equal("oc1", Realm.OC1.RealmId);
            Assert.Equal("oraclecloud.com", Realm.OC1.SecondLevelDomain);
            Assert.Equal("oc2", Realm.OC2.RealmId);
            Assert.Equal("oraclegovcloud.com", Realm.OC2.SecondLevelDomain);
            Assert.Equal("oc3", Realm.OC3.RealmId);
            Assert.Equal("oraclegovcloud.com", Realm.OC3.SecondLevelDomain);
            Assert.Equal("oc4", Realm.OC4.RealmId);
            Assert.Equal("oraclegovcloud.uk", Realm.OC4.SecondLevelDomain);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void CannotRegisterWithExistingRealmIdAndDifferentSecondLevelDomain()
        {
            Assert.Throws<ArgumentException>(() => Realm.Register(Realm.OC1.RealmId, NEW_SECOND_LEVEL_DOMAIN));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void ExistingRealmNotRegisteredAgain()
        {
            var realmsCount = Realm.Values().Length;
            Realm.Register(Realm.OC1.RealmId, Realm.OC1.SecondLevelDomain);
            Assert.Equal(realmsCount, Realm.Values().Length);
            var realm = Realm.ValueOf(Realm.OC1.RealmId);
            Assert.Equal(Realm.OC1.RealmId, realm.RealmId);
            Assert.Equal(Realm.OC1.SecondLevelDomain, realm.SecondLevelDomain);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void RegisterNewRealm()
        {
            Realm.Register(NEW_REALM_ID, NEW_SECOND_LEVEL_DOMAIN);
            var realm = Realm.ValueOf(NEW_REALM_ID);
            Assert.Equal(NEW_REALM_ID, realm.RealmId);
            Assert.Equal(NEW_SECOND_LEVEL_DOMAIN, realm.SecondLevelDomain);
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void ValidateAllKnownRealms()
        {
            var regionsJsonFile = "Regions.json";
            Assert.True(File.Exists(regionsJsonFile), $"Regions json file \"{regionsJsonFile}\" not found.");
            try
            {
                var content = File.ReadAllText(regionsJsonFile);
                Assert.True(!String.IsNullOrEmpty(content), $"Regions json file \"{regionsJsonFile}\" is empty.");

                var allRegions = JsonConvert.DeserializeObject<List<RegionSchema>>(content);
                Assert.True(allRegions != null, $"Failed to get regions information from \"{regionsJsonFile}\".");
                List<string> realms = new List<string>();
                foreach (var region in Region.Values())
                {
                    if (!realms.Contains(region.Realm.RealmId.ToLower()))
                    {
                        realms.Add(region.Realm.RealmId.ToLower());
                    }
                }
                foreach (RegionSchema region in allRegions)
                {
                    if (region != null && region.isValid())
                    {
                        Assert.True(realms.Contains(region.realmKey.ToLower()), $"Realm {region.realmKey} not found in known regions.");
                    }
                }
            }
            catch (Exception e)
            {
                logger.Warn($"Exception in ValidateAllKnownRegions(): {e}");
            }
        }
    }
}
