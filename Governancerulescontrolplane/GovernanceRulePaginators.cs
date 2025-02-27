/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Collections.Generic;
using System.Threading;
using Oci.GovernancerulescontrolplaneService.Requests;
using Oci.GovernancerulescontrolplaneService.Responses;
using Oci.GovernancerulescontrolplaneService.Models;

namespace Oci.GovernancerulescontrolplaneService
{
    /// <summary>
    /// Collection of helper methods that can be used to provide an enumerator interface
    /// to any list operations of GovernanceRule where multiple pages of data may be fetched.
    /// Two styles of enumerators are supported:
    /// <list type="bullet">
    /// <item>
    /// <description>
    /// Enumerating over the Response objects returned by the list operation. These are referred to as ResponseEnumerators, and the methods are suffixed with ResponseEnumerator. For example: listUsersResponseEnumerator.
    /// </description>
    /// </item>
    /// <item>
    /// <description>
    /// Enumerating over the resources/records being listed. These are referred to as RecordEnumerators, and the methods are suffixed with RecordEnumerator. For example: listUsersRecordEnumerator.
    /// </description>
    /// </item>
    /// </list>
    /// These enumerators abstract away the need to write code to manually handle pagination via looping and using the page tokens.
    /// They will automatically fetch more data from the service when required.
    /// <br/>
    /// <br/>
    /// As an example, if we were using the ListUsers operation in IdentityService, then the iterator returned by calling a
    /// ResponseEnumerator method would iterate over the ListUsersResponse objects returned by each ListUsers call, whereas the enumerables
    /// returned by calling a RecordEnumerator method would iterate over the User records and we don't have to deal with ListUsersResponse objects at all.
    /// In either case, pagination will be automatically handled so we can iterate until there are no more responses or no more resources/records available.
    /// </summary>
    public class GovernanceRulePaginators
    {
        private readonly GovernanceRuleClient client;

        public GovernanceRulePaginators(GovernanceRuleClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListEnforcedGovernanceRules operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListEnforcedGovernanceRulesResponse> ListEnforcedGovernanceRulesResponseEnumerator(ListEnforcedGovernanceRulesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListEnforcedGovernanceRulesRequest, ListEnforcedGovernanceRulesResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListEnforcedGovernanceRules(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the EnforcedGovernanceRuleSummary objects
        /// contained in responses from the ListEnforcedGovernanceRules operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<EnforcedGovernanceRuleSummary> ListEnforcedGovernanceRulesRecordEnumerator(ListEnforcedGovernanceRulesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListEnforcedGovernanceRulesRequest, ListEnforcedGovernanceRulesResponse, EnforcedGovernanceRuleSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListEnforcedGovernanceRules(request, retryConfiguration, cancellationToken),
                response => response.EnforcedGovernanceRuleCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListGovernanceRules operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListGovernanceRulesResponse> ListGovernanceRulesResponseEnumerator(ListGovernanceRulesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListGovernanceRulesRequest, ListGovernanceRulesResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListGovernanceRules(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the GovernanceRuleSummary objects
        /// contained in responses from the ListGovernanceRules operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<GovernanceRuleSummary> ListGovernanceRulesRecordEnumerator(ListGovernanceRulesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListGovernanceRulesRequest, ListGovernanceRulesResponse, GovernanceRuleSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListGovernanceRules(request, retryConfiguration, cancellationToken),
                response => response.GovernanceRuleCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListInclusionCriteria operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListInclusionCriteriaResponse> ListInclusionCriteriaResponseEnumerator(ListInclusionCriteriaRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListInclusionCriteriaRequest, ListInclusionCriteriaResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListInclusionCriteria(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the InclusionCriterionSummary objects
        /// contained in responses from the ListInclusionCriteria operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<InclusionCriterionSummary> ListInclusionCriteriaRecordEnumerator(ListInclusionCriteriaRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListInclusionCriteriaRequest, ListInclusionCriteriaResponse, InclusionCriterionSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListInclusionCriteria(request, retryConfiguration, cancellationToken),
                response => response.InclusionCriterionCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListTenancyAttachments operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListTenancyAttachmentsResponse> ListTenancyAttachmentsResponseEnumerator(ListTenancyAttachmentsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListTenancyAttachmentsRequest, ListTenancyAttachmentsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListTenancyAttachments(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the TenancyAttachmentSummary objects
        /// contained in responses from the ListTenancyAttachments operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<TenancyAttachmentSummary> ListTenancyAttachmentsRecordEnumerator(ListTenancyAttachmentsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListTenancyAttachmentsRequest, ListTenancyAttachmentsResponse, TenancyAttachmentSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListTenancyAttachments(request, retryConfiguration, cancellationToken),
                response => response.TenancyAttachmentCollection.Items
            );
        }

    }
}
