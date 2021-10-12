/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DatalabelingService.Models
{
  /// <summary>
  /// Possible operation types.
  /// </summary>
  public enum OperationType {
      [EnumMember(Value = "CREATE_DATASET")]
      CreateDataset,
      [EnumMember(Value = "DELETE_DATASET")]
      DeleteDataset,
      [EnumMember(Value = "MOVE_DATASET")]
      MoveDataset,
      [EnumMember(Value = "GENERATE_DATASET_RECORDS")]
      GenerateDatasetRecords,
      [EnumMember(Value = "SNAPSHOT_DATASET")]
      SnapshotDataset,
      [EnumMember(Value = "ADD_DATASET_LABELS")]
      AddDatasetLabels,
      [EnumMember(Value = "REMOVE_DATASET_LABELS")]
      RemoveDatasetLabels,
      [EnumMember(Value = "RENAME_DATASET_LABELS")]
      RenameDatasetLabels
  }
}
