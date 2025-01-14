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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// The set of CPE configuration answers for the tunnel, which the customer provides in
    /// {@link #updateTunnelCpeDeviceConfig(UpdateTunnelCpeDeviceConfigRequest) updateTunnelCpeDeviceConfig}.
    /// The answers correlate to the questions that are specific to the CPE device type (see the
    /// `parameters` attribute of {@link CpeDeviceShapeDetail}).
    /// <br/>
    /// See these related operations:
    /// <br/>
    ///   * {@link #getTunnelCpeDeviceConfig(GetTunnelCpeDeviceConfigRequest) getTunnelCpeDeviceConfig}
    ///   * {@link #getTunnelCpeDeviceConfigContent(GetTunnelCpeDeviceConfigContentRequest) getTunnelCpeDeviceConfigContent}
    ///   * {@link #getIpsecCpeDeviceConfigContent(GetIpsecCpeDeviceConfigContentRequest) getIpsecCpeDeviceConfigContent}
    ///   * {@link #getCpeDeviceConfigContent(GetCpeDeviceConfigContentRequest) getCpeDeviceConfigContent}
    /// 
    /// </summary>
    public class TunnelCpeDeviceConfig 
    {
        
        [JsonProperty(PropertyName = "tunnelCpeDeviceConfigParameter")]
        public System.Collections.Generic.List<CpeDeviceConfigAnswer> TunnelCpeDeviceConfigParameter { get; set; }
        
    }
}
