using DevKit.Common.Common.Result;

namespace DevKit.Common.Common.Errors;

public static class AuthErrors
{
    public static readonly Error InvalidCredentials =
        new("AUTH.INVALID_CREDENTIALS", "Credenciais inválidas.");

    public static readonly Error TokenExpired =
        new("AUTH.TOKEN_EXPIRED", "Token expirado.");

    public static readonly Error InvalidToken =
        new("AUTH.INVALID_TOKEN", "Token inválido.");
}
