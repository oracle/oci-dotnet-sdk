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

namespace Oci.CoreService.Models
{
    /// <summary>
    /// The license config requested for the instance.
    /// </summary>
    [JsonConverter(typeof(LaunchInstanceLicensingConfigModelConverter))]
    public class LaunchInstanceLicensingConfig 
    {
                ///
        /// <value>
        /// Operating System type of the Configuration.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "WINDOWS")]
            Windows
        };

                ///
        /// <value>
        /// License Type for the OS license.
        /// * `OCI_PROVIDED` - OCI provided license (e.g. metered $/OCPU-hour).
        /// * `BRING_YOUR_OWN_LICENSE` - Bring your own license.
        /// 
        /// </value>
        ///
        public enum LicenseTypeEnum {
            [EnumMember(Value = "OCI_PROVIDED")]
            OciProvided,
            [EnumMember(Value = "BRING_YOUR_OWN_LICENSE")]
            BringYourOwnLicense
        };

        /// <value>
        /// License Type for the OS license.
        /// * `OCI_PROVIDED` - OCI provided license (e.g. metered $/OCPU-hour).
        /// * `BRING_YOUR_OWN_LICENSE` - Bring your own license.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "licenseType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LicenseTypeEnum> LicenseType { get; set; }
        
    }

    public class LaunchInstanceLicensingConfigModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(LaunchInstanceLicensingConfig);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(LaunchInstanceLicensingConfig);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "WINDOWS":
                    obj = new LaunchInstanceWindowsLicensingConfig();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under LaunchInstanceLicensingConfig! Returning null value.");
            }
            return obj;
        }
    }
}
