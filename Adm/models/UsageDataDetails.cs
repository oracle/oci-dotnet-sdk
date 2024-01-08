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
using Newtonsoft.Json.Linq;

namespace Oci.AdmService.Models
{
    /// <summary>
    /// The source details of the usage data on Object Storage.
    /// Set `sourceType` to `objectStorageTuple`
    /// and use {@link #usageDataViaObjectStorageTupleDetails(UsageDataViaObjectStorageTupleDetailsRequest) usageDataViaObjectStorageTupleDetails}
    /// when specifying the namespace, bucket name, and object name.
    /// 
    /// </summary>
    [JsonConverter(typeof(UsageDataDetailsModelConverter))]
    public class UsageDataDetails 
    {
        
        
    }

    public class UsageDataDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(UsageDataDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(UsageDataDetails);
            var discriminator = jsonObject["sourceType"].Value<string>();
            switch (discriminator)
            {
                case "objectStorageTuple":
                    obj = new UsageDataViaObjectStorageTupleDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
