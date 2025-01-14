/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using Oci.Common.Utils;

namespace Oci.ObjectstorageService.Transfer
{
    public class TransferConstants
    {
        private readonly static string clientVersion = HttpUtils.BuildUserAgent("");
        public readonly static string UPLOAD_MANAGER_DEBUG_INFORMATION_LOG = clientVersion + " See https://docs.oracle.com/iaas/Content/API/Concepts/sdk_troubleshooting.htm for common issues and steps to resolve them. If you need to contact support, or file a GitHub issue, please include this full error message.";
    }
}