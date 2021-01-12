/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.Collections.Generic;
using Oci.ObjectstorageService.Requests;

namespace Oci.ObjectstorageService
{
    public class ObjectMetadataInterceptor
    {
        private static readonly string OPC_META_PREFIX = "opc-meta-";

        public static void intercept(CopyObjectRequest request)
        {
            Dictionary<string, string> updatedMetadata = AddOpcMetaPrefix(request.CopyObjectDetails.DestinationObjectMetadata);
            request.CopyObjectDetails.DestinationObjectMetadata = updatedMetadata;
        }

        public static void intercept(CreateMultipartUploadRequest request)
        {
            Dictionary<string, string> updatedMetadata = AddOpcMetaPrefix(request.CreateMultipartUploadDetails.Metadata);
            request.CreateMultipartUploadDetails.Metadata = updatedMetadata;
        }

        public static void intercept(PutObjectRequest request)
        {
            Dictionary<string, string> updatedMetadata = AddOpcMetaPrefix(request.OpcMeta);
            request.OpcMeta = updatedMetadata;
        }

        // Update request by modifying dictionary key names.
        // For example, in some requests in objectstorage, the key of metadata must start with opc-meta-.
        private static Dictionary<string, string> AddOpcMetaPrefix(Dictionary<string, string> metadata)
        {
            Dictionary<string, string> updatedMetadata = null;
            if (metadata != null)
            {
                updatedMetadata = new Dictionary<string, string>();
                foreach (KeyValuePair<string, string> pair in metadata)
                {
                    if (pair.Key.StartsWith(OPC_META_PREFIX))
                    {
                        updatedMetadata.Add(pair.Key, pair.Value);
                    }
                    else
                    {
                        updatedMetadata.Add($"{OPC_META_PREFIX}{pair.Key}", pair.Value);
                    }
                }
            }
            return updatedMetadata;
        }
    }
}
