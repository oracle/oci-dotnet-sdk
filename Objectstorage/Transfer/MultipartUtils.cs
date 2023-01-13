/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.IO;
using System.Security.Cryptography;

namespace Oci.ObjectstorageService.Transfer
{
    public class MultipartUtils
    {
        public static readonly long MiB = 1024 * 1024;

        /// <summary>
        /// Max length supported in Object Storage's object.
        /// https://docs.cloud.oracle.com/iaas/Content/Object/Tasks/usingmultipartuploads.htm
        /// </summary>
        public static readonly long MAX_SUPPORTED_CONTENT_LENGTH = 10 * MiB * MiB; // 10 TiB

        /// <summary>
        /// Method to determine if an upload meets multipart upload requirement based on uploadconfiguration and content length.
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="contentLength"></param>
        /// <returns>True if an upload configuration satifies the requirements otherwise false.</returns>
        public static bool ShouldUseMultipart(UploadConfiguration configuration, long contentLength)
        {
            return configuration.AllowMultipartUploads && MeetsMinimumSize(configuration, contentLength);
        }

        /// <summary>
        /// Calculates md5 hash for the given input stream.
        /// </summary>
        /// <param name="inputStream">Stream</param>
        /// <returns>Md5 Hash string</returns>
        public static string CalculateMd5(Stream inputStream)
        {
            using var md5 = MD5.Create();
            var hash = md5.ComputeHash(inputStream);
            return Convert.ToBase64String(hash);
        }

        /// <summary>
        /// Validates the current PartNumber based on the conditions mentioned here:
        /// https://docs.cloud.oracle.com/en-us/iaas/Content/Object/Tasks/usingmultipartuploads.htm
        /// </summary>
        /// <param name="partNum"></param>
        public static void ValidatePartNumber(int partNum)
        {
            if (partNum < 1 || partNum > MAX_PARTS_COUNT)
            {
                throw new ArgumentException("Part number should be in between 1 and 10000");
            }
        }

        private static bool MeetsMinimumSize(UploadConfiguration configuration, long contentLength)
        {
            if (contentLength > MAX_SUPPORTED_CONTENT_LENGTH)
            {
                throw new ArgumentException("Object Size greater than 10TiB is not supported.");
            }
            long min = configuration.LengthPerUploadPartInMiB * MiB;
            return contentLength >= min;
        }

        private static readonly int MAX_PARTS_COUNT = 10000;
    }
}
