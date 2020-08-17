/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Security;

namespace Oci.Common.Utils
{
    public class StringUtils
    {
        public static SecureString StringToSecureString(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return null;
            }
            var secureStr = new SecureString();
            for (int i = 0; i < str.Length; i++)
            {
                secureStr.AppendChar(str[i]);
            }
            return secureStr;
        }
    }
}
