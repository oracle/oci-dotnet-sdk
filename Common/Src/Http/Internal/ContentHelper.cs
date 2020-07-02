/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace Oci.Common.Http.Internal
{
    public class ContentHelper
    {
        protected static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

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

        public static void SerializeJsonIntoStream(object value, Stream stream)
        {
            using var sw = new StreamWriter(stream, new UTF8Encoding(false), 1024, true);
            using var jtw = new JsonTextWriter(sw) { Formatting = Formatting.None };
            var js = JsonSerializer.Create(new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            js.Serialize(jtw, value);
            jtw.Flush();
            stream.Seek(0, SeekOrigin.Begin);
            logger.Trace($"request content: {new StreamReader(stream, Encoding.UTF8).ReadToEnd()}");
        }
    }
}
