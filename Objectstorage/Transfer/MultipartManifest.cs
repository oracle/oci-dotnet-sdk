/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Oci.ObjectstorageService.Models;
using Oci.ObjectstorageService.Responses;

namespace Oci.ObjectstorageService.Transfer
{
    public class MultipartManifest
    {
        /// <summary>
        /// UploadId associated with the Multipart Upload
        /// </summary>
        public string UploadId { get; }

        public MultipartManifest(string UploadId)
        {
            this.UploadId = UploadId;
        }

        /// <summary>
        /// Registers partNumber to the manifest.
        /// </summary>
        /// <param name="partNumber"></param>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void RegisterTransfer(int partNumber)
        {
            if (!_parts.TryGetValue(partNumber, out PartAndStatus _))
            {
                _parts.Add(partNumber, new PartAndStatus());
            }
        }

        /// <summary>
        /// Registers the provided partnumber as successfully uploaded part.
        /// </summary>
        /// <param name="partNumber"></param>
        /// <param name="response"></param>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void RegisterSuccess(int partNumber, UploadPartResponse response)
        {
            var part = _parts[partNumber];
            part.Details = new CommitMultipartUploadPartDetails()
            {
                Etag = response.ETag,
                PartNum = partNumber
            };
            part.Complete = true;
        }

        /// <summary>
        /// Registers the provided partNumber as a failed part.
        /// </summary>
        /// <param name="partNumber"></param>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void RegisterFailure(int partNumber)
        {
            PartAndStatus partAndStatus = _parts[partNumber];
            partAndStatus.Complete = true;
        }

        /// <summary>
        /// Registers the existing part to the manifest.
        /// </summary>
        /// <param name="part"></param>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void RegisterExisting(MultipartUploadPartSummary part)
        {
            var partAndStatus = new PartAndStatus()
            {
                Complete = true,
                Details = new CommitMultipartUploadPartDetails()
                {
                    Etag = part.Etag,
                    PartNum = part.PartNumber
                }
            };

            _parts.Add(part.PartNumber.Value, partAndStatus);
        }

        /// <summary>
        /// Returns the list of completed parts in a multipart upload.
        /// </summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public List<CommitMultipartUploadPartDetails> ListCompletedParts()
        {
            return _parts.Values
                .Where(part => part.Details != null)
                .Select(part => part.Details).ToList();
        }

        /// <summary>
        /// Returns the list of failed parts
        /// </summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public List<int> ListFailedParts()
        {
            return _parts.Where(kvp => kvp.Value.Complete && kvp.Value.Details == null)
                .Select(kvp => kvp.Key).ToList();
        }

        /// <summary>
        /// Returns true if all the parts in a multipart upload are successfully uploaded.
        /// </summary>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public bool IsUploadSuccessful()
        {
            foreach (var part in _parts.Values)
            {
                if (!part.Complete || part.Details == null)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Verifies if a part already exists in the manifest
        /// </summary>
        /// <param name="partNum"></param>
        /// <returns></returns>
        public bool IsPartExists(int partNum)
        {
            return _parts.ContainsKey(partNum);
        }

        /// <summary>
        /// Marks the in-progress upload as aborted/cancelled.
        /// </summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void MarkAborted()
        {
            _isAborted = true;
        }

        /// <summary>
        /// Returns if the in-progress upload is aborted/cancelled.
        /// </summary>
        /// <returns></returns>
        public bool IsAborted()
        {
            return _isAborted;
        }

        private class PartAndStatus
        {
            public CommitMultipartUploadPartDetails Details { get; set; }
            public bool Complete { get; set; }
        }

        private readonly Dictionary<int, PartAndStatus> _parts = new Dictionary<int, PartAndStatus>();
        private bool _isAborted = false;
    }
}
