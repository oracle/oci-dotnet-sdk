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


namespace Oci.AilanguageService.Models
{
    /// <summary>
    /// The relation entities details for health ner.
    /// </summary>
    public class RelationEntity 
    {
        
        /// <value>
        /// id of the relation
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Subject entity of the relation. eg,MEDICINE_NAME, EXAMINATION
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubjectId is required.")]
        [JsonProperty(PropertyName = "subjectId")]
        public string SubjectId { get; set; }
        
        /// <value>
        /// Object entity of the relation. eg, MEDICINE_DOSAGE, MEDICINE_DURATION, MEASUREMENT
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectId is required.")]
        [JsonProperty(PropertyName = "objectId")]
        public string ObjectId { get; set; }
        
        /// <value>
        /// Type of relation between subject entity and object entity. eg,EXAMINATION_MEASUREMENT, FREQUENCY, DOSAGE
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// Score or confidence for detected entity.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Score is required.")]
        [JsonProperty(PropertyName = "score")]
        public System.Double Score { get; set; }
        
    }
}
