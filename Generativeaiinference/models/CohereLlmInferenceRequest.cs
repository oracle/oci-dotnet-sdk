/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    /// Details for the text generation request for Cohere models.
    /// </summary>
    public class CohereLlmInferenceRequest : LlmInferenceRequest
    {
        
        /// <value>
        /// Represents the prompt to be completed. The trailing white spaces are trimmed before completion.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Prompt is required.")]
        [JsonProperty(PropertyName = "prompt")]
        public string Prompt { get; set; }
        
        /// <value>
        /// Whether to stream back partial progress. If set, tokens are sent as data-only server-sent events as they become available.
        /// </value>
        [JsonProperty(PropertyName = "isStream")]
        public System.Nullable<bool> IsStream { get; set; }
        
        /// <value>
        /// The number of generated texts that will be returned.
        /// </value>
        [JsonProperty(PropertyName = "numGenerations")]
        public System.Nullable<int> NumGenerations { get; set; }
        
        /// <value>
        /// Whether or not to return the user prompt in the response. This option only applies to non-stream results.
        /// </value>
        [JsonProperty(PropertyName = "isEcho")]
        public System.Nullable<bool> IsEcho { get; set; }
        
        /// <value>
        /// The maximum number of tokens to predict for each response. Includes input plus output tokens.
        /// </value>
        [JsonProperty(PropertyName = "maxTokens")]
        public System.Nullable<int> MaxTokens { get; set; }
        
        /// <value>
        /// A number that sets the randomness of the generated output. A lower temperature means a less random generations.
        /// <br/>
        /// Use lower numbers for tasks with a correct answer such as question answering or summarizing. High temperatures can generate hallucinations or factually incorrect information. Start with temperatures lower than 1.0 and increase the temperature for more creative outputs, as you regenerate the prompts to refine the outputs.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "temperature")]
        public System.Double Temperature { get; set; }
        
        /// <value>
        /// An integer that sets up the model to use only the top k most likely tokens in the generated output. A higher k introduces more randomness into the output making the output text sound more natural. Default value is 0 which disables this method and considers all tokens. To set a number for the likely tokens, choose an integer between 1 and 500.
        /// <br/>
        /// If also using top p, then the model considers only the top tokens whose probabilities add up to p percent and ignores the rest of the k tokens. For example, if k is 20, but the probabilities of the top 10 add up to .75, then only the top 10 tokens are chosen.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "topK")]
        public System.Nullable<int> TopK { get; set; }
        
        /// <value>
        /// If set to a probability 0.0 < p < 1.0, it ensures that only the most likely tokens, with total probability mass of p, are considered for generation at each step.
        /// <br/>
        /// To eliminate tokens with low likelihood, assign p a minimum percentage for the next token's likelihood. For example, when p is set to 0.75, the model eliminates the bottom 25 percent for the next token. Set to 1.0 to consider all tokens and set to 0 to disable. If both k and p are enabled, p acts after k.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "topP")]
        public System.Double TopP { get; set; }
        
        /// <value>
        /// To reduce repetitiveness of generated tokens, this number penalizes new tokens based on their frequency in the generated text so far. Greater numbers encourage the model to use new tokens, while lower numbers encourage the model to repeat the tokens. Set to 0 to disable.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "frequencyPenalty")]
        public System.Double FrequencyPenalty { get; set; }
        
        /// <value>
        /// To reduce repetitiveness of generated tokens, this number penalizes new tokens based on whether they've appeared in the generated text so far. Greater numbers encourage the model to use new tokens, while lower numbers encourage the model to repeat the tokens.
        /// <br/>
        /// Similar to frequency penalty, a penalty is applied to previously present tokens, except that this penalty is applied equally to all tokens that have already appeared, regardless of how many times they've appeared. Set to 0 to disable.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "presencePenalty")]
        public System.Double PresencePenalty { get; set; }
        
        /// <value>
        /// The generated text is cut at the end of the earliest occurrence of this stop sequence. The generated text will include this stop sequence.
        /// </value>
        [JsonProperty(PropertyName = "stopSequences")]
        public System.Collections.Generic.List<string> StopSequences { get; set; }
                ///
        /// <value>
        /// Specifies how and if the token likelihoods are returned with the response.
        /// </value>
        ///
        public enum ReturnLikelihoodsEnum {
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "ALL")]
            All,
            [EnumMember(Value = "GENERATION")]
            Generation
        };

        /// <value>
        /// Specifies how and if the token likelihoods are returned with the response.
        /// </value>
        [JsonProperty(PropertyName = "returnLikelihoods")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ReturnLikelihoodsEnum> ReturnLikelihoods { get; set; }
                ///
        /// <value>
        /// For an input that's longer than the maximum token length, specifies which part of the input text will be truncated.
        /// </value>
        ///
        public enum TruncateEnum {
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "START")]
            Start,
            [EnumMember(Value = "END")]
            End
        };

        /// <value>
        /// For an input that's longer than the maximum token length, specifies which part of the input text will be truncated.
        /// </value>
        [JsonProperty(PropertyName = "truncate")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TruncateEnum> Truncate { get; set; }
        
        [JsonProperty(PropertyName = "runtimeType")]
        private readonly string runtimeType = "COHERE";
    }
}
