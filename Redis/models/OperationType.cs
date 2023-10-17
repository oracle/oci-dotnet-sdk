/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.RedisService.Models
{
  /// <summary>
  /// Possible operation types.
  /// </summary>
  public enum OperationType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATE_REDIS_CLUSTER")]
      CreateRedisCluster,
      [EnumMember(Value = "UPDATE_REDIS_CLUSTER")]
      UpdateRedisCluster,
      [EnumMember(Value = "DELETE_REDIS_CLUSTER")]
      DeleteRedisCluster,
      [EnumMember(Value = "MOVE_REDIS_CLUSTER")]
      MoveRedisCluster,
      [EnumMember(Value = "FAILOVER_REDIS_CLUSTER")]
      FailoverRedisCluster,
      [EnumMember(Value = "CREATE_REDIS_CONFIG_SET")]
      CreateRedisConfigSet,
      [EnumMember(Value = "UPDATE_REDIS_CONFIG_SET")]
      UpdateRedisConfigSet,
      [EnumMember(Value = "DELETE_REDIS_CONFIG_SET")]
      DeleteRedisConfigSet,
      [EnumMember(Value = "MOVE_REDIS_CONFIG_SET")]
      MoveRedisConfigSet
  }
}
