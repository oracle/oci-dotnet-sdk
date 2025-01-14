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
  /// A term workflow is a sequence of steps or tasks usually done by a data steward as part of the governance lifecycle.
    /// Business terms cannot be used for tagging unless they are APPROVED by the busines term owner (usually a data steward).
    /// By default, most terms, when created, are in the NEW status unless specified otherwise.
    /// NEW           - This is the default workflow status when a term is newly created. The owner can override this status during the creation.
    /// APPROVED      - This term is ready for use. It can be used to tag data assets, data entities, attributes, and other taggable resources.
    /// UNDER_REVIEW  - The term is currently under review and cannot be used until it is in APPROVED status.
    /// ESCALATED     - The review of this term is escalated to fast track for use in tagging.
    /// 
  /// </summary>
  public enum TermWorkflowStatus {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "NEW")]
      New,
      [EnumMember(Value = "APPROVED")]
      Approved,
      [EnumMember(Value = "UNDER_REVIEW")]
      UnderReview,
      [EnumMember(Value = "ESCALATED")]
      Escalated
  }
}
