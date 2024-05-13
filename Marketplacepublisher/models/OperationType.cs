/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.MarketplacepublisherService.Models
{
  /// <summary>
  /// Possible operation types.
  /// </summary>
  public enum OperationType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATE_OFFER")]
      CreateOffer,
      [EnumMember(Value = "UPDATE_OFFER")]
      UpdateOffer,
      [EnumMember(Value = "DELETE_OFFER")]
      DeleteOffer,
      [EnumMember(Value = "MOVE_OFFER")]
      MoveOffer,
      [EnumMember(Value = "DELETE_OFFER_ATTACHMENT")]
      DeleteOfferAttachment,
      [EnumMember(Value = "PUBLISH_LISTING_REVISION_PACKAGE")]
      PublishListingRevisionPackage,
      [EnumMember(Value = "UNPUBLISH_LISTING_REVISION_PACKAGE")]
      UnpublishListingRevisionPackage,
      [EnumMember(Value = "PUBLISH_LISTING_REVISION")]
      PublishListingRevision,
      [EnumMember(Value = "PUBLISH_LISTING_REVISION_AS_PRIVATE")]
      PublishListingRevisionAsPrivate,
      [EnumMember(Value = "WITHDRAW_LISTING_REVISION")]
      WithdrawListingRevision,
      [EnumMember(Value = "CLONE_LISTING_REVISION")]
      CloneListingRevision,
      [EnumMember(Value = "CASCADING_DELETE_LISTING")]
      CascadingDeleteListing,
      [EnumMember(Value = "CASCADING_DELETE_LISTING_REVISION")]
      CascadingDeleteListingRevision,
      [EnumMember(Value = "MARK_AS_DEFAULT_LISTING_REVISION_PACKAGE")]
      MarkAsDefaultListingRevisionPackage,
      [EnumMember(Value = "CHANGE_LISTING_COMPARTMENT")]
      ChangeListingCompartment,
      [EnumMember(Value = "CREATE_ARTIFACT")]
      CreateArtifact,
      [EnumMember(Value = "VALIDATE_AND_PUBLISH_ARTIFACT")]
      ValidateAndPublishArtifact,
      [EnumMember(Value = "CHANGE_ARTIFACT_COMPARTMENT")]
      ChangeArtifactCompartment,
      [EnumMember(Value = "CHANGE_TERM_COMPARTMENT")]
      ChangeTermCompartment,
      [EnumMember(Value = "DELETE_ARTIFACT")]
      DeleteArtifact
  }
}
