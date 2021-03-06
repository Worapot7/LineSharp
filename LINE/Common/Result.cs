﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace LineSharp
{
    [DefaultValue(OK)]
    public enum Result
    {
        PIN_TIMEOUT = -4,
        REQUIRES_PIN_VERIFICATION = -3,
        UNKNOWN_ERROR = -2,
        OK = -1,
        ILLEGAL_ARGUMENT = 0,
        AUTHENTICATION_FAILED = 1,
        DB_FAILED = 2,
        INVALID_STATE = 3,
        EXCESSIVE_ACCESS = 4,
        NOT_FOUND = 5,
        INVALID_LENGTH = 6,
        NOT_AVAILABLE_USER = 7,
        NOT_AUTHORIZED_DEVICE = 8,
        INVALID_MID = 9,
        NOT_A_MEMBER = 10,
        INCOMPATIBLE_APP_VERSION = 11,
        NOT_READY = 12,
        NOT_AVAILABLE_SESSION = 13,
        NOT_AUTHORIZED_SESSION = 14,
        SYSTEM_ERROR = 15,
        NO_AVAILABLE_VERIFICATION_METHOD = 16,
        NOT_AUTHENTICATED = 17,
        INVALID_IDENTITY_CREDENTIAL = 18,
        NOT_AVAILABLE_IDENTITY_IDENTIFIER = 19,
        INTERNAL_ERROR = 20,
        NO_SUCH_IDENTITY_IDENFIER = 21,
        DEACTIVATED_ACCOUNT_BOUND_TO_THIS_IDENTITY = 22,
        ILLEGAL_IDENTITY_CREDENTIAL = 23,
        UNKNOWN_CHANNEL = 24,
        NO_SUCH_MESSAGE_BOX = 25,
        NOT_AVAILABLE_MESSAGE_BOX = 26,
        CHANNEL_DOES_NOT_MATCH = 27,
        NOT_YOUR_MESSAGE = 28,
        MESSAGE_DEFINED_ERROR = 29,
        USER_CANNOT_ACCEPT_PRESENTS = 30,
        USER_NOT_STICKER_OWNER = 32,
        MAINTENANCE_ERROR = 33,
        ACCOUNT_NOT_MATCHED = 34,
        ABUSE_BLOCK = 35,
        NOT_FRIEND = 36,
        NOT_ALLOWED_CALL = 37,
        BLOCK_FRIEND = 38,
        INCOMPATIBLE_VOIP_VERSION = 39,
        INVALID_SNS_ACCESS_TOKEN = 40,
        EXTERNAL_SERVICE_NOT_AVAILABLE = 41,
        NOT_ALLOWED_ADD_CONTACT = 42,
        NOT_CERTIFICATED = 43,
        NOT_ALLOWED_SECONDARY_DEVICE = 44,
        INVALID_PIN_CODE = 45,
        NOT_FOUND_IDENTITY_CREDENTIAL = 46,
        EXCEED_FILE_MAX_SIZE = 47,
        EXCEED_DAILY_QUOTA = 48,
        NOT_SUPPORT_SEND_FILE = 49,
        MUST_UPGRADE = 50,
        NOT_AVAILABLE_PIN_CODE_SESSION = 51,
    }
}
