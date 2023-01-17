/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Oci.Common.Internal;
using Oci.Common.Model;
using Oci.Common.Utils;

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

        /// <summary>The id of a realm.</summary>
        public string RealmId { get; }
        /// <summary>The second level domain of a realm.</summary>
        public string SecondLevelDomain { get; }

        public static readonly string OCI_DEFAULT_REALM = "OCI_DEFAULT_REALM";

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

        /// <summary>Return the custom second level domain if set via OCI_DEFAULT_REALM else return OC1</summary>
        /// <returns>The Fallback Realm to register an unknown Region.</returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static string GetFallbackRealm()
        {
            string customSecondLevelDomain = Environment.GetEnvironmentVariable(OCI_DEFAULT_REALM);
            if (!String.IsNullOrWhiteSpace(customSecondLevelDomain))
            {
                // Read a user settable second level domain for the endpoint
                logger.Info($"Read the second level domain:{customSecondLevelDomain} from the {OCI_DEFAULT_REALM} environment variable");
            }
            else
            {
                // Else we need to fall back to OC1 SLD.
                logger.Debug($"{OCI_DEFAULT_REALM} environment variable not set, will assume it's in Realm OC1");
                customSecondLevelDomain = Realm.OC1.SecondLevelDomain;
            }
            return customSecondLevelDomain;
        }
    }
}
