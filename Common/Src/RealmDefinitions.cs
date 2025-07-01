/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

namespace Oci.Common
{
    /// <summary>
    /// Class containing all Identity realms.
    /// <br/>
    /// Accounts (tenancies) are per Realm.
    /// </summary>
    public partial class Realm
    {
        public static readonly Realm OC1 = new Realm("oc1", "oraclecloud.com");
        public static readonly Realm OC2 = new Realm("oc2", "oraclegovcloud.com");
        public static readonly Realm OC3 = new Realm("oc3", "oraclegovcloud.com");
        public static readonly Realm OC4 = new Realm("oc4", "oraclegovcloud.uk");
        public static readonly Realm OC8 = new Realm("oc8", "oraclecloud8.com");
        public static readonly Realm OC9 = new Realm("oc9", "oraclecloud9.com");
        public static readonly Realm OC10 = new Realm("oc10", "oraclecloud10.com");
        public static readonly Realm OC14 = new Realm("oc14", "oraclecloud14.com");
        public static readonly Realm OC20 = new Realm("oc20", "oraclecloud20.com");
        public static readonly Realm OC19 = new Realm("oc19", "oraclecloud.eu");
        public static readonly Realm OC24 = new Realm("oc24", "oraclecloud24.com");
        public static readonly Realm OC21 = new Realm("oc21", "oraclecloud21.com");
        public static readonly Realm OC26 = new Realm("oc26", "oraclecloud26.com");
        public static readonly Realm OC15 = new Realm("oc15", "oraclecloud15.com");
        public static readonly Realm OC29 = new Realm("oc29", "oraclecloud29.com");
        public static readonly Realm OC23 = new Realm("oc23", "oraclecloud23.com");
        public static readonly Realm OC35 = new Realm("oc35", "oraclecloud35.com");
        public static readonly Realm OC42 = new Realm("oc42", "oraclecloud42.com");
    }
}