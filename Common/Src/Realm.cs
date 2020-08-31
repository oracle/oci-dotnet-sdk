/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Oci.Common
{
    /// <summary>
    /// Class containing all Identity realms.
    /// <br/>
    /// Accounts (tenancies) are per Realm.
    /// </summary>
    public class Realm
    {
        private static readonly Dictionary<string, Realm> KNOWN_REALMS = new Dictionary<string, Realm>();
        public static readonly Realm OC1 = new Realm("oc1", "oraclecloud.com");
        public static readonly Realm OC2 = new Realm("oc2", "oraclegovcloud.com");
        public static readonly Realm OC3 = new Realm("oc3", "oraclegovcloud.com");
        public static readonly Realm OC4 = new Realm("oc4", "oraclegovcloud.uk");
        public static readonly Realm OC8 = new Realm("oc8", "oraclecloud8.com");

        /// <summary>The id of a realm.</summary>
        public string RealmId { get; }
        /// <summary>The second level domain of a realm.</summary>
        public string SecondLevelDomain { get; }

        private Realm(string realmId, string secondlevelDomain)
        {
            if (realmId == null || secondlevelDomain == null)
            {
                throw new ArgumentNullException();
            }

            RealmId = realmId;
            SecondLevelDomain = secondlevelDomain;
            AddRealm(this);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private void AddRealm(Realm realm)
        {
            KNOWN_REALMS.Add(realm.RealmId, realm);
        }

        /// <summary>All known Realms in this versino of SDK.</summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Realm[] Values()
        {
            Realm[] realms = new Realm[KNOWN_REALMS.Count];
            KNOWN_REALMS.Values.CopyTo(realms, 0);
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
            if (!KNOWN_REALMS.TryGetValue(realmId, out Realm realm))
            {
                throw new ArgumentNullException($"Unknown realm with Id {realmId}.");
            }
            return realm;
        }

        /// <summary>Register a new Realm. Allow the SDK to be forward compatible with unreleased realms.</summary>
        /// <param name="realmId">The realm id.</param>
        /// <param name="secondlevelDomain">The second level domain of the realm.</param>
        /// <returns>The registered Realm (or existing one if found).</returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Realm Register(string realmId, string secondlevelDomain)
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
            return new Realm(realmId, secondlevelDomain);
        }
    }
}
