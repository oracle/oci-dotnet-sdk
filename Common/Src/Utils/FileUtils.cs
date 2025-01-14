/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IO;
using System.Security;

namespace Oci.Common.Utils
{
    /// <summary>Utility class to process file paths.</summary>
    public class FileUtils
    {
        /// <summary>Expands user home path in file path.</summary>
        /// <param name="path">The file path to be processed.</param>
        /// <returns>The expanded file path with home symbol (~) being replaced by full user home path.</returns>
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

        /// <summary>
        /// Fixes the file path separator for current OS.
        /// <br/>
        /// https://docs.microsoft.com/en-us/dotnet/api/system.platformid?view=netframework-4.8
        /// <br/>
        /// PlatformID is an enum. There are values that are no longer in use. So we are only detecting Wind32NT.
        /// Otherwise we assume it is either Unix or MacOSX.
        /// </summary>
        /// <param name="platformID">The platform id containing OS information.</param>
        /// <param name="path">The file path to be processed.</param>
        /// <returns>The file path with correct file separator for current OS.</returns>

        public static string CorrectPath(PlatformID platformID, string path)
        {
            if (platformID == PlatformID.Win32NT)
            {
                path = path.Replace('/', '\\');
            }
            return path;
        }

        public static SecureString GetSecurePassphraseFromFile(string passphrasePath)
        {
            try
            {
                return StringUtils.StringToSecureString(File.ReadAllText(passphrasePath));
            }
            catch (ArgumentException)
            {
                throw new ArgumentException($"Invalid path for passphrasePath {passphrasePath}");
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException($"File not found at passphrasePath: {passphrasePath}");
            }
            catch (IOException)
            {
                throw new IOException($"Error reading file at passphrasePath: {passphrasePath}");
            }
        }
    }
}
