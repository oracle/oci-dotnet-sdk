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
    /// The filters for the trigger.
    /// </summary>
    [JsonConverter(typeof(FilterModelConverter))]
    public class Filter 
    {
        
        
    }

    public class FilterModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(Filter);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(Filter);
            var discriminator = jsonObject["triggerSource"].Value<string>();
            switch (discriminator)
            {
                case "VBS":
                    obj = new VbsFilter();
                    break;
                case "DEVOPS_CODE_REPOSITORY":
                    obj = new DevopsCodeRepositoryFilter();
                    break;
                case "BITBUCKET_CLOUD":
                    obj = new BitbucketCloudFilter();
                    break;
                case "BITBUCKET_SERVER":
                    obj = new BitbucketServerFilter();
                    break;
                case "GITLAB":
                    obj = new GitlabFilter();
                    break;
                case "GITHUB":
                    obj = new GithubFilter();
                    break;
                case "GITLAB_SERVER":
                    obj = new GitlabServerFilter();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
