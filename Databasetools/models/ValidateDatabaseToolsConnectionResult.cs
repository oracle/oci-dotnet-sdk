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
using Newtonsoft.Json.Linq;

namespace Oci.DatabasetoolsService.Models
{
    /// <summary>
    /// Connection validation result.
    /// </summary>
    [JsonConverter(typeof(ValidateDatabaseToolsConnectionResultModelConverter))]
    public class ValidateDatabaseToolsConnectionResult 
    {
        
        
        /// <value>
        /// A short code that defines the result of the validation, meant for programmatic parsing. The value OK indicates that the validation was successful.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Code is required.")]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
        
        /// <value>
        /// A human-readable message that describes the result of the validation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Message is required.")]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        
        /// <value>
        /// A human-readable message that describes possible causes for the validation error.
        /// </value>
        [JsonProperty(PropertyName = "cause")]
        public string Cause { get; set; }
        
        /// <value>
        /// A human-readable message that suggests a remedial action to resolve the validation error.
        /// </value>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }
        
    }

    public class ValidateDatabaseToolsConnectionResultModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ValidateDatabaseToolsConnectionResult);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ValidateDatabaseToolsConnectionResult);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "ORACLE_DATABASE":
                    obj = new ValidateDatabaseToolsConnectionOracleDatabaseResult();
                    break;
                case "MYSQL":
                    obj = new ValidateDatabaseToolsConnectionMySqlResult();
                    break;
                case "POSTGRESQL":
                    obj = new ValidateDatabaseToolsConnectionPostgresqlResult();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ValidateDatabaseToolsConnectionResult! Returning null value.");
            }
            return obj;
        }
    }
}
