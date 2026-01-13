/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;

namespace Oci.Common.Utils
{
    /// <summary>Utility class for Retry configuration</summary>
    public class RetryUtils
    {
        private static readonly string OCI_SDK_DEFAULT_RETRY_ENABLED = "OCI_SDK_DEFAULT_RETRY_ENABLED";
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public static bool IsDefaultRetryConfigurationEnabled()
        {
            bool isGlobalRetryEnabled = false;
            try
            {
                isGlobalRetryEnabled = bool.Parse(Environment.GetEnvironmentVariable(OCI_SDK_DEFAULT_RETRY_ENABLED));
            }
            catch (Exception e) when (e is ArgumentNullException || e is FormatException)
            {
                logger.Info($"Environment Variable {OCI_SDK_DEFAULT_RETRY_ENABLED} not found or is not a bool, setting Global Default retry enabled as: {isGlobalRetryEnabled}");
            }
            return isGlobalRetryEnabled;
        }
    }
}
