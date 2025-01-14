/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Diagnostics.CodeAnalysis;
using Oci.Common;
using Xunit;

namespace Oci.ObjectstorageService.Transfer
{
    [ExcludeFromCodeCoverage]
    public class ProgressTrackerTests : BaseTest
    {
        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void Verify()
        {
            long totalBytes = 15;
            var tracker = new ProgressTracker(OnProgress, totalBytes);

            for (int i = 0; i < totalBytes; i++)
            {
                tracker.OnRead(1);
                Assert.Equal(bytesReadBack, i + 1);
            }

            Assert.Equal(bytesReadBack, totalBytes);

            tracker.InvalidateBytesRead(5);

            Assert.Equal(10, bytesReadBack);

            tracker.Reset();

            Assert.Equal(0, bytesReadBack);
        }

        private void OnProgress(long bytesRead, long totalBytes)
        {
            bytesReadBack = bytesRead;
        }

        private long bytesReadBack = 0;
    }
}
