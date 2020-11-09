using System;
using System.Runtime.CompilerServices;

namespace Oci.ObjectstorageService.Transfer
{
    /// <summary>
    /// A thread-safe utility class which invokes UploadManager.OnProgress based on
    /// bytes read from stream from multiple threads.
    /// </summary>
    public class ProgressTracker
    {
        public ProgressTracker(UploadManager.OnProgress onProgress, long totalBytes)
        {
            this._onProgress = onProgress;
            this._totalBytes = totalBytes;
        }

        /// <summary>
        /// Progress Callback which should be called when bytes are read from the Stream.
        /// </summary>
        /// <param name="bytesRead">Bytes Read</param>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void OnRead(long bytesRead)
        {
            _totalBytesRead += bytesRead;
            if (_totalBytesRead < 0 || _totalBytesRead > _totalBytes)
            {
                throw new InvalidOperationException($"total bytes read {_totalBytesRead} cannot be less than zero or greater than total bytes {_totalBytes}");
            }

            _onProgress.Invoke(_totalBytesRead, _totalBytes);
        }

        /// <summary>
        /// Invalidate the bytes read from the stream.
        /// </summary>
        /// <param name="bytes">Bytes to invalidate</param>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void InvalidateBytesRead(long bytes)
        {
            if (bytes < 0 || bytes > _totalBytesRead)
            {
                throw new InvalidOperationException($"cannot Invalidate bytes {bytes}");
            }

            _totalBytesRead -= bytes;
            _onProgress.Invoke(_totalBytesRead, _totalBytes);
        }

        /// <summary>
        /// Reset the bytes read.
        /// </summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void Reset()
        {
            _totalBytesRead = 0;
            _onProgress.Invoke(_totalBytesRead, _totalBytes);
        }

        private readonly UploadManager.OnProgress _onProgress;
        private readonly long _totalBytes;
        private long _totalBytesRead;
    }
}
