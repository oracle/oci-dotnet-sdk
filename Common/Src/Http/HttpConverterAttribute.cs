/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;

namespace Oci.Common.Http
{
    [AttributeUsage(AttributeTargets.Property)]
    public class HttpConverterAttribute : Attribute
    {

        // The target to add this value in HttpRequestMesasage.
        public TargetEnum Target { get; set; }
        // The name of the target.
        public string Name { get; set; }

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
