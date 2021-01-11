/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Globalization;

namespace Oci.Common.Utils
{
    /// <summary>Utility class to handle DateTime serialization.</summary>
    public class HttpDateUtils
    {
        private static readonly string RFC3339_FORMAT = "yyyy-MM-dd'T'HH:mm:ss.fff'Z'";

        /// <summary>Converts a DateTime value into a string in RFC3339 format.</summary>
        /// <param name="dateTime">A DateTime value.</param>
        /// <returns>A string representation of the DateTime value in RFC3339 format.</returns>
        public static string ToRfc3339Format(DateTime dateTime)
        {
            return dateTime.ToString(RFC3339_FORMAT, DateTimeFormatInfo.InvariantInfo);
        }

        /// <summary>Parses a string into DateTime value.</summary>
        /// <param name="dateTime">A string representation of a DateTime value.</param>
        /// <returns>DateTime value parsed from the input string.</returns>
        public static DateTime ToDateTime(string dateTime)
        {
            return DateTime.Parse(dateTime, CultureInfo.InvariantCulture);
        }
    }
}
