using DevKit.Common.Common.Result;

namespace DevKit.Common.Common.Errors;

public static class UserErrors
{
    public static readonly Error EmailAlreadyExists =
        new("USER.EMAIL_EXISTS", "Email já cadastrado.");

    public static readonly Error UserNotFound =
        new("USER.NOT_FOUND", "Usuário não encontrado.");

    public static readonly Error UserInactive =
        new("USER.INACTIVE", "Usuário inativo.");
}
