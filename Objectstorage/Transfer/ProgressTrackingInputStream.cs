/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.IO;

namespace Oci.ObjectstorageService.Transfer
{
    /// <summary>
    /// Wrapper for Stream which provides progress callbacks on reading stream.
    /// </summary>
    public class ProgressTrackingInputStream : Stream
    {
        public ProgressTrackingInputStream(Stream stream, ProgressTracker progressTracker)
        {
            this._sourceStream = stream;
            this._progressTracker = progressTracker;
        }

        public override bool CanRead => _sourceStream.CanRead;

        public override bool CanSeek => _sourceStream.CanSeek;

        public override bool CanWrite => _sourceStream.CanWrite;

        public override long Length => _sourceStream.Length;

        public override long Position { get => _sourceStream.Position; set => _sourceStream.Position = value; }

        public override void Flush()
        {
            _sourceStream.Flush();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (_sourceStream.Position == 0 && totalBytesRead > 0)
            {
                // this condition is reached when we try to re-read the stream. In such cases,
                // we have to invalidate the bytes that are all ready been read.
                _logger.Debug("Stream re-read, Invalidating the bytes which are already read!");
                _progressTracker.InvalidateBytesRead(totalBytesRead);
            }
            int bytesRead = _sourceStream.Read(buffer, offset, count);
            _progressTracker.OnRead(bytesRead);
            totalBytesRead += bytesRead;

            return bytesRead;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return _sourceStream.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            _sourceStream.SetLength(value);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            _sourceStream.Write(buffer, offset, count);
        }

        private readonly Stream _sourceStream;
        private readonly ProgressTracker _progressTracker;
        private long totalBytesRead;

        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();
    }
}
