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


namespace Oci.AilanguageService.Models
{
    /// <summary>
    /// The MEL concepts details for health ner.
    /// </summary>
    public class MelConcept 
    {
        
        /// <value>
        /// Name of the ontology to which the Entity is mapped
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OntologyName is required.")]
        [JsonProperty(PropertyName = "ontologyName")]
        public string OntologyName { get; set; }
        
        /// <value>
        /// This contains the list of matched concepts which are ranked by the relevant score with the input text
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Concepts is required.")]
        [JsonProperty(PropertyName = "concepts")]
        public System.Collections.Generic.List<MelConceptDetails> Concepts { get; set; }
        
    }
}
