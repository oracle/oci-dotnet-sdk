/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using Oci.Common.Http.Signing.Internal;
using Oci.Common.Utils;

namespace Oci.Common.Http.Internal
{
    /// <summary>A utility class to handle HTTP request content creation.</summary>
    public class ContentHelper
    {
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>Creates HttpContent.</summary>
        /// <param name="content">The content to create HttpContent from.</param>
        /// <returns>The HttpContent created.</returns>
        public static HttpContent CreateHttpContent(object content)
        {
            HttpContent httpContent = null;

            if (content != null)
            {
                if (content is Stream)
                {
                    httpContent = new StreamContent((Stream)content);
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                }
                else
                {
                    var ms = new MemoryStream();
                    SerializeJsonIntoStream(content, ms);
                    ms.Seek(0, SeekOrigin.Begin);
                    httpContent = new StreamContent(ms);
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                }
            }

            return httpContent;
        }

        /// <summary>Converts a json string to stream.</summary>
        /// <param name="value">The json string value.</param>
        /// <param name="stream">The stream that will contain the converted value.</param>
        public static void SerializeJsonIntoStream(object value, Stream stream)
        {
            using var sw = new StreamWriter(stream, new UTF8Encoding(false), 1024, true);
            using var jtw = new JsonTextWriter(sw) { Formatting = Formatting.None };
            var js = JsonSerializer.Create(new JsonSerializerSettings { ContractResolver = new CustomResolver(), NullValueHandling = NullValueHandling.Ignore });
            js.Serialize(jtw, value);
            jtw.Flush();
            stream.Seek(0, SeekOrigin.Begin);
            logger.Trace($"request content: {new StreamReader(stream, Encoding.UTF8).ReadToEnd()}");
        }

        /// <summary>Updates the Settable HttpContent Header with values provided in Request.</summary>
        /// <param name="httpContent">The httpContent to be updated.</param>
        public static void UpdateSettableHttpContentHeaders(HttpContent httpContent, Dictionary<string, string> contentHeaders)
        {
            foreach (var contentHeader in contentHeaders)
            {
                // The ContentType is already set in CreateHttpContent method, adding it via TryAddWithoutValidation
                // will send two ContentType headers so we override ContentType value instead if provided.
                if (contentHeader.Key.Equals(Constants.CONTENT_TYPE))
                {
                    var unescapedHeaderValue = Uri.UnescapeDataString(contentHeader.Value);
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue(unescapedHeaderValue);
                }
                else
                {
                    httpContent.Headers.TryAddWithoutValidation(contentHeader.Key.ToUpper(), contentHeader.Value);
                }
            }
        }
    }
}
