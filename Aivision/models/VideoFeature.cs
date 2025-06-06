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

namespace Oci.AivisionService.Models
{
    /// <summary>
    /// Details about a video feature request.
    /// </summary>
    [JsonConverter(typeof(VideoFeatureModelConverter))]
    public class VideoFeature 
    {
                ///
        /// <value>
        /// The feature of video analysis.
        /// Allowed values are:
        /// - LABEL_DETECTION: Label detection feature(IC).
        /// - OBJECT_DETECTION: Object detection feature(OD).
        /// - TEXT_DETECTION: Text detection feature(OCR).
        /// - FACE_DETECTION: Face detection feature(fd).
        /// - OBJECT_TRACKING: Object tracking feature(OT).
        /// 
        /// </value>
        ///
        public enum FeatureTypeEnum {
            [EnumMember(Value = "LABEL_DETECTION")]
            LabelDetection,
            [EnumMember(Value = "OBJECT_DETECTION")]
            ObjectDetection,
            [EnumMember(Value = "TEXT_DETECTION")]
            TextDetection,
            [EnumMember(Value = "FACE_DETECTION")]
            FaceDetection,
            [EnumMember(Value = "OBJECT_TRACKING")]
            ObjectTracking
        };

        
    }

    public class VideoFeatureModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(VideoFeature);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(VideoFeature);
            var discriminator = jsonObject["featureType"].Value<string>();
            switch (discriminator)
            {
                case "OBJECT_DETECTION":
                    obj = new VideoObjectDetectionFeature();
                    break;
                case "FACE_DETECTION":
                    obj = new VideoFaceDetectionFeature();
                    break;
                case "TEXT_DETECTION":
                    obj = new VideoTextDetectionFeature();
                    break;
                case "OBJECT_TRACKING":
                    obj = new VideoObjectTrackingFeature();
                    break;
                case "LABEL_DETECTION":
                    obj = new VideoLabelDetectionFeature();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under VideoFeature! Returning null value.");
            }
            return obj;
        }
    }
}
