/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;

namespace Oci.Common.Model
{
    /**
    * Class representing RegionSchema blob that can be used for parsing out region info details.
    */
    public class RegionSchema
    {
        public string realmKey { get; set; }
        public string realmDomainComponent { get; set; }
        public string regionKey { get; set; }
        public string regionIdentifier { get; set; }

        public bool isValid()
        {
            if (String.IsNullOrEmpty(realmKey)
                || String.IsNullOrEmpty(realmDomainComponent)
                || String.IsNullOrEmpty(regionIdentifier)
                || String.IsNullOrEmpty(regionKey))
            {
                return false;
            }
            return true;
        }
    }
}
