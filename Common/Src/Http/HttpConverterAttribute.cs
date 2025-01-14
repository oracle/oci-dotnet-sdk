/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;

namespace Oci.Common.Http
{
    /// <summary>A custom Attribute implementation for properties in Request classes.</summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class HttpConverterAttribute : Attribute
    {

        /// <summary>The target to add this value in HttpRequestMesasage.</summary>
        public TargetEnum Target { get; set; }
        /// <summary>The name of the target.</summary>
        public string Name { get; set; }
        /// <summary>The collection format type. Only applicable when Target is Query.</summary>
        public CollectionFormatType CollectionFormat { get; set; } = CollectionFormatType.Csv;

        public HttpConverterAttribute(TargetEnum target, string name, CollectionFormatType collectionFormat)
        {
            Target = target;
            Name = name;
            CollectionFormat = collectionFormat;
        }
        public HttpConverterAttribute(TargetEnum target, string name)
        {
            Target = target;
            Name = name;
        }

        public HttpConverterAttribute(TargetEnum target)
        {
            Target = target;
        }
    }
}
