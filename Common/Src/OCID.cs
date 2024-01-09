/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Text.RegularExpressions;

namespace Oci.Common
{
    /// <summary>
    /// Oracle Cloud Infrastructure unique ID.
    /// See <see cref="https://docs.cloud.oracle.com/Content/GSG/Concepts/concepts.htm#ocid"/>
    /// </summary>
    public class OCID
    {
        private static readonly Regex OCID_PATTERN = new Regex(@"^([0-9a-zA-Z-_]+[.:])([0-9a-zA-Z-_]*[.:]){3,}([0-9a-zA-Z-_]+)$");

        /// <summary>
        /// Test if the given OCID matches the expected pattenr for OCIDs.
        /// <param name="ocid">The string to test.</param>
        /// <returns>True if it matches the pattern; false if not.</returns>
        /// </summary>
        public static bool IsValidOCID(string ocid)
        {
            return OCID_PATTERN.IsMatch(ocid);
        }
    }
}
