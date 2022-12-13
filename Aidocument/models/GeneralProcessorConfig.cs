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


namespace Oci.AidocumentService.Models
{
    /// <summary>
    /// The configuration of a general processor.
    /// </summary>
    public class GeneralProcessorConfig : ProcessorConfig
    {
        
        /// <value>
        /// The document type.
        /// </value>
        [JsonProperty(PropertyName = "documentType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DocumentType> DocumentType { get; set; }
        
        /// <value>
        /// The types of document analysis requested.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Features is required.")]
        [JsonProperty(PropertyName = "features")]
        public System.Collections.Generic.List<DocumentFeature> Features { get; set; }
        
        /// <value>
        /// Whether or not to generate a ZIP file containing the results.
        /// </value>
        [JsonProperty(PropertyName = "isZipOutputEnabled")]
        public System.Nullable<bool> IsZipOutputEnabled { get; set; }
        
        /// <value>
        /// The document language, abbreviated according to the BCP 47 Language-Tag syntax.
        /// </value>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }
        
        [JsonProperty(PropertyName = "processorType")]
        private readonly string processorType = "GENERAL";
    }
}