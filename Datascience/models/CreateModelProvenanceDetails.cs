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


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// Model provenance gives data scientists information about the origin of their model. This information allows data scientists to reproduce the development environment in which the model was trained.
    /// </summary>
    public class CreateModelProvenanceDetails 
    {
        
        /// <value>
        /// For model reproducibility purposes. URL of the git repository associated with model training.
        /// </value>
        [JsonProperty(PropertyName = "repositoryUrl")]
        public string RepositoryUrl { get; set; }
        
        /// <value>
        /// For model reproducibility purposes. Branch of the git repository associated with model training.
        /// </value>
        [JsonProperty(PropertyName = "gitBranch")]
        public string GitBranch { get; set; }
        
        /// <value>
        /// For model reproducibility purposes. Commit ID of the git repository associated with model training.
        /// </value>
        [JsonProperty(PropertyName = "gitCommit")]
        public string GitCommit { get; set; }
        
        /// <value>
        /// For model reproducibility purposes. Path to model artifacts.
        /// </value>
        [JsonProperty(PropertyName = "scriptDir")]
        public string ScriptDir { get; set; }
        
        /// <value>
        /// For model reproducibility purposes. Path to the python script or notebook in which the model was trained.\"
        /// 
        /// </value>
        [JsonProperty(PropertyName = "trainingScript")]
        public string TrainingScript { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of a training session(Job or NotebookSession) in which the model was trained. It is used for model reproducibility purposes.
        /// </value>
        [JsonProperty(PropertyName = "trainingId")]
        public string TrainingId { get; set; }
        
    }
}
