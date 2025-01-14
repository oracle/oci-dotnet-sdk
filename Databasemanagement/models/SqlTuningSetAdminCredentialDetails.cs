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

namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The credential to connect to the database to perform Sql tuning set administration tasks.
    /// </summary>
    [JsonConverter(typeof(SqlTuningSetAdminCredentialDetailsModelConverter))]
    public class SqlTuningSetAdminCredentialDetails 
    {
                ///
        /// <value>
        /// The type of the credential for Sql tuning set administration tasks.
        /// </value>
        ///
        public enum SqlTuningSetAdminCredentialTypeEnum {
            [EnumMember(Value = "SECRET")]
            Secret,
            [EnumMember(Value = "PASSWORD")]
            Password
        };

        
        /// <value>
        /// The user to connect to the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Username is required.")]
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
                ///
        /// <value>
        /// The role of the database user.
        /// </value>
        ///
        public enum RoleEnum {
            [EnumMember(Value = "NORMAL")]
            Normal,
            [EnumMember(Value = "SYSDBA")]
            Sysdba
        };

        /// <value>
        /// The role of the database user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Role is required.")]
        [JsonProperty(PropertyName = "role")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RoleEnum> Role { get; set; }
        
    }

    public class SqlTuningSetAdminCredentialDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(SqlTuningSetAdminCredentialDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(SqlTuningSetAdminCredentialDetails);
            var discriminator = jsonObject["sqlTuningSetAdminCredentialType"].Value<string>();
            switch (discriminator)
            {
                case "PASSWORD":
                    obj = new SqlTuningSetAdminPasswordCredentialDetails();
                    break;
                case "SECRET":
                    obj = new SqlTuningSetAdminSecretCredentialDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
