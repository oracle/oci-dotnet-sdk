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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Data Transfer Medium details for the Migration. If not specified, it will default to Database Link. Only one type
    /// of data transfer medium can be specified, except for the case of Amazon RDS Oracle as source, where Object Storage
    /// Details along with AwsS3Details are required.
    /// 
    /// </summary>
    public class CreateDataTransferMediumDetails 
    {
        
        [JsonProperty(PropertyName = "databaseLinkDetails")]
        public CreateDatabaseLinkDetails DatabaseLinkDetails { get; set; }
        
        [JsonProperty(PropertyName = "objectStorageDetails")]
        public CreateObjectStoreBucket ObjectStorageDetails { get; set; }
        
        [JsonProperty(PropertyName = "awsS3Details")]
        public CreateAwsS3Details AwsS3Details { get; set; }
        
    }
}
