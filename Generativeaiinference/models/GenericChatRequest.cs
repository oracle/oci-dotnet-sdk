/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.GenerativeaiinferenceService.Models
{
    /// <summary>
    /// Details for the chat request.
    /// </summary>
    public class GenericChatRequest : BaseChatRequest
    {
        
        /// <value>
        /// The series of messages in a chat request. Includes the previous messages in a conversation. Each message includes a role (`USER` or the `CHATBOT`) and content.
        /// </value>
        [JsonProperty(PropertyName = "messages")]
        public System.Collections.Generic.List<Message> Messages { get; set; }
        
        /// <value>
        /// Whether to stream back partial progress. If set to true, as tokens become available, they are sent as data-only server-sent events.
        /// </value>
        [JsonProperty(PropertyName = "isStream")]
        public System.Nullable<bool> IsStream { get; set; }
        
        /// <value>
        /// The number of of generated texts that will be returned.
        /// </value>
        [JsonProperty(PropertyName = "numGenerations")]
        public System.Nullable<int> NumGenerations { get; set; }
        
        /// <value>
        /// Whether to include the user prompt in the response. Applies only to non-stream results.
        /// </value>
        [JsonProperty(PropertyName = "isEcho")]
        public System.Nullable<bool> IsEcho { get; set; }
        
        /// <value>
        /// An integer that sets up the model to use only the top k most likely tokens in the generated output. A higher k introduces more randomness into the output making the output text sound more natural. Default value is -1 which means to consider all tokens. Setting to 0 disables this method and considers all tokens.
        /// <br/>
        /// If also using top p, then the model considers only the top tokens whose probabilities add up to p percent and ignores the rest of the k tokens. For example, if k is 20, but the probabilities of the top 10 add up to .75, then only the top 10 tokens are chosen.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "topK")]
        public System.Nullable<int> TopK { get; set; }
        
        /// <value>
        /// If set to a probability 0.0 < p < 1.0, it ensures that only the most likely tokens, with total probability mass of p, are considered for generation at each step.
        /// <br/>
        /// To eliminate tokens with low likelihood, assign p a minimum percentage for the next token's likelihood. For example, when p is set to 0.75, the model eliminates the bottom 25 percent for the next token. Set to 1 to consider all tokens and set to 0 to disable. If both k and p are enabled, p acts after k.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "topP")]
        public System.Double TopP { get; set; }
        
        /// <value>
        /// A number that sets the randomness of the generated output. A lower temperature means a less random generations.
        /// <br/>
        /// Use lower numbers for tasks with a correct answer such as question answering or summarizing. High temperatures can generate hallucinations or factually incorrect information. Start with temperatures lower than 1.0 and increase the temperature for more creative outputs, as you regenerate the prompts to refine the outputs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "temperature")]
        public System.Double Temperature { get; set; }
        
        /// <value>
        /// To reduce repetitiveness of generated tokens, this number penalizes new tokens based on their frequency in the generated text so far. Values > 0 encourage the model to use new tokens and values < 0 encourage the model to repeat tokens. Set to 0 to disable.
        /// </value>
        [JsonProperty(PropertyName = "frequencyPenalty")]
        public System.Double FrequencyPenalty { get; set; }
        
        /// <value>
        /// To reduce repetitiveness of generated tokens, this number penalizes new tokens based on whether they've appeared in the generated text so far. Values > 0 encourage the model to use new tokens and values < 0 encourage the model to repeat tokens.
        /// <br/>
        /// Similar to frequency penalty, a penalty is applied to previously present tokens, except that this penalty is applied equally to all tokens that have already appeared, regardless of how many times they've appeared. Set to 0 to disable.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "presencePenalty")]
        public System.Double PresencePenalty { get; set; }
        
        /// <value>
        /// List of strings that stop the generation if they are generated for the response text. The returned output will not contain the stop strings.
        /// </value>
        [JsonProperty(PropertyName = "stop")]
        public System.Collections.Generic.List<string> Stop { get; set; }
        
        /// <value>
        /// Includes the logarithmic probabilities for the most likely output tokens and the chosen tokens.
        /// <br/>
        /// For example, if the log probability is 5, the API returns a list of the 5 most likely tokens. The API returns the log probability of the sampled token, so there might be up to logprobs+1 elements in the response.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "logProbs")]
        public System.Nullable<int> LogProbs { get; set; }
        
        /// <value>
        /// The maximum number of tokens that can be generated per output sequence. The token count of your prompt plus `maxTokens` must not exceed the model's context length.
        /// Not setting a value for maxTokens results in the possible use of model's full context length.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxTokens")]
        public System.Nullable<int> MaxTokens { get; set; }
        
        /// <value>
        /// Modifies the likelihood of specified tokens that appear in the completion.
        /// <br/>
        /// Example: '{&quot;6395&quot;: 2, &quot;8134&quot;: 1, &quot;21943&quot;: 0.5, &quot;5923&quot;: -100}'
        /// </value>
        [JsonProperty(PropertyName = "logitBias")]
        public System.Object LogitBias { get; set; }
        
        [JsonProperty(PropertyName = "apiFormat")]
        private readonly string apiFormat = "GENERIC";
    }
}
