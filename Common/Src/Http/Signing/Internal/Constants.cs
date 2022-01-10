/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Oci.Common.Http.Signing.Internal
{
    public class Constants
    {

        // Headers
        public static readonly string AUTHORIZATION_HEADER = "authorization";

        // Signing
        public static readonly string REQUEST_TARGET = "(request-target)";
        public static readonly string DATE = "date";
        public static readonly string CONTENT_LENGTH = "content-length";
        public static readonly string CONTENT_TYPE = "content-type";
        public static readonly string CONTENT_DISPOSITION = "content-disposition";
        public static readonly string CONTENT_ENCODING = "content-encoding";
        public static readonly string CONTENT_LANGUAGE = "content-language";
        public static readonly string CONTENT_MD5 = "content-md5";
        public static readonly string X_CONTENT_SHA256 = "x-content-sha256";
        public static readonly string HOST = "host";

        // Optional
        public static readonly string CROSS_TENANCY_REQUEST_HEADER_NAME = "x-cross-tenancy-request";
        public static readonly string X_SUBSCRIPTION = "x-subscription";
        public static readonly string OPC_OBO_TOKEN = "opc-obo-token";

        public static readonly string JSON_CONTENT_TYPE = "application/json";

        public static readonly ReadOnlyCollection<string> GENERIC_HEADERS = new ReadOnlyCollection<string>(new string[] { DATE, REQUEST_TARGET, HOST });
        public static readonly ReadOnlyCollection<string> BODY_HEADERS = new ReadOnlyCollection<string>(new string[] { CONTENT_LENGTH, CONTENT_TYPE, X_CONTENT_SHA256 });
        public static readonly ReadOnlyCollection<string> ALL_HEADERS = new ReadOnlyCollection<string>(GENERIC_HEADERS.Concat(BODY_HEADERS).ToList());

        /// <summary>A Dictionary of headers that must be signed, for each HTTP method.</summary>
        public static readonly Dictionary<string, ReadOnlyCollection<string>> REQUIRED_SIGNING_HEADERS =
                CreateHeadersToSignDictionary(
                        GENERIC_HEADERS,
                        GENERIC_HEADERS,
                        GENERIC_HEADERS,
                        ALL_HEADERS,
                        ALL_HEADERS,
                        ALL_HEADERS);

        /// <summary>A Dictionary of headers that does not include body headers.</summary>
        public static readonly Dictionary<string, ReadOnlyCollection<string>> REQUIRED_EXCLUDE_BODY_SIGNING_HEADERS =
                CreateHeadersToSignDictionary(
                        GENERIC_HEADERS,
                        GENERIC_HEADERS,
                        GENERIC_HEADERS,
                        GENERIC_HEADERS,
                        GENERIC_HEADERS,
                        GENERIC_HEADERS);

        /// <summary>A Dictionary of headers to be included in the signature if they are set, for each HTTP method.</summary>
        public static readonly ReadOnlyCollection<string> OPTIONAL_HEADERS_NAMES = new ReadOnlyCollection<string>(new string[] { OPC_OBO_TOKEN, CROSS_TENANCY_REQUEST_HEADER_NAME, X_SUBSCRIPTION });

        public static readonly Dictionary<string, ReadOnlyCollection<string>> OPTIONAL_SIGNING_HEADERS =
                CreateHeadersToSignDictionary(
                        OPTIONAL_HEADERS_NAMES,
                        OPTIONAL_HEADERS_NAMES,
                        OPTIONAL_HEADERS_NAMES,
                        OPTIONAL_HEADERS_NAMES,
                        OPTIONAL_HEADERS_NAMES,
                        OPTIONAL_HEADERS_NAMES);

        /// <summary>Creates a map of headers to sign for each HTTP method.</summary>
        /// <param name="getHeaders">headers for GET requests</param>
        /// <param name="headHeaders">headers for HEAD requests</param>
        /// <param name="deleteHeaders">headers for DELETE requests</param>
        /// <param name="putHeaders">headers for PUT requests</param>
        /// <param name="postHeaders">headers for POST requests</param>
        /// <param name="patchHeaders">headers for PATCH requests</param>
        /// <returns>A new immutable dictionary of headers</returns>
        private static Dictionary<string, ReadOnlyCollection<string>> CreateHeadersToSignDictionary(
                ReadOnlyCollection<string> getHeaders,
                ReadOnlyCollection<string> headHeaders,
                ReadOnlyCollection<string> deleteHeaders,
                ReadOnlyCollection<string> putHeaders,
                ReadOnlyCollection<string> postHeaders,
                ReadOnlyCollection<string> patchHeaders)
        {
            return new Dictionary<string, ReadOnlyCollection<string>>
            {
                { "get", getHeaders },
                { "head", headHeaders },
                { "delete", deleteHeaders },
                { "put", putHeaders },
                { "post", postHeaders },
                { "patch", patchHeaders }
            };
        }
    }
}
