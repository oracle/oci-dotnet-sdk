/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Oci.Common;
using Xunit;

namespace Oci.ObjectstorageService.Transfer
{
    [ExcludeFromCodeCoverage]
    public class MultipartManifestTests : BaseTest
    {
        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void Verify()
        {
            var failedParts = new List<int> { 1, 2, 3, 4, 5 };
            var completedParts = new List<int> { 6, 7, 8, 9, 10 };

            var manifest = new MultipartManifest("DummyId");

            foreach(var i in Enumerable.Range(1, 10))
            {
                manifest.RegisterTransfer(i);
            }

            foreach(var i in completedParts)
            {
                manifest.RegisterSuccess(i, new Responses.UploadPartResponse());
            }

            foreach(var i in failedParts)
            {
                manifest.RegisterFailure(i);
            }

            Assert.True(!manifest.ListCompletedParts()
                .Select(part => part.PartNum.Value)
                .Except(completedParts).Any());

            Assert.True(!manifest.ListFailedParts()
                .Except(failedParts).Any());
        }
    }
}
