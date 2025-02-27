/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DatabasemigrationService.Models
{
  /// <summary>
  /// Compatibility option.
    /// FORCE_INNODB - Change CREATE TABLE statements to use the InnoDB storage engine
    ///   for any tables that do not already use it.
    /// SKIP_INVALID_ACCOUNTS - Remove user accounts created with external authentication plugins
    ///   that are not supported in MySQL HeatWave Service.
    /// STRIP_DEFINERS - Remove the DEFINER clause from views, routines, events, and triggers, so these
    ///   objects are created with the default definer.
    /// STRIP_RESTRICTED_GRANTS - Remove specific privileges that are restricted by MySQL HeatWave Service
    ///   from GRANT statements, so users and their roles cannot be given these privileges
    /// STRIP_TABLESPACES - Remove the TABLESPACE clause from CREATE TABLE statements,
    ///   so all tables are created in their default tablespaces.
    /// IGNORE_WILDCARD_GRANTS - Ignore errors from grants on schemas with wildcards, which are interpreted
    ///   differently in systems where the partial_revokes system variable is enabled.
    /// STRIP_INVALID_GRANTS - Strip grant statements which would fail when users are loaded.
    ///   Such as grants referring to a specific routine which does not exist.
    /// 
  /// </summary>
  public enum CompatibilityOption {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "FORCE_INNODB")]
      ForceInnodb,
      [EnumMember(Value = "SKIP_INVALID_ACCOUNTS")]
      SkipInvalidAccounts,
      [EnumMember(Value = "STRIP_DEFINERS")]
      StripDefiners,
      [EnumMember(Value = "STRIP_RESTRICTED_GRANTS")]
      StripRestrictedGrants,
      [EnumMember(Value = "STRIP_TABLESPACES")]
      StripTablespaces,
      [EnumMember(Value = "IGNORE_WILDCARD_GRANTS")]
      IgnoreWildcardGrants,
      [EnumMember(Value = "STRIP_INVALID_GRANTS")]
      StripInvalidGrants
  }
}
