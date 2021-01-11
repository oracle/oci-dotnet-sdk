/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Oci.Common
{
    [ExcludeFromCodeCoverage]
    public class OCIDTests : BaseTest
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private readonly string validOcid = "ocid1.user.oc1..aaaaaaaaizi8k3lbfv747ul6qwazrutncoe8zciazibypbjtkxaiecoic1dq";
        private readonly string validLegacyOcid = "ocidv1:tenancy:oc1:phx:1829406592360:aaaaaaaab4faaopv32ecohhklpvjq463pu";
        private readonly string[] invalidOcids = {
            "ocid1.user.oc1.",
            "ocid1.user.oc1.adsfasfsafdf",
            "ocid1.user.oc1.1354aasdf." };

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void ValidOcid()
        {
            Assert.True(OCID.IsValidOCID(validOcid));
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void ValidLegacyOcid()
        {
            Assert.True(OCID.IsValidOCID(validLegacyOcid));
        }

        [Theory]
        [InlineData("ocid1.user.oc1.")]
        [InlineData("ocid1.user.oc1.adsfasfsafdf")]
        [InlineData("ocid1.user.oc1.1354aasdf.")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void InvalidOcid(string ocid)
        {
            Assert.False(OCID.IsValidOCID(ocid), $"{ocid} is not a valid OCID.");
        }
    }
}
