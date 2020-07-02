/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Oci.Common.Utils
{
    public class HttpUtils
    {
        public static string EncodeQueryParam(object queryParam)
        {
            // List will be converted to comma separated string
            if (queryParam is IList && queryParam.GetType().GetGenericTypeDefinition() == typeof(List<>))
            {
                List<string> retVal = new List<string>();
                foreach (object value in (IList)queryParam)
                {
                    retVal.Add(EncodeQueryParamSingleValue(value));
                }
                return string.Join(",", retVal);
            }
            else
            {
                return EncodeQueryParamSingleValue(queryParam);
            }
        }

        public static string EncodeQueryParamSingleValue(object queryParam)
        {
            if (queryParam is DateTime)
            {
                return HttpDateUtils.ToRfc3339Format((DateTime)queryParam);
            }
            if (queryParam is bool)
            {
                return queryParam.ToString().ToLower();
            }
            // Enum values cannot be directly casted to string because their values need to come from EnumMember attribute.
            if (queryParam.GetType().IsEnum)
            {
                return GetEnumString(queryParam);
            }
            return Uri.EscapeUriString(queryParam.ToString());
        }

        public static string GetEnumString(object enumObject)
        {
            var memInfo = enumObject.GetType().GetMember(enumObject.ToString());
            var attr = memInfo[0].GetCustomAttributes(false).OfType<EnumMemberAttribute>().FirstOrDefault();
            if (attr != null)
            {
                return Uri.EscapeUriString(attr.Value);
            }
            return Uri.EscapeUriString(enumObject.ToString());
        }

        public static string BuildQueryString(Dictionary<string, string> queries)
        {
            if (queries == null || queries.Count == 0)
            {
                return string.Empty;
            }
            var sb = new StringBuilder("?");
            foreach (KeyValuePair<string, string> keyValue in queries)
            {
                sb.AppendFormat("{0}{1}={2}", sb.Length > 1 ? "&" : "", keyValue.Key, keyValue.Value);
            }
            return sb.ToString();
        }
    }
}
