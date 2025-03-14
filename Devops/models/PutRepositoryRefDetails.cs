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

namespace Oci.DevopsService.Models
{
    /// <summary>
    /// The information needed to create a reference. If the reference already exists, then it can be used to update the reference.
    /// </summary>
    [JsonConverter(typeof(PutRepositoryRefDetailsModelConverter))]
    public class PutRepositoryRefDetails 
    {
                ///
        /// <value>
        /// The type of reference (BRANCH or TAG).
        /// </value>
        ///
        public enum RefTypeEnum {
            [EnumMember(Value = "BRANCH")]
            Branch,
            [EnumMember(Value = "TAG")]
            Tag
        };

        
    }

    public class PutRepositoryRefDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(PutRepositoryRefDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(PutRepositoryRefDetails);
            var discriminator = jsonObject["refType"].Value<string>();
            switch (discriminator)
            {
                case "TAG":
                    obj = new PutRepositoryTagDetails();
                    break;
                case "BRANCH":
                    obj = new PutRepositoryBranchDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
