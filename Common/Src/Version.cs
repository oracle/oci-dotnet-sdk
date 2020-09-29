/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

namespace Oci.Common
{
    public class Version
    {
        public static string MAJOR = "4";
        public static string MINOR = "6";
        public static string PATCH = "0";
        public static string TAG = "";

        public static string GetVersion()
        {
            string ver = $"{MAJOR}.{MINOR}.{PATCH}";
            return string.IsNullOrEmpty(TAG) ? ver : $"{ver}.{TAG}";
        }
    }
}
