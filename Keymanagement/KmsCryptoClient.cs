/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.DeveloperToolConfigurations;
using Oci.Common.Model;
using Oci.Common.Auth;
using Oci.Common.Retry;
using Oci.KeymanagementService.Requests;
using Oci.KeymanagementService.Responses;

namespace Oci.KeymanagementService
{
    /// <summary>Service client instance for KmsCrypto.</summary>
    public class KmsCryptoClient : ClientBase
    {
        private readonly RetryConfiguration retryConfiguration;
        private const string basePathWithoutHost = "/";

        /// <summary>
        /// Creates a new service instance using the given authentication provider and/or client configuration and/or endpoint.
        /// A client configuration can also be provided optionally to adjust REST client behaviors.
        /// </summary>
        /// <param name="authenticationDetailsProvider">The authentication details provider. Required.</param>
        /// <param name="clientConfiguration">The client configuration that contains settings to adjust REST client behaviors. Optional.</param>
        /// <param name="endpoint">The endpoint of the service. If not provided and the client is a regional client, the endpoint will be constructed based on region information. Optional.</param>
        public KmsCryptoClient(IBasicAuthenticationDetailsProvider authenticationDetailsProvider, ClientConfiguration clientConfiguration = null, string endpoint = null)
            : base(authenticationDetailsProvider, clientConfiguration)
        {
            if (!DeveloperToolConfiguration.IsServiceEnabled("keymanagement"))
            {
                throw new ArgumentException("The DeveloperToolConfiguration disabled this service, this behavior is controlled by DeveloperToolConfiguration.OciEnabledServiceSet variable. Please check if your local DeveloperToolConfiguration file has configured the service you're targeting or contact the cloud provider on the availability of this service");
            }
            service = new Service
            {
                ServiceName = "KMSCRYPTO",
                ServiceEndpointPrefix = "kms",
                ServiceEndpointTemplate = "https://kms.{region}.{secondLevelDomain}"
            };

            ClientConfiguration clientConfigurationToUse = clientConfiguration ?? new ClientConfiguration();

            if (endpoint != null)
            {
                logger.Info($"Using endpoint specified \"{endpoint}\".");
                SetEndpoint(endpoint);
            }

            this.retryConfiguration = clientConfigurationToUse.RetryConfiguration;
        }

        /// <summary>
        /// Decrypts data using the given [DecryptDataDetails](https://docs.cloud.oracle.com/api/#/en/key/latest/datatypes/DecryptDataDetails) resource.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/keymanagement/Decrypt.cs.html">here</a> to see an example of how to use Decrypt API.</example>
        public async Task<DecryptResponse> Decrypt(DecryptRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called decrypt");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/20180608/decrypt".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "KmsCrypto",
                    OperationName = "Decrypt",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/key/release/DecryptedData/Decrypt",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<DecryptResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"Decrypt failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Encrypts data using the given [EncryptDataDetails](https://docs.cloud.oracle.com/api/#/en/key/latest/datatypes/EncryptDataDetails) resource.
        /// Plaintext included in the example request is a base64-encoded value of a UTF-8 string.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/keymanagement/Encrypt.cs.html">here</a> to see an example of how to use Encrypt API.</example>
        public async Task<EncryptResponse> Encrypt(EncryptRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called encrypt");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/20180608/encrypt".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "KmsCrypto",
                    OperationName = "Encrypt",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/key/release/EncryptedData/Encrypt",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<EncryptResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"Encrypt failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Exports a specific version of a master encryption key according to the details of the request. For their protection,
        /// keys that you create and store on a hardware security module (HSM) can never leave the HSM. You can only export keys
        /// stored on the server. For export, the key version is encrypted by an RSA public key that you provide.
        /// This operation is not supported for keys having protection mode &#x60;EXTERNAL&#x60;.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/keymanagement/ExportKey.cs.html">here</a> to see an example of how to use ExportKey API.</example>
        public async Task<ExportKeyResponse> ExportKey(ExportKeyRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called exportKey");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/20180608/exportKey".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "KmsCrypto",
                    OperationName = "ExportKey",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/key/release/ExportedKeyData/ExportKey",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<ExportKeyResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"ExportKey failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Generates a key that you can use to encrypt or decrypt data.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/keymanagement/GenerateDataEncryptionKey.cs.html">here</a> to see an example of how to use GenerateDataEncryptionKey API.</example>
        public async Task<GenerateDataEncryptionKeyResponse> GenerateDataEncryptionKey(GenerateDataEncryptionKeyRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called generateDataEncryptionKey");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/20180608/generateDataEncryptionKey".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "KmsCrypto",
                    OperationName = "GenerateDataEncryptionKey",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/key/release/GeneratedKey/GenerateDataEncryptionKey",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<GenerateDataEncryptionKeyResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"GenerateDataEncryptionKey failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Creates a digital signature for a message or message digest by using the private key of a public-private key pair,
        /// also known as an asymmetric key. To verify the generated signature, you can use the [Verify](https://docs.cloud.oracle.com/api/#/en/key/latest/VerifiedData/Verify)
        /// operation. Or, if you want to validate the signature outside of the service, you can do so by using the public key of the same asymmetric key.
        /// This operation is not supported for keys having protection mode &#x60;EXTERNAL&#x60;.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/keymanagement/Sign.cs.html">here</a> to see an example of how to use Sign API.</example>
        public async Task<SignResponse> Sign(SignRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called sign");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/20180608/sign".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "KmsCrypto",
                    OperationName = "Sign",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/key/release/SignedData/Sign",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<SignResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"Sign failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Verifies a digital signature that was generated by the [Sign](https://docs.cloud.oracle.com/api/#/en/key/latest/SignedData/Sign) operation
        /// by using the public key of the same asymmetric key that was used to sign the data. If you want to validate the
        /// digital signature outside of the service, you can do so by using the public key of the asymmetric key.
        /// This operation is not supported for keys having protection mode &#x60;EXTERNAL&#x60;.
        /// 
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <param name="completionOption">The completion option for this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        /// <example>Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/keymanagement/Verify.cs.html">here</a> to see an example of how to use Verify API.</example>
        public async Task<VerifyResponse> Verify(VerifyRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default, HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead)
        {
            logger.Trace("Called verify");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/20180608/verify".Trim('/')));
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, completionOption, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage, completionOption: completionOption).ConfigureAwait(false);
                }
                stopWatch.Stop();
                ApiDetails apiDetails = new ApiDetails
                {
                    ServiceName = "KmsCrypto",
                    OperationName = "Verify",
                    RequestEndpoint = $"{method.Method} {requestMessage.RequestUri}",
                    ApiReferenceLink = "https://docs.oracle.com/iaas/api/#/en/key/release/VerifiedData/Verify",
                    UserAgent = this.GetUserAgent()
                };
                this.restClient.CheckHttpResponseMessage(requestMessage, responseMessage, apiDetails);
                logger.Debug($"Total Latency for this API call is: {stopWatch.ElapsedMilliseconds} ms");
                return Converter.FromHttpResponseMessage<VerifyResponse>(responseMessage);
            }
            catch (OciException e)
            {
                logger.Error(e);
                throw;
            }
            catch (Exception e)
            {
                logger.Error($"Verify failed with error: {e.Message}");
                throw;
            }
        }

    }
}
