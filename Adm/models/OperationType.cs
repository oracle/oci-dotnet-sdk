/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.AdmService.Models
{
  /// <summary>
  /// Possible operation types.
  /// </summary>
  public enum OperationType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATE_REMEDIATION_RECIPE")]
      CreateRemediationRecipe,
      [EnumMember(Value = "DELETE_REMEDIATION_RECIPE")]
      DeleteRemediationRecipe,
      [EnumMember(Value = "MOVE_REMEDIATION_RECIPE")]
      MoveRemediationRecipe,
      [EnumMember(Value = "UPDATE_REMEDIATION_RECIPE")]
      UpdateRemediationRecipe,
      [EnumMember(Value = "ACTIVATE_REMEDIATION_RECIPE")]
      ActivateRemediationRecipe,
      [EnumMember(Value = "DEACTIVATE_REMEDIATION_RECIPE")]
      DeactivateRemediationRecipe,
      [EnumMember(Value = "CREATE_KNOWLEDGE_BASE")]
      CreateKnowledgeBase,
      [EnumMember(Value = "DELETE_KNOWLEDGE_BASE")]
      DeleteKnowledgeBase,
      [EnumMember(Value = "MOVE_KNOWLEDGE_BASE")]
      MoveKnowledgeBase,
      [EnumMember(Value = "UPDATE_KNOWLEDGE_BASE")]
      UpdateKnowledgeBase
  }
}
