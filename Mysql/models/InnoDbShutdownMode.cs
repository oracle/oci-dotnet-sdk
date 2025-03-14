/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.MysqlService.Models
{
  /// <summary>
  /// The InnoDB shutdown mode. If the value is \"SLOW\", InnoDB does a slow
    /// shutdown, a full purge and a change buffer merge before shutting
    /// down. If the value is \"FAST\", InnoDB skips these operations at shutdown,
    /// a process known as a fast shutdown. If the value is \"IMMEDIATE\", InnoDB
    /// flushes its logs and shuts down cold, as if MySQL had crashed; no
    /// committed transactions are lost, but the crash recovery operation makes
    /// the next startup take longer.
    /// <br/>
    /// The slow shutdown can take minutes, or even hours in extreme cases where
    /// substantial amounts of data are still buffered. Use the slow shutdown
    /// technique before upgrading or downgrading between MySQL major releases,
    /// so that all data files are fully prepared in case the upgrade process
    /// updates the file format.
    /// 
  /// </summary>
  public enum InnoDbShutdownMode {
      [EnumMember(Value = "IMMEDIATE")]
      Immediate,
      [EnumMember(Value = "FAST")]
      Fast,
      [EnumMember(Value = "SLOW")]
      Slow
  }
}
