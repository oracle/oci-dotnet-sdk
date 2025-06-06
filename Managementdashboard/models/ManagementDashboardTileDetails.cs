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


namespace Oci.ManagementdashboardService.Models
{
    /// <summary>
    /// Properties of the dashboard tile representing a saved search.  
    /// Tiles are laid out in a twelve column grid system with (0,0) at upper left corner.
    /// 
    /// </summary>
    public class ManagementDashboardTileDetails 
    {
        
        /// <value>
        /// Display name of the saved search.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// ID of the saved search.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SavedSearchId is required.")]
        [JsonProperty(PropertyName = "savedSearchId")]
        public string SavedSearchId { get; set; }
        
        /// <value>
        /// Tile's row number.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Row is required.")]
        [JsonProperty(PropertyName = "row")]
        public System.Nullable<int> Row { get; set; }
        
        /// <value>
        /// Tile's column number.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Column is required.")]
        [JsonProperty(PropertyName = "column")]
        public System.Nullable<int> Column { get; set; }
        
        /// <value>
        /// The number of rows the tile occupies.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Height is required.")]
        [JsonProperty(PropertyName = "height")]
        public System.Nullable<int> Height { get; set; }
        
        /// <value>
        /// The number of columns the tile occupies.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Width is required.")]
        [JsonProperty(PropertyName = "width")]
        public System.Nullable<int> Width { get; set; }
        
        /// <value>
        /// JSON that contains internationalization options.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Nls is required.")]
        [JsonProperty(PropertyName = "nls")]
        public System.Object Nls { get; set; }
        
        /// <value>
        /// It defines the visualization type of the widget saved search, the UI options of that visualization type, the binding of data to the visualization.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UiConfig is required.")]
        [JsonProperty(PropertyName = "uiConfig")]
        public System.Object UiConfig { get; set; }
        
        /// <value>
        /// It defines how data is fetched. A functional saved search needs a valid dataConfig. See examples on how it can be constructed for various data sources.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataConfig is required.")]
        [JsonProperty(PropertyName = "dataConfig")]
        public System.Collections.Generic.List<System.Object> DataConfig { get; set; }
                ///
        /// <value>
        /// Current state of the saved search.
        /// </value>
        ///
        public enum StateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "UNAUTHORIZED")]
            Unauthorized,
            [EnumMember(Value = "DEFAULT")]
            Default
        };

        /// <value>
        /// Current state of the saved search.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "State is required.")]
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StateEnum> State { get; set; }
        
        /// <value>
        /// Drill-down configuration to define the destination of a drill-down action.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DrilldownConfig is required.")]
        [JsonProperty(PropertyName = "drilldownConfig")]
        public System.Object DrilldownConfig { get; set; }
        
        /// <value>
        /// Specifies the saved search parameters values
        /// </value>
        [JsonProperty(PropertyName = "parametersMap")]
        public System.Object ParametersMap { get; set; }
        
        /// <value>
        /// Description of the tile.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
    }
}
