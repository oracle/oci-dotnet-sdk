/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Oci.GenerativeaiinferenceService;
using Oci.GenerativeaiinferenceService.Requests;
using Oci.GenerativeaiinferenceService.Responses;

using Oci.Common.Auth;
using Oci.Common.Model;

namespace Oci.Examples
{
    public class GenAIInferenceExample
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static async Task MainGenAI()
        {
            logger.Info("Starting GenAI example");
            GenerativeAiInferenceClient client = null;

            // Create GenerativeAiInferenceClient
            try
            {
                var modelId = "cohere.command";
                var prompt = "Tell me a fact about the Earth";
                var maxTokens = 75;
                var temperature = 0.75;
                var frequencyPenalty = 1.0;
                var topP = 0.7;
                var provider = new SessionTokenAuthenticationDetailsProvider(Environment.GetEnvironmentVariable("PROFILE_WITH_SESSION_TOKEN") ?? "DEFAULT");

                using (client = new GenerativeAiInferenceClient(provider, new Common.ClientConfiguration()))
                {
                    // client.SetEndpoint("https://ppe.inference.generativeai.us-chicago-1.oci.oraclecloud.com");
                    var inferenceRequest = new GenerativeaiinferenceService.Models.CohereLlmInferenceRequest
                    {
                        Prompt = prompt,
                        IsStream = false,
                        MaxTokens = maxTokens,
                        Temperature = temperature,
                        FrequencyPenalty = frequencyPenalty,
                        TopP = topP
                    };

                    var details = new GenerativeaiinferenceService.Models.GenerateTextDetails
                    {
                        CompartmentId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID"),
                        ServingMode = new GenerativeaiinferenceService.Models.OnDemandServingMode
                        {
                            ModelId = modelId
                        },
                        InferenceRequest = inferenceRequest
                    };
                    var request = new GenerateTextRequest
                    {
                        GenerateTextDetails = details
                    };
                    GenerateTextResponse response = await client.GenerateText(request);
                    logger.Info($"Response from generate text: {JsonConvert.SerializeObject(response)}");
                    try
                    {
                        inferenceRequest.IsStream = true;
                        response = await client.GenerateText(request);
                    }
                    catch(OciException ex)
                    {
                        logger.Info($"Caught expected exception:{ex}");
                    }

                }
            }
            catch (Exception ex)
            {
                logger.Info($"Exception occurred with GenerativeAiInferenceClient: {ex}");
                throw ex;
            }
        }

    }
}