/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

namespace Oci.Common.Model
{
    /// <summary>Api Details Class used within the OCI Exception</summary>
    public class ApiDetails
    {
        public string ServiceName { get; set; }
        public string OperationName { get; set; }
        public string RequestEndpoint { get; set; }
        public string ApiReferenceLink { get; set; }
        public string UserAgent { get; set; }

        public override string ToString()
        {
            return $"ServiceName:{ServiceName}, OperationName:{OperationName}, RequestEndpoint:{RequestEndpoint}, ApiReferenceLink:{ApiReferenceLink}, UserAgent:{UserAgent}";
        }
    }
}