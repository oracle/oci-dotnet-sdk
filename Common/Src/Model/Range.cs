/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

﻿using System;

namespace Oci.Common.Model
{
    // Class specifying a range-request is being made. Request mostly follows
    // https://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.35, except only
    // one range is allowed. For the purposes of the SDK, three types of requests
    // are supported:
    // <ol>
    // <li>Exact range (0-100): All bytes in the given range</li>
    // <li>Starts-at (100-): All bytes >= the start byte</li>
    // <li>Last (-100): The last X bytes</li>
    // </ol>
    // <p>
    // Also used to represent the range returned by the server (including the full
    // content length, if known).
    public class Range
    {
        private readonly string HEADER_FORMAT = "bytes={0}-{1}";
        private readonly string START_ONLY_HEADER_FORMAT = "bytes={0}-";
        private readonly string END_ONLY_HEADER_FORMAT = "bytes=-{0}";

        public long? StartByte { get; set; }
        public long? EndByte { get; set; }
        public long? ContentLength { get; set; }

        public override string ToString()
        {
            if (StartByte.HasValue && EndByte.HasValue)
            {
                return string.Format(HEADER_FORMAT, StartByte, EndByte);
            }

            if (StartByte.HasValue)
            {
                return string.Format(START_ONLY_HEADER_FORMAT, StartByte);
            }

            if (EndByte.HasValue)
            {
                return string.Format(END_ONLY_HEADER_FORMAT, EndByte);
            }
            return "";
        }

        /// <summary>
        /// Parse the "content-range" header per https://tools.ietf.org/html/rfc7233#section-4.2.
        /// sample content-range header value: bytes 1-5/6
        /// </summary>
        public static Range ParseRange(string rangeStr)
        {
            //remove bytes string
            rangeStr = rangeStr.Trim().Replace("bytes", "");
            var parts = rangeStr.Split('/');

            if (parts.Length != 2)
            {
                throw new ArgumentException($"Cannot convert string: {rangeStr} to Range object");
            }

            var byteRanges = parts[0].Trim().Split('-');
            if (byteRanges.Length != 2)
            {
                throw new ArgumentException($"Cannot convert string: {rangeStr} to Range object");
            }

            var range = new Range();
            if (long.TryParse(parts[1].Trim(), out var longValue))
            {
                range.ContentLength = longValue;
            }

            if (long.TryParse(byteRanges[0].Trim(), out longValue))
            {
                range.StartByte = longValue;
            }

            if (long.TryParse(byteRanges[1].Trim(), out longValue))
            {
                range.EndByte = longValue;
            }

            return range;
        }
    }
}
