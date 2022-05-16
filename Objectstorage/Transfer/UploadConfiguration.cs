/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
namespace Oci.ObjectstorageService.Transfer
{
    public class UploadConfiguration
    {
        /// <summary>
        /// Length in MiB for each part of a multi-part upload. Default is 128
        /// </summary>
        public long LengthPerUploadPartInMiB
        {
            get { return _length; }
            set
            {
                ValidateLengthPerUploadPartInMiB(value);
                _length = value;
            }
        }

        /// <summary>
        /// Flag to indicate that multi-part uploads can be used. Default is true.
        /// </summary>
        public bool AllowMultipartUploads { get; set; } = true;

        /// <summary>
        /// The number of worker threads to use in parallel for uploading individual parts of a multipart upload.
        /// Defaults value is  3. Users can disable parallel part uploads by setting this value to 1.
        /// </summary>
        public int ParallelUploadCount { get; set; } = DEFAULT_PARALLEL_THREADS;

        /// <summary>
        /// Flag to indicate that uploads that fail should not be automatically aborted (client is reponsible for always cleaning up
        /// failed uploads themselves).  Default is false.
        /// </summary>
        public bool DisableAutoAbort { get; set; } = false;

        /// <summary>
        /// Flag to indicate that MD5 should be set on every part of a multi-part upload.  The SDK will calculate the MD5 before uploading
        /// for each part it creates.  Default is false.
        /// </summary>
        public bool EnforceMd5MultipartUpload { get; set; } = false;

        /// <summary>
        /// Flag to indicate that MD5 should be set on every PutObject call.  If not provided, the SDK will calculate it before
        /// uploading the object. Default is false.
        /// </summary>
        public bool EnforceMd5Upload { get; set; } = false;

        private static readonly int DEFAULT_PARALLEL_THREADS = 3;
        private static readonly int DEFAULT_LENGTH_PER_UPLOAD_PART = 128;
        private static readonly long MINIMUM_ALLOWED_LENGTH_PER_PART_MB = 1L; // 1 MiB
        private static readonly long MAXIMUM_ALLOWED_LENGTH_PER_PART_MB = 50L * 1024L; // 50 GiB

        private long _length = DEFAULT_LENGTH_PER_UPLOAD_PART;

        private void ValidateLengthPerUploadPartInMiB(long value)
        {
            if (value < MINIMUM_ALLOWED_LENGTH_PER_PART_MB || value > MAXIMUM_ALLOWED_LENGTH_PER_PART_MB)
            {
                throw new ArgumentException($"Length must be in between {MINIMUM_ALLOWED_LENGTH_PER_PART_MB} - {MAXIMUM_ALLOWED_LENGTH_PER_PART_MB}. {TransferConstants.UPLOAD_MANAGER_DEBUG_INFORMATION_LOG}");
            }
        }
    }
}
