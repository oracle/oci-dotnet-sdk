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
using System.Net.Http;
using Oci.CoreService.Requests;

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
                var prompt = "Tell me a fact about Oracle";
                var maxTokens = 1000;
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
                        IsStream = true,
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
                    try
                    {
                        GenerateTextResponse response = await client.GenerateText(request, completionOption: HttpCompletionOption.ResponseHeadersRead);

                        using (var stream = await response.httpResponseMessage.Content.ReadAsStreamAsync())
                        using (var reader = new System.IO.StreamReader(stream))
                        {
                            while (!reader.EndOfStream)
                            {
                                string line = await reader.ReadLineAsync();
                                if (line.StartsWith("data:"))
                                {
                                    // Extract the data part of the event by removing the "data: " prefix from the string
                                    string jsonContent = line.Substring("data: ".Length);
                                    Data data = JsonConvert.DeserializeObject<Data>(jsonContent);
                                    Console.Write($"{data.text}");
                                }
                            }
                            Console.WriteLine("");
                        }
                    }
                    catch (OciException ex)
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

    class Data
    {
        public string id { get; set; }
        public string text { get; set; }
    }
}