/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Oci.Common.Alloy;

namespace Oci.Common
{
    /// <summary>
    /// Class containing all Identity realms.
    /// <br/>
    /// Accounts (tenancies) are per Realm.
    /// </summary>
    public partial class Realm
    {
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private static readonly Dictionary<string, Realm> KNOWN_REALMS = new Dictionary<string, Realm>();
        private static readonly Dictionary<string, Realm> ALLOY_REALMS = new Dictionary<string, Realm>();

        /// <summary>The id of a realm.</summary>
        public string RealmId { get; }
        /// <summary>The second level domain of a realm.</summary>
        public string SecondLevelDomain { get; }

        public static readonly string OCI_DEFAULT_REALM = "OCI_DEFAULT_REALM";

        private Realm(string realmId, string secondlevelDomain, bool isAlloyRealm = false)
        {
            if (realmId == null || secondlevelDomain == null)
            {
                throw new ArgumentNullException();
            }

            RealmId = realmId;
            SecondLevelDomain = secondlevelDomain;
            AddRealm(this, isAlloyRealm);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private void AddRealm(Realm realm, bool isAlloyRealm = false)
        {
            if (isAlloyRealm)
            {
                ALLOY_REALMS.Add(realm.RealmId, realm);
            }
            else
            {
                KNOWN_REALMS.Add(realm.RealmId, realm);
            }
        }

        /// <summary>All known Realms in this version of SDK.</summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Realm[] Values()
        {
            if (AlloyConfiguration.UseOnlyAlloyRegions())
            {
                Realm[] alloy_realms = new Realm[ALLOY_REALMS.Count];
                ALLOY_REALMS.Values.CopyTo(alloy_realms, 0);
                return alloy_realms;
            }
            Realm[] realms = new Realm[KNOWN_REALMS.Count + ALLOY_REALMS.Count];
            KNOWN_REALMS.Values.CopyTo(realms, 0);
            ALLOY_REALMS.Values.CopyTo(realms, KNOWN_REALMS.Count);
            return realms;
        }

        /// <summary>
        /// Returns the Realm object matching the specified id. The id must
        /// match exactly. (Extraneous whitespace characters are not permitted.)
        /// </summary>
        /// <param name="realmId">The id of the realm to retrieve.</param>
        /// <returns>The Realm object matching the specified name, if available.</returns>
        /// <exception>Thrown when realmId is invalid or not found.</exception>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Realm ValueOf(string realmId)
        {
            if (string.IsNullOrEmpty(realmId))
            {
                throw new ArgumentNullException("Realm Id cannot be null or empty.");
            }
            if (AlloyConfiguration.UseOnlyAlloyRegions())
            {
                if (!ALLOY_REALMS.TryGetValue(realmId, out Realm alloyRealm))
                {
                    throw new ArgumentNullException($"Unknown Alloy realm with Id {realmId}.");
                }
                return alloyRealm;
            }
            else
            {
                if (!KNOWN_REALMS.TryGetValue(realmId, out Realm realm))
                {
                    if (!ALLOY_REALMS.TryGetValue(realmId, out Realm alloyRealm))
                    {
                        throw new ArgumentNullException($"Unknown realm with Id {realmId}.");
                    }
                    return alloyRealm;
                }
                return realm;
            }
        }

        /// <summary>Register a new Realm. Allow the SDK to be forward compatible with unreleased realms.</summary>
        /// <param name="realmId">The realm id.</param>
        /// <param name="secondlevelDomain">The second level domain of the realm.</param>
        /// <param name="isAlloyRealm">The bool value denoting if the Realm is an Alloy Realm or not. Set to false by default.</param>
        /// <returns>The registered Realm (or existing one if found).</returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Realm Register(string realmId, string secondlevelDomain, bool isAlloyRealm = false)
        {
            // Check if this realm is already registered. If found, return the existing realm.
            foreach (var realm in Values())
            {
                if (realm.RealmId.Equals(realmId))
                {
                    if (!realm.SecondLevelDomain.Equals(secondlevelDomain))
                    {
                        throw new ArgumentException($"Realm with realmId {realmId} is already registered with {realm.SecondLevelDomain}.");
                    }
                    return realm;
                }
            }
            // If the realm is not yet registered, call constructor.
            return new Realm(realmId, secondlevelDomain, isAlloyRealm);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void ResetAlloyConfig()
        {
            ALLOY_REALMS.Clear();
        }
    }
}
