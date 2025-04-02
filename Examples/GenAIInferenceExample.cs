/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Oci.Common.Auth;
using Oci.GenerativeaiinferenceService;
using Oci.GenerativeaiinferenceService.Models;
using Oci.GenerativeaiinferenceService.Requests;
using Oci.GenerativeaiinferenceService.Responses;

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
                var provider = new SessionTokenAuthenticationDetailsProvider(Environment.GetEnvironmentVariable("PROFILE_WITH_SESSION_TOKEN") ?? "DEFAULT");
                var clientConfiguration = new Common.ClientConfiguration
                {
                    ClientCertificateOption = ClientCertificateOption.Manual
                };
                using (client = new GenerativeAiInferenceClient(provider, clientConfiguration))
                {
                    await CohereChatSse(client);
                }
            }
            catch (Exception ex)
            {
                logger.Info($"Exception occurred with GenerativeAiInferenceClient: {ex}");
                throw;
            }
            finally
            {
                client.Dispose();
            }
        }

        private static async Task CohereChatSse(GenerativeAiInferenceClient client)
        {
            var message = "Tell me something about the company's database services.";

            CohereMessage previousChatMessage = new CohereUserMessage
            {
                Message = "Tell me something about Oracle."
            };

            CohereMessage previousChatReply = new CohereChatBotMessage
            {
                Message = "Oracle is one of the largest vendors in the enterprise IT market and the shorthand name of its flagship product. The database software sits at the center of many corporate IT"
            };

            List<CohereMessage> chatHistory = new List<CohereMessage> { previousChatMessage, previousChatReply };

            var cohereChatRequest = new CohereChatRequest
            {
                Message = message,
                ChatHistory = chatHistory,
                MaxTokens = 100,
                Temperature = 0.75,
                FrequencyPenalty = 0.0,
                TopP = 0.7,
                TopK = 1,
                IsStream = true
            };

            var chatDetails = new ChatDetails
            {
                ServingMode = new OnDemandServingMode
                {
                    ModelId = "cohere.command-r-plus-08-2024"
                },
                CompartmentId = Environment.GetEnvironmentVariable("OCI_COMPARTMENT_ID"),
                ChatRequest = cohereChatRequest
            };

            var request = new ChatRequest
            {
                ChatDetails = chatDetails
            };

            logger.Info($"Request: {JsonConvert.SerializeObject(request)}");
            Console.WriteLine("Start chatting");
            try
            {
                ChatResponse response = await client.Chat(request, completionOption: HttpCompletionOption.ResponseHeadersRead);

                using (var stream = await response.httpResponseMessage.Content.ReadAsStreamAsync())
                using (var reader = new System.IO.StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = await reader.ReadLineAsync();
                        if (line.StartsWith("data:"))
                        {
                            // Extract the data part of the event by removing the "data: " prefix from the string
                            // example: data: {"apiFormat":"COHERE","text":"hello"}
                            string jsonContent = line.Substring("data: ".Length);
                            CohereChatResponse cohereChatResponse = JsonConvert.DeserializeObject<CohereChatResponse>(jsonContent);
                            Console.Write($"{cohereChatResponse.Text}");
                        }
                    }
                    Console.WriteLine("");
                }

                logger.Info($"Response from chat: {JsonConvert.SerializeObject(response)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}