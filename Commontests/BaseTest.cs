/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Xunit.Sdk;

namespace Oci.Common
{
    [ExcludeFromCodeCoverage]
    public class BaseTest
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        protected class DisplayTestMethodNameAttribute : BeforeAfterTestAttribute
        {
            public override void Before(MethodInfo methodUnderTest)
            {
                logger.Info($"++++Starting test '{methodUnderTest.DeclaringType.Name}.{methodUnderTest.Name}.'");
            }

            public override void After(MethodInfo methodUnderTest)
            {
                logger.Info($"----Finished test '{methodUnderTest.DeclaringType.Name}.{methodUnderTest.Name}.'");
            }
        }
    }
}
