/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;

using Oci.Common.Utils;

namespace Oci.Common.Http.Internal
{
    public class HeaderUtils
    {
        public static string GetFirstorDefaultHeaderValue(HttpResponseHeaders headers, string headerName)
        {
            if (headers == null || string.IsNullOrEmpty(headerName))
            {
                return string.Empty;
            }

            foreach (var header in headers)
            {
                if (header.Key.ToLower().Equals(headerName.ToLower()))
                {
                    return header.Value.FirstOrDefault();
                }
            }
            return string.Empty;
        }

        public static string FromValue(dynamic value)
        {
            if (value.GetType().Equals(typeof(Oci.Common.Model.Range)))
            {
                return value.ToString();
            }
            if (value.GetType().Equals(typeof(DateTime)))
            {
                return HttpDateUtils.ToRfc3339Format(value);
            }
            if (value.GetType().Equals(typeof(BigInteger)))
            {
                return value.ToString();
            }
            // Enum values cannot be directly casted to string because their values need to come from EnumMember attribute.
            if (value.GetType().IsEnum)
            {
                return HttpUtils.GetEnumString(value);
            }
            return Convert.ToString(value);
        }

        public static dynamic ToValue(string strValue, Type type)
        {
            if (type.Equals(typeof(Oci.Common.Model.Range)))
            {
                return Oci.Common.Model.Range.ParseRange(strValue);
            }
            if (type.Equals(typeof(DateTime)))
            {
                return HttpDateUtils.ToDateTime(strValue);
            }
            if (type.Equals(typeof(BigInteger)))
            {
                return BigInteger.Parse(strValue);
            }
            var converter = TypeDescriptor.GetConverter(type);
            if (converter == null)
            {
                throw new ArgumentException($"Unable to get converter for type {type}");
            }
            var retVal = converter.ConvertFrom(strValue);
            return retVal;
        }
    }
}
