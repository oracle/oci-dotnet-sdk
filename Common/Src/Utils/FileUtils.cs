/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IO;

namespace Oci.Common.Utils
{
    public class FileUtils
    {
        public static string ExpandUserHome(string path)
        {
            if (path.StartsWith("~/") || path.StartsWith("~\\"))
            {
                return Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile), CorrectPath(Environment.OSVersion.Platform, path.Substring(2)));
            }
            else
            {
                return path;
            }
        }

        public static string CorrectPath(PlatformID platformID, string path)
        {
            // https://docs.microsoft.com/en-us/dotnet/api/system.platformid?view=netframework-4.8
            // PlatformID is an enum. There are values that are no longer in use. So we are only detecting Wind32NT.
            // Otherwise we assume it is either Unix or MacOSX.
            if (platformID == PlatformID.Win32NT)
            {
                path = path.Replace('/', '\\');
            }
            return path;
        }
    }
}
