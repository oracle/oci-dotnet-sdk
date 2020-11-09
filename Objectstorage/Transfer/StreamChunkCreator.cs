/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Oci.ObjectstorageService.Transfer
{
    /// <summary>
    /// Class to split the original stream into multiple smaller streams based on chunk length
    /// and provides an iterator to iterate over the chunks.
    /// </summary>
    public class StreamChunkCreator : IEnumerable<Stream>
    {
        public StreamChunkCreator(Stream SourceStream, long ChunkLength)
        {
            if (SourceStream == null || SourceStream.Length < ChunkLength)
            {
                throw new ArgumentException($"Sourcestream cannot be null or length {SourceStream.Length} must be greater than ChunkLength: {ChunkLength}");
            }
            this._sourceStream = SourceStream;
            this._chunkLength = ChunkLength;
        }

        public IEnumerator<Stream> GetEnumerator()
        {
            long contentLength = _sourceStream.Length;
            long bytesRead = 0;
            long bytesToBeRead = _chunkLength;

            while (bytesRead < contentLength)
            {
                var remainingBytes = contentLength - bytesRead;
                if (remainingBytes <= _chunkLength)
                {
                    bytesToBeRead = remainingBytes;
                }
                var chunk = new byte[bytesToBeRead];
                bytesRead += _sourceStream.Read(chunk, 0, (int)bytesToBeRead);

                yield return new MemoryStream(chunk);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private readonly Stream _sourceStream;
        private readonly long _chunkLength;
    }
}
