﻿namespace SereneViewSample.Administration
{
    public enum PasswordValidationResult
    {
        EmptyUsername,
        EmptyPassword,
        InactiveUser,
        UnknownSource,
        Throttle,
        DirectoryError,
        Invalid,
        Valid
    }
}