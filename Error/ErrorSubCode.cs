﻿namespace Goova.Suscriptions.Models.Error
{
    public enum ErrorSubCode
    {
        Ok = 0,
        UnknownError = 100,
        ConnectionError = 101,
        ArgumentError = 600,

        CredentialsError = 700,
    }
}
