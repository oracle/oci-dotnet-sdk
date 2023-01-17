/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Oci.Common.Http;

namespace Oci.Common.Utils
{
    /// <summary>A utility class that contains functions related to HTTP calls.</summary>
    public class HttpUtils
    {
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Attempts to encode a query param. If it is a list of values, each item in teh list will be
        /// encoded and then added to a single string, separated by commas.
        /// </summary>
        /// <param name="queryKey">The key for the query</param>
        /// <param name="queryParam">The query parameter value to encode.</param>
        /// <param name="collectionFormat">The colleciton format to be used to build the query if queryParam contains a list of values.</param>
        /// <returns>The encoded query parameter in string.</returns>
        public static string EncodeQueryParam(string queryKey, object queryParam, CollectionFormatType collectionFormat)
        {
            // List will be converted to comma separated string
            if (queryParam is IList && queryParam.GetType().GetGenericTypeDefinition() == typeof(List<>))
            {
                logger.Info($"collection format is {collectionFormat}");

                List<string> queryValues = new List<string>();
                foreach (object value in (IList)queryParam)
                {
                    queryValues.Add(EncodeQueryParamSingleValue(value));
                }
                if (collectionFormat == CollectionFormatType.Csv)
                {
                    return $"{queryKey}={string.Join(",", queryValues)}";
                }
                else if (collectionFormat == CollectionFormatType.Pipes)
                {
                    return $"{queryKey}={string.Join(Uri.EscapeUriString("|"), queryValues)}";
                }
                else if (collectionFormat == CollectionFormatType.Ssv)
                {
                    return $"{queryKey}={string.Join(Uri.EscapeUriString(" "), queryValues)}";
                }
                else if (collectionFormat == CollectionFormatType.Tsv)
                {
                    return $"{queryKey}={string.Join(Uri.EscapeUriString("\t"), queryValues)}";
                }
                else if (collectionFormat == CollectionFormatType.Multi)
                {
                    List<string> queryStrings = new List<string>();
                    foreach (string queryValue in queryValues)
                    {
                        queryStrings.Add($"{queryKey}={queryValue}");
                    }
                    return BuildQueryString(queryStrings);
                }
                else
                {
                    throw new ArgumentException($"Unknown collection format type {collectionFormat} for query parameter {queryKey}");
                }
            }
            else
            {
                return $"{queryKey}={EncodeQueryParamSingleValue(queryParam)}";
            }
        }

        /// <summary>
        /// Attempts to encode a query param.
        /// <param name="queryParam">The query parameter to encode.</param>
        /// <returns>The encoded query parameter in string.</returns>
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

        /// <summary>Gets the actual Enum string representation that will be passed in HTTP request and recognized by service backend.</summary>
        /// <param name="enumObject">A query parameter that is an Enum value.</param>
        /// <returns>The matching string representation that can be accepted by service endpoint.</returns>
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

        /// <summary>Builds the string containing the query in request URL.</summary>
        /// <param name="queries">A Dictionary containing all queries to be send.</param>
        /// <returns>The string representation of the queries in the request URL.</returns>
        public static string BuildQueryString(List<string> queries)
        {
            if (queries == null || queries.Count == 0)
            {
                return string.Empty;
            }
            var sb = new StringBuilder("");
            foreach (string query in queries)
            {
                sb.AppendFormat("{0}{1}", sb.Length > 1 ? "&" : "", query);
            }
            return sb.ToString();
        }

        /// <summary> Builds the useragent</summary>
        public static string BuildUserAgent(string clientUserAgent)
        {
            var additionalUserAgent = String.IsNullOrEmpty(clientUserAgent) ? "" : $" {clientUserAgent}";
            OperatingSystem os = Environment.OSVersion;
            String ociSdkAppendUserAgent = Environment.GetEnvironmentVariable("OCI_SDK_APPEND_USER_AGENT");
            ociSdkAppendUserAgent = String.IsNullOrEmpty(ociSdkAppendUserAgent) ? "" : $" {ociSdkAppendUserAgent}";
            return $"Oracle-DotNetSDK/{Version.GetVersion()} ({os.Platform}/{os.Version}; {RuntimeInformation.FrameworkDescription}) {additionalUserAgent} {ociSdkAppendUserAgent}";
        }

        /// <summary>Make a copy of HttpRequestMessage.</summary>
        /// <param name="request">The source HttpRequestMessage</param>
        /// <returns>A cloned copy of HttpRequestMessage with exactly the same headers and content.</returns>
        public static async Task<HttpRequestMessage> CloneHttpRequestMessage(HttpRequestMessage request)
        {
            var clone = new HttpRequestMessage(request.Method, request.RequestUri);

            if (request.Content != null)
            {
                // Copy the request's content (via a MemoryStream) into the cloned object
                var ms = new MemoryStream();
                await request.Content.CopyToAsync(ms).ConfigureAwait(false);
                ms.Position = 0;
                clone.Content = new StreamContent(ms);

                // Copy the content headers
                if (request.Content.Headers != null)
                {
                    foreach (var header in request.Content.Headers)
                    {
                        clone.Content.Headers.Add(header.Key, header.Value);
                    }
                }
            }

            foreach (var header in request.Headers)
            {
                clone.Headers.TryAddWithoutValidation(header.Key, header.Value);
            }

            if (request.Properties != null)
            {
                foreach (var kvp in request.Properties)
                {
                    clone.Properties.Add(kvp.Key, kvp.Value);
                }
            }

            return clone;
        }
    }
}
