/*
 * Copyright (c) 2020, 2026, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System.Collections.Generic;
using System.Collections.ObjectModel;
using Oci.Common.Http.Signing.Internal;

namespace Oci.Common.Http.Signing
{
    /// <summary>Various signing strategies used by Oracle Cloud Infrastructure. ref: https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/signingrequests.htm</summary>
    public class SigningStrategy
    {
        /// <summary>Standard signing strategy.</summary>
        public static readonly SigningStrategy STANDARD = new SigningStrategy(Constants.REQUIRED_SIGNING_HEADERS, Constants.OPTIONAL_SIGNING_HEADERS);
        /// <summary>A signing strategy that does not sign the body.</summary>
        public static readonly SigningStrategy EXCLUDE_BODY = new SigningStrategy(Constants.REQUIRED_EXCLUDE_BODY_SIGNING_HEADERS, Constants.OPTIONAL_SIGNING_HEADERS);

        /// <summary>A Dictionary containing all the required headers to sign.</summary>
        public Dictionary<string, ReadOnlyCollection<string>> RequiredHeaders { get; set; }
        /// <summary>A Dictionary containing the headers to sign if they are set.</summary>
        public Dictionary<string, ReadOnlyCollection<string>> OptionalHeaders { get; set; }

        public static readonly string SIGNING_STRATEGY_PROPERTY_NAME_KEY = "oci-internal-signing-strategy-name";

        /// <summary>All pre-defined signing strategies.</summary>
        public static IEnumerable<SigningStrategy> Values
        {
            get
            {
                yield return STANDARD;
                yield return EXCLUDE_BODY;
            }
        }

        public SigningStrategy(Dictionary<string, ReadOnlyCollection<string>> requiredHeaders, Dictionary<string, ReadOnlyCollection<string>> optionalHeaders) =>
            (RequiredHeaders, OptionalHeaders) = (requiredHeaders, optionalHeaders);
    }
}
