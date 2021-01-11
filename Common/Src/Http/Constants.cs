/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

namespace Oci.Common.Http
{
    /// <summary>Defines where a property in Request class should be place in HttpRequestMessage.</summary>
    public enum TargetEnum
    {
        /// <summary>A path parameter.</summary>
        Path,
        /// <summary>A header parameter.</summary>
        Header,
        /// <summary>A query parameter.</summary>
        Query,
        /// <summary>Body of a request.</summary>
        Body
    }
}
