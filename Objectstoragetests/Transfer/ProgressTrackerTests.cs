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
