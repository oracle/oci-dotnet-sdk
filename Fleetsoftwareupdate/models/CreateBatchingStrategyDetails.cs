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

namespace Oci.FleetsoftwareupdateService.Models
{
    /// <summary>
    /// Batching strategy details to use during PRECHECK and APPLY Cycle Actions.
    /// 
    /// </summary>
    [JsonConverter(typeof(CreateBatchingStrategyDetailsModelConverter))]
    public class CreateBatchingStrategyDetails 
    {
        
        
    }

    public class CreateBatchingStrategyDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(CreateBatchingStrategyDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(CreateBatchingStrategyDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "SEQUENTIAL":
                    obj = new CreateSequentialBatchingStrategyDetails();
                    break;
                case "FIFTY_FIFTY":
                    obj = new CreateFiftyFiftyBatchingStrategyDetails();
                    break;
                case "SERVICE_AVAILABILITY_FACTOR":
                    obj = new CreateServiceAvailabilityFactorBatchingStrategyDetails();
                    break;
                case "NON_ROLLING":
                    obj = new CreateNonRollingBatchingStrategyDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
