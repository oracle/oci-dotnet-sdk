/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

namespace Oci.Common
{
    /// <summary>
    /// Class containing all of the known Regions that can be contacted.
    /// <br/>
    /// Note, not all services may be available in all regions.
    /// </summary>
    public partial class Region
    {
        // OC1
        public static readonly Region AP_CHUNCHEON_1 = Register("ap-chuncheon-1", Realm.OC1, "yny");
        public static readonly Region AP_HYDERABAD_1 = Register("ap-hyderabad-1", Realm.OC1, "hyd");
        public static readonly Region AP_MELBOURNE_1 = Register("ap-melbourne-1", Realm.OC1, "mel");
        public static readonly Region AP_MUMBAI_1 = Register("ap-mumbai-1", Realm.OC1, "bom");
        public static readonly Region AP_OSAKA_1 = Register("ap-osaka-1", Realm.OC1, "kix");
        public static readonly Region AP_SEOUL_1 = Register("ap-seoul-1", Realm.OC1, "icn");
        public static readonly Region AP_SYDNEY_1 = Register("ap-sydney-1", Realm.OC1, "syd");
        public static readonly Region AP_TOKYO_1 = Register("ap-tokyo-1", Realm.OC1, "nrt");
        public static readonly Region CA_MONTREAL_1 = Register("ca-montreal-1", Realm.OC1, "yul");
        public static readonly Region CA_TORONTO_1 = Register("ca-toronto-1", Realm.OC1, "yyz");
        public static readonly Region EU_AMSTERDAM_1 = Register("eu-amsterdam-1", Realm.OC1, "ams");
        public static readonly Region EU_FRANKFURT_1 = Register("eu-frankfurt-1", Realm.OC1, "fra");
        public static readonly Region EU_ZURICH_1 = Register("eu-zurich-1", Realm.OC1, "zrh");
        public static readonly Region ME_JEDDAH_1 = Register("me-jeddah-1", Realm.OC1, "jed");
        public static readonly Region SA_SAOPAULO_1 = Register("sa-saopaulo-1", Realm.OC1, "gru");
        public static readonly Region UK_LONDON_1 = Register("uk-london-1", Realm.OC1, "lhr");
        public static readonly Region US_ASHBURN_1 = Register("us-ashburn-1", Realm.OC1, "iad");
        public static readonly Region US_PHOENIX_1 = Register("us-phoenix-1", Realm.OC1, "phx");
        public static readonly Region US_SANJOSE_1 = Register("us-sanjose-1", Realm.OC1, "sjc");
        public static readonly Region ME_DUBAI_1 = Register("me-dubai-1", Realm.OC1, "dxb");
        public static readonly Region UK_CARDIFF_1 = Register("uk-cardiff-1", Realm.OC1, "cwl");
        public static readonly Region SA_SANTIAGO_1 = Register("sa-santiago-1", Realm.OC1, "scl");
        public static readonly Region SA_VINHEDO_1 = Register("sa-vinhedo-1", Realm.OC1, "vcp");
        public static readonly Region IL_JERUSALEM_1 = Register("il-jerusalem-1", Realm.OC1, "mtz");
        public static readonly Region EU_MARSEILLE_1 = Register("eu-marseille-1", Realm.OC1, "mrs");
        public static readonly Region AP_SINGAPORE_1 = Register("ap-singapore-1", Realm.OC1, "sin");
        public static readonly Region ME_ABUDHABI_1 = Register("me-abudhabi-1", Realm.OC1, "auh");
        public static readonly Region EU_MILAN_1 = Register("eu-milan-1", Realm.OC1, "lin");
        public static readonly Region EU_STOCKHOLM_1 = Register("eu-stockholm-1", Realm.OC1, "arn");
        public static readonly Region AF_JOHANNESBURG_1 = Register("af-johannesburg-1", Realm.OC1, "jnb");
        public static readonly Region EU_PARIS_1 = Register("eu-paris-1", Realm.OC1, "cdg");
        public static readonly Region MX_QUERETARO_1 = Register("mx-queretaro-1", Realm.OC1, "qro");
        public static readonly Region EU_MADRID_1 = Register("eu-madrid-1", Realm.OC1, "mad");
        public static readonly Region US_CHICAGO_1 = Register("us-chicago-1", Realm.OC1, "ord");
        public static readonly Region MX_MONTERREY_1 = Register("mx-monterrey-1", Realm.OC1, "mty");
        public static readonly Region US_SALTLAKE_2 = Register("us-saltlake-2", Realm.OC1, "aga");
        public static readonly Region SA_BOGOTA_1 = Register("sa-bogota-1", Realm.OC1, "bog");
        public static readonly Region SA_VALPARAISO_1 = Register("sa-valparaiso-1", Realm.OC1, "vap");
        public static readonly Region AP_SINGAPORE_2 = Register("ap-singapore-2", Realm.OC1, "xsp");
        public static readonly Region ME_RIYADH_1 = Register("me-riyadh-1", Realm.OC1, "ruh");
        public static readonly Region AP_BATAM_1 = Register("ap-batam-1", Realm.OC1, "hsg");
        public static readonly Region US_DALLAS_1 = Register("us-dallas-1", Realm.OC1, "dfw");
        public static readonly Region US_ABILENE_1 = Register("us-abilene-1", Realm.OC1, "abl");

        // OC2
        public static readonly Region US_LANGLEY_1 = Register("us-langley-1", Realm.OC2, "lfi");
        public static readonly Region US_LUKE_1 = Register("us-luke-1", Realm.OC2, "luf");

        // OC3
        public static readonly Region US_GOV_ASHBURN_1 = Register("us-gov-ashburn-1", Realm.OC3, "ric");
        public static readonly Region US_GOV_CHICAGO_1 = Register("us-gov-chicago-1", Realm.OC3, "pia");
        public static readonly Region US_GOV_PHOENIX_1 = Register("us-gov-phoenix-1", Realm.OC3, "tus");

        // OC4
        public static readonly Region UK_GOV_LONDON_1 = Register("uk-gov-london-1", Realm.OC4, "ltn");
        public static readonly Region UK_GOV_CARDIFF_1 = Register("uk-gov-cardiff-1", Realm.OC4, "brs");

        // OC8
        public static readonly Region AP_CHIYODA_1 = Register("ap-chiyoda-1", Realm.OC8, "nja");
        public static readonly Region AP_IBARAKI_1 = Register("ap-ibaraki-1", Realm.OC8, "ukb");

        // OC9
        public static readonly Region ME_DCC_MUSCAT_1 = Register("me-dcc-muscat-1", Realm.OC9, "mct");

        // OC10
        public static readonly Region AP_DCC_CANBERRA_1 = Register("ap-dcc-canberra-1", Realm.OC10, "wga");

        // OC14
        public static readonly Region EU_DCC_MILAN_1 = Register("eu-dcc-milan-1", Realm.OC14, "bgy");
        public static readonly Region EU_DCC_MILAN_2 = Register("eu-dcc-milan-2", Realm.OC14, "mxp");
        public static readonly Region EU_DCC_DUBLIN_2 = Register("eu-dcc-dublin-2", Realm.OC14, "snn");
        public static readonly Region EU_DCC_RATING_2 = Register("eu-dcc-rating-2", Realm.OC14, "dtm");
        public static readonly Region EU_DCC_RATING_1 = Register("eu-dcc-rating-1", Realm.OC14, "dus");
        public static readonly Region EU_DCC_DUBLIN_1 = Register("eu-dcc-dublin-1", Realm.OC14, "ork");

        // OC15
        public static readonly Region AP_DCC_GAZIPUR_1 = Register("ap-dcc-gazipur-1", Realm.OC15, "dac");

        // OC19
        public static readonly Region EU_MADRID_2 = Register("eu-madrid-2", Realm.OC19, "vll");
        public static readonly Region EU_FRANKFURT_2 = Register("eu-frankfurt-2", Realm.OC19, "str");

        // OC20
        public static readonly Region EU_JOVANOVAC_1 = Register("eu-jovanovac-1", Realm.OC20, "beg");

        // OC21
        public static readonly Region ME_DCC_DOHA_1 = Register("me-dcc-doha-1", Realm.OC21, "doh");

        // OC23
        public static readonly Region US_SOMERSET_1 = Register("us-somerset-1", Realm.OC23, "ebb");
        public static readonly Region US_THAMES_1 = Register("us-thames-1", Realm.OC23, "ebl");

        // OC24
        public static readonly Region EU_DCC_ZURICH_1 = Register("eu-dcc-zurich-1", Realm.OC24, "avz");
        public static readonly Region EU_CRISSIER_1 = Register("eu-crissier-1", Realm.OC24, "avf");

        // OC26
        public static readonly Region ME_ABUDHABI_3 = Register("me-abudhabi-3", Realm.OC26, "ahu");
        public static readonly Region ME_ALAIN_1 = Register("me-alain-1", Realm.OC26, "rba");

        // OC29
        public static readonly Region ME_ABUDHABI_2 = Register("me-abudhabi-2", Realm.OC29, "rkt");
        public static readonly Region ME_ABUDHABI_4 = Register("me-abudhabi-4", Realm.OC29, "shj");

        // OC35
        public static readonly Region AP_SEOUL_2 = Register("ap-seoul-2", Realm.OC35, "dtz");
        public static readonly Region AP_SUWON_1 = Register("ap-suwon-1", Realm.OC35, "dln");
        public static readonly Region AP_CHUNCHEON_2 = Register("ap-chuncheon-2", Realm.OC35, "bno");
    }
}