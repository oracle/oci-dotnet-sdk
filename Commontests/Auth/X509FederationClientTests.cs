/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Http;
using Moq;
using Moq.Protected;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using System.Security.Cryptography.X509Certificates;
using Oci.Common.Auth.Internal;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Oci.Common.Http.Signing;

namespace Oci.Common.Auth
{
    [ExcludeFromCodeCoverage]
    public class X509FederationClientTests : BaseTest
    {

        private X509FederationClient x509FederationClient;
        private readonly Mock<RsaKeyParameters> rsaKeyParamMock;
        private readonly Mock<ISigner> signerMock;

        public X509FederationClientTests()
        {
            var leafCertificateSupplier = new Mock<IX509CertificateSupplier>();
            var certificateKeyPair = new CertificateAndPrivateKeyPair();
            certificateKeyPair.Certificate = new X509Certificate2("cacert.pem");
            rsaKeyParamMock = new Mock<RsaKeyParameters>(true, new BigInteger("1"), new BigInteger("2"));
            certificateKeyPair.PrivateKey = rsaKeyParamMock.Object;

            leafCertificateSupplier.Setup(p => p.Refresh());
            leafCertificateSupplier.Setup(p => p.GetCertificateAndKeyPair()).Returns(certificateKeyPair);

            var intermediateCertificateSuppliers = new Mock<HashSet<IX509CertificateSupplier>>();
            var certificate = new Mock<IX509CertificateSupplier>();
            certificate.Setup(p => p.Refresh());
            intermediateCertificateSuppliers.Object.Add(certificate.Object);

            x509FederationClient = new X509FederationClient("https://auth.us-phoenix-1.oraclecloud.com", "",
                    leafCertificateSupplier.Object,
                    new SessionKey(),
                    intermediateCertificateSuppliers.Object,
                    "test");

            signerMock = new Mock<ISigner>();
            signerMock.Setup(s => s.GenerateSignature()).Returns(new byte[] { 1, 2, 3, 4, 5 });
        }

        [Fact]
        [Trait("Category", "Unit")]
        [DisplayTestMethodNameAttribute]
        public void GetSecurityToken()
        {
            var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";
            var actualJwtToken = $"{{'token': '{token}'}}";
            var expectedJwtToken = token;

            var handlerMock = new Mock<HttpMessageHandler>();
            var response = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(actualJwtToken),
            };

            handlerMock
               .Protected()
               .Setup<Task<HttpResponseMessage>>(
                  "SendAsync",
                  ItExpr.IsAny<HttpRequestMessage>(),
                  ItExpr.IsAny<CancellationToken>())
               .ReturnsAsync(response);

            x509FederationClient.Client = new HttpClient(handlerMock.Object);
            x509FederationClient.FederationSigner = new FederationRequestSigner(rsaKeyParamMock.Object, "", signerMock.Object);

            Assert.Equal(expectedJwtToken, x509FederationClient.GetSecurityToken());
        }
    }
}
