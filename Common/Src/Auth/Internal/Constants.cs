/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

namespace Oci.Common.Auth.Internal
{
    public class Constants
    {
        public static readonly int RETRIES = 5;
        public static readonly string AUTH_SERVICE_PATH = "/v1/x509";
        public static readonly string FED_KEY_PATH = "/fed-x509/";
        public static readonly string OPC_TENANT = "opc-tenant";
        public static readonly string OPC_IDENTITY = "opc-identity";
        public static readonly int RETRY_MILLIS = 250;
        public static readonly string AUTHORIZATION_HEADER = "authorization";
        public static readonly string INSTANCE_CERT = "identity/cert.pem";
        public static readonly string PRIVATE_KEY_CERT = "identity/key.pem";
        public static readonly string INTERMEDIATE_KEY_CERT = "identity/intermediate.pem";
        public static readonly string INSTANCE_REGION = "instance/region";
        public static readonly string ACCEPT_HEADER = "accept";
        public static readonly string ACCEPT_TYPE = "text/plain";
    }
}
