/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Oci.Common.Utils
{
    public class ResponseRecordEnumerable<Request, Response, ItemType> : IEnumerable<ItemType>
    {
        // Function which returns nextpage from the response object.
        private readonly Func<Response, string> getNextPageTokenFunction;
        // Function which takes opcNextPageId as input and returns list request. 
        private readonly Func<string, Request> getListRequestFunction;
        // Function which invokes list request and returns response.
        private readonly Func<Request, Response> listRequestFunction;
        // Function which returns items from response object.
        private readonly Func<Response, List<ItemType>> retrieveItemsFromResponseFunc;

        public ResponseRecordEnumerable(Func<Response, string> getNextPageTokenFunction,
            Func<string, Request> getListRequestFunction, Func<Request, Response> listRequestFunction,
            Func<Response, List<ItemType>> retrieveItemsFromResponseFunc)
        {
            this.getNextPageTokenFunction = getNextPageTokenFunction;
            this.getListRequestFunction = getListRequestFunction;
            this.listRequestFunction = listRequestFunction;
            this.retrieveItemsFromResponseFunc = retrieveItemsFromResponseFunc;
        }

        public IEnumerator<ItemType> GetEnumerator()
        {
            var nextPageToken = "";
            Response response;

            do
            {
                response = listRequestFunction.Invoke(getListRequestFunction.Invoke(nextPageToken));
                foreach (var item in retrieveItemsFromResponseFunc(response))
                {
                    yield return item;
                }
            } while (!string.IsNullOrEmpty(nextPageToken = getNextPageTokenFunction(response)));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
