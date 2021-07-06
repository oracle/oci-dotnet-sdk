/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using Oci.Common.Http;
using Oci.Common.Http.Internal;
using Oci.Common.Utils;

namespace Oci.Common
{
    /// <summary>
    /// The class that converts SDK request object into HttpRequestMessage, and converts HttpResponseMessage
    /// into SDK response object.
    /// </summary>
    public class Converter
    {
        protected static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary> Converts SDK request object into HttpRequestMessage.</summary>
        /// <param name="uri">The uri of this http request.</param>
        /// <param name="method">The method of this http request.</param>
        /// <param name="request">The SDK object for this request.</param>
        /// <returns>An HttpRequestMessage that can be sent by HttpClient.</returns>
        public static HttpRequestMessage ToHttpRequestMessage<T>(Uri uri, HttpMethod method, T request) where T : IOciRequest
        {
            // Update properties of requests if needed

            var requestMessage = new HttpRequestMessage();
            requestMessage.Method = method;
            var updatedUri = uri.AbsoluteUri;
            // A list containing all query string.
            var queriesList = new List<string>();
            PropertyInfo[] props = typeof(T).GetProperties();
            foreach (var prop in props)
            {
                if (prop.GetValue(request) == null)
                {
                    continue;
                }
                object[] attrs = prop.GetCustomAttributes(false);
                foreach (var attr in attrs)
                {
                    HttpConverterAttribute httpRequestAttr = attr as HttpConverterAttribute;
                    if (httpRequestAttr != null)
                    {
                        if (httpRequestAttr.Target == TargetEnum.Query)
                        {
                            var query = HttpUtils.EncodeQueryParam(httpRequestAttr.Name, prop.GetValue(request), httpRequestAttr.CollectionFormat);
                            logger.Debug($"Adding query {query}");
                            queriesList.Add(query);
                        }
                        else if (httpRequestAttr.Target == TargetEnum.Header)
                        {
                            var propertyType = prop.PropertyType;
                            // Special handling of Dictionary type in header since the Dictionary contents are returned as individual header entries.
                            if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(Dictionary<,>))
                            {

                                foreach (KeyValuePair<string, string> pair in prop.GetValue(request) as IDictionary<string, string>)
                                {
                                    requestMessage.Headers.TryAddWithoutValidation(pair.Key, pair.Value);
                                }
                            }
                            else
                            {
                                logger.Debug($"Adding header {httpRequestAttr.Name}: {prop.GetValue(request)}");
                                // To avoid validating header name formatting (.Net HttpClient has some strict validation rules and not all OCI service headers satisfy them.),
                                // call TryAddWithoutValidation instead of Add.
                                requestMessage.Headers.TryAddWithoutValidation(httpRequestAttr.Name, HeaderUtils.FromValue(prop.GetValue(request)));
                            }
                        }
                        else if (httpRequestAttr.Target == TargetEnum.Body)
                        {
                            logger.Debug($"Adding content from property {prop.Name}");
                            requestMessage.Content = ContentHelper.CreateHttpContent(prop.GetValue(request));
                        }
                        else if (httpRequestAttr.Target == TargetEnum.Path)
                        {
                            logger.Debug($"Adding path parameter {httpRequestAttr.Name}: {prop.GetValue(request)}");
                            updatedUri = updatedUri.Replace(Uri.EscapeUriString($"{{{httpRequestAttr.Name}}}"), HeaderUtils.FromValue(prop.GetValue(request)));
                        }
                    }
                }
            }
            var uriBuilder = new UriBuilder(updatedUri);
            uriBuilder.Query = HttpUtils.BuildQueryString(queriesList);
            requestMessage.RequestUri = uriBuilder.Uri;
            return requestMessage;
        }

        /// <summary>Converts HttpResponseMessage into SDK response object.</summary>
        /// <param name="responseMessage">An HttpResponseMessage object</param>
        /// <returns>A SDK response object.</returns>
        public static T FromHttpResponseMessage<T>(HttpResponseMessage responseMessage) where T : IOciResponse, new()
        {
            var response = new T();
            PropertyInfo[] props = typeof(T).GetProperties();
            foreach (var prop in props)
            {
                object[] attrs = prop.GetCustomAttributes(false);
                foreach (var attr in attrs)
                {
                    HttpConverterAttribute httpResponseAttr = attr as HttpConverterAttribute;
                    if (httpResponseAttr == null)
                    {
                        continue;
                    }
                    if (httpResponseAttr.Target == TargetEnum.Header)
                    {
                        var propertyType = prop.PropertyType;
                        // Special handling of Dictionary type in header since the Dictionary contents are returned as individual header entries.
                        if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(Dictionary<,>))
                        {
                            var value = new Dictionary<string, string>();
                            var prefix = httpResponseAttr.Name;
                            foreach (var header in responseMessage.Headers)
                            {
                                if (header.Key.StartsWith(prefix))
                                {
                                    // Remove the prefix and add header to dictionary.
                                    value.Add(header.Key.Substring(prefix.Length), header.Value.FirstOrDefault());
                                }
                            }
                            foreach (var header in responseMessage.Content.Headers)
                            {
                                if (header.Key.StartsWith(prefix))
                                {
                                    // Remove the prefix and add header to dictionary.
                                    value.Add(header.Key.Substring(prefix.Length), header.Value.FirstOrDefault());
                                }
                            }
                            if (value.Count > 0)
                            {
                                prop.SetValue(response, value);
                            }
                        }
                        else
                        {
                            if (responseMessage.Headers.TryGetValues(httpResponseAttr.Name, out var headerValues))
                            {
                                logger.Debug($"Setting property value from header {httpResponseAttr.Name}");
                                prop.SetValue(response, HeaderUtils.ToValue(headerValues.FirstOrDefault(), prop.PropertyType));
                            }
                            if (responseMessage.Content.Headers.TryGetValues(httpResponseAttr.Name, out var contentHeaderValues))
                            {
                                logger.Debug($"Setting property value from content header {httpResponseAttr.Name}");
                                prop.SetValue(response, HeaderUtils.ToValue(contentHeaderValues.FirstOrDefault(), prop.PropertyType));
                            }
                        }
                    }
                    else if (httpResponseAttr.Target == TargetEnum.Body)
                    {
                        GenericInvokerParameters genericInvokerParameters = new GenericInvokerParameters
                        {
                            InvokeType = prop.PropertyType,
                            ResponseMessage = responseMessage
                        };
                        var responseEntity = GenericHelper.InvokeGenericMethod(genericInvokerParameters);
                        prop.SetValue(response, responseEntity);
                    }
                }
            }
            return response;
        }
    }

    /// These classes are internal because they are not used anywhere else.
    /// If they are needed in other places, move them to an appropriate location.
    internal class GenericHelper
    {
        public static dynamic InvokeGenericMethod(GenericInvokerParameters parameters)
        {
            var genericMethodInfo = typeof(GenericInvoker).GetMethod("ReadEntity");
            genericMethodInfo = genericMethodInfo.MakeGenericMethod(parameters.InvokeType);
            return genericMethodInfo.Invoke(new GenericInvoker(), new[] { parameters });
        }
    }

    internal class GenericInvoker
    {
        public T ReadEntity<T>(GenericInvokerParameters parameters)
        {
            return ResponseHelper.ReadEntity<T>(parameters.ResponseMessage);
        }
    }

    internal class GenericInvokerParameters
    {
        public HttpResponseMessage ResponseMessage { get; set; }
        public Type InvokeType { get; set; }
    }
}
