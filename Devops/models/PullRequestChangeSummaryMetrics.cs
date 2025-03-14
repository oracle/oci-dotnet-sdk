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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Response object for obtaining summary metric of Pull Request changed files.
    /// </summary>
    public class PullRequestChangeSummaryMetrics 
    {
        
        /// <value>
        /// The number of lines added in whole difference.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ChangedFilesCount is required.")]
        [JsonProperty(PropertyName = "changedFilesCount")]
        public System.Nullable<int> ChangedFilesCount { get; set; }
        
        /// <value>
        /// The number of lines added in whole difference.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AddedLinesCount is required.")]
        [JsonProperty(PropertyName = "addedLinesCount")]
        public System.Nullable<int> AddedLinesCount { get; set; }
        
        /// <value>
        /// The number of lines deleted in whole difference.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DeletedLinesCount is required.")]
        [JsonProperty(PropertyName = "deletedLinesCount")]
        public System.Nullable<int> DeletedLinesCount { get; set; }
        
    }
}
