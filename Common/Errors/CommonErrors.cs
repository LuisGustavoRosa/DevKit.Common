using DevKit.Common.Common.Result;

namespace DevKit.Common.Common.Errors;

public static class CommonErrors
{
    public static readonly Error NotFound =
        new("COMMON.NOT_FOUND", "Recurso não encontrado.");

    public static readonly Error ValidationError =
        new("COMMON.VALIDATION_ERROR", "Erro de validação.");

    public static readonly Error Unauthorized =
        new("COMMON.UNAUTHORIZED", "Usuário não autorizado.");
}
