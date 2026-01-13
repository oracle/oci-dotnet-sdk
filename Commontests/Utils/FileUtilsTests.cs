/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Oci.Common.Utils
{
    [ExcludeFromCodeCoverage]
    public class FileUtilsTests : BaseTest
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void ExpandUserHome_TildeNoHomeShortcut()
        {
            Assert.Equal("~foo/bar", FileUtils.ExpandUserHome("~foo/bar"));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void ExpandUserHome_NoHomeShortcut()
        {
            Assert.Equal("/foo/bar", FileUtils.ExpandUserHome("/foo/bar"));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void ExpandUserHome_WithHomeShortcut()
        {
            string expandedPath = FileUtils.ExpandUserHome("~/foobar");
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                string homeDrive = Environment.GetEnvironmentVariable("HOMEDRIVE");
                string homePath = Environment.GetEnvironmentVariable("HOMEPATH");
                Assert.Equal(homeDrive + homePath + "\\foobar", expandedPath);
            }
            else
            {
                string homeDir = Environment.GetEnvironmentVariable("HOME");
                Assert.Equal(homeDir + "/foobar", expandedPath);
            }
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void CorrectPath_Windows()
        {
            Assert.Equal("\\foo\\bar", FileUtils.CorrectPath(PlatformID.Win32NT, "/foo/bar"));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void CorrectPath_NotWindows()
        {
            Assert.Equal("/foo/bar", FileUtils.CorrectPath(PlatformID.Unix, "/foo/bar"));
        }
    }
}
