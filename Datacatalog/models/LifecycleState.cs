/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DatacatalogService.Models
{
  /// <summary>
  /// Common lifecycle states for resources in data catalog:
    /// CREATING - The resource is being created and may not be usable until the entire metadata is defined.
    /// UPDATING - The resource is being updated and may not be usable until all changes are commited.
    /// DELETING - The resource is being deleted and might require deep cleanup of children.
    /// ACTIVE   - The resource is valid and available for access.
    /// INACTIVE - The resource might be incomplete in its definition or might have been made unavailable for
    ///            administrative reasons.
    /// DELETED  - The resource has been deleted and isn't available.
    /// FAILED   - The resource is in a failed state due to validation or other errors.
    /// MOVING   - The resource is being moved to another compartment (action changeCompartment)
    /// 
  /// </summary>
  public enum LifecycleState {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATING")]
      Creating,
      [EnumMember(Value = "ACTIVE")]
      Active,
      [EnumMember(Value = "INACTIVE")]
      Inactive,
      [EnumMember(Value = "UPDATING")]
      Updating,
      [EnumMember(Value = "DELETING")]
      Deleting,
      [EnumMember(Value = "DELETED")]
      Deleted,
      [EnumMember(Value = "FAILED")]
      Failed,
      [EnumMember(Value = "MOVING")]
      Moving
  }
}
