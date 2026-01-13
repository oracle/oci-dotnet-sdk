/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Moq;
using Moq.Protected;
using Oci.Common.Model;
using Oci.Common.Utils;
using Oci.Common.Internal;
using Oci.Common.Http;

using Newtonsoft.Json;
using Xunit;

namespace Oci.Common
{
    [ExcludeFromCodeCoverage]
    public class RealmSpecificParameterizedClientTest : BaseTest
    {
        [Theory]
        [InlineData("https://{namespaceName+Dot}oracle.com", "https://foobar.oracle.com/")]
        [InlineData("https://{namespaceName+Dot}{bucketName}.oracle.com", "https://foobar.puppies.oracle.com/")]
        [InlineData("https://{randomName+Dot}oracle.com", "https://oracle.com/")]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void TestPopulateServiceParametersInEndpointTemplate(string parameterizedTemplate, string expectedEndpoint)
        {
            RestClient restclient = new RestClient { RealmSpecificEndpointTemplate = parameterizedTemplate };
            Dictionary<string, object> requiredParametersDictionary = new Dictionary<string, object> { { "namespaceName", "foobar" }, { "bucketName", "puppies" }, { "objectName", "kittens" } };
            Uri updatedEndpointTemplate = RegionalClientBase.PopulateServiceParametersInEndpointTemplate(restclient, requiredParametersDictionary);
            Assert.Equal(expectedEndpoint, updatedEndpointTemplate.ToString());
        }
    }
}