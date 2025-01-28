/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.OpsiService.Models
{
  /// <summary>
  /// Source of the database entity. CRUD operations for Autonomous and MACS managed databases all route through DBaaS.
  /// </summary>
  public enum DatabaseEntitySource {
      [EnumMember(Value = "EM_MANAGED_EXTERNAL_DATABASE")]
      EmManagedExternalDatabase,
      [EnumMember(Value = "PE_COMANAGED_DATABASE")]
      PeComanagedDatabase,
      [EnumMember(Value = "MDS_MYSQL_DATABASE_SYSTEM")]
      MdsMysqlDatabaseSystem,
      [EnumMember(Value = "EXTERNAL_MYSQL_DATABASE_SYSTEM")]
      ExternalMysqlDatabaseSystem,
      [EnumMember(Value = "MACS_MANAGED_CLOUD_DATABASE")]
      MacsManagedCloudDatabase
  }
}
