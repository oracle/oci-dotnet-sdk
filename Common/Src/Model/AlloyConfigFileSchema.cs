/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;

namespace Oci.Common.Model
{
    /**
    * Class representing AlloyConfigFileSchema blob that can be used for parsing out alloy regions, enabled services,
    * and the alloy provider name
    */
    public class AlloyConfigFileSchema
    {
        public List<RegionSchema> regions { get; set; }
        public List<string> services { get; set; }
        public string alloyProvider { get; set; }
        public string ociRegionCoexist { get; set; }
    }
}