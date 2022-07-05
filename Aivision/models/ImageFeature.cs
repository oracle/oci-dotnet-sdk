/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Oci.AivisionService.Models
{
    /// <summary>
    /// The type of image analysis.
    /// </summary>
    [JsonConverter(typeof(ImageFeatureModelConverter))]
    public class ImageFeature 
    {
                ///
        /// <value>
        /// The type of image analysis requested.
        /// The allowed values are:
        /// - `IMAGE_CLASSIFICATION`: Label the image.
        /// - `OBJECT_DETECTION`: Identify objects in the image with bounding boxes.
        /// - `TEXT_DETECTION`: Recognize text in the image.
        /// 
        /// </value>
        ///
        public enum FeatureTypeEnum {
            [EnumMember(Value = "IMAGE_CLASSIFICATION")]
            ImageClassification,
            [EnumMember(Value = "OBJECT_DETECTION")]
            ObjectDetection,
            [EnumMember(Value = "TEXT_DETECTION")]
            TextDetection
        };

        
    }

    public class ImageFeatureModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ImageFeature);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ImageFeature);
            var discriminator = jsonObject["featureType"].Value<string>();
            switch (discriminator)
            {
                case "TEXT_DETECTION":
                    obj = new ImageTextDetectionFeature();
                    break;
                case "OBJECT_DETECTION":
                    obj = new ImageObjectDetectionFeature();
                    break;
                case "IMAGE_CLASSIFICATION":
                    obj = new ImageClassificationFeature();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ImageFeature! Returning null value.");
            }
            return obj;
        }
    }
}
