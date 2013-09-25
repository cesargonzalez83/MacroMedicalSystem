﻿namespace Macro.Common.Media.IMAPI2
{
    public enum IMAPI_MODE_PAGE_TYPE
    {
        IMAPI_MODE_PAGE_TYPE_READ_WRITE_ERROR_RECOVERY = 1,
        IMAPI_MODE_PAGE_TYPE_MRW = 3,
        IMAPI_MODE_PAGE_TYPE_WRITE_PARAMETERS = 5,
        IMAPI_MODE_PAGE_TYPE_CACHING = 8,
        IMAPI_MODE_PAGE_TYPE_POWER_CONDITION = 0x1a,
        IMAPI_MODE_PAGE_TYPE_TIMEOUT_AND_PROTECT = 0x1d,
        IMAPI_MODE_PAGE_TYPE_INFORMATIONAL_EXCEPTIONS = 0x1c,
        IMAPI_MODE_PAGE_TYPE_LEGACY_CAPABILITIES = 0x2a
    }
}