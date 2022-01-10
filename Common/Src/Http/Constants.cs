/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
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

    public enum CollectionFormatType
    {
        /// <summary>Comma separated values, e.g. queryparam=val1, val2, val3.</summary>
        Csv,
        /// <summary>Assign each value to the query param separately, e.g. queryparam=val1&amp;queryparm=val2.</summary>
        Multi,
        /// <summary>pipe separated values, e.g. queryparam=val1|val2|val3.</summary>
        Pipes,
        /// <summary>Space separated values, e.g. queryparam=val1 val2 val3.</summary>
        Ssv,
        /// <summary>Tab separated values, e.g. queryparam=val1\tval2\tval3.</summary>
        Tsv
    }
}
