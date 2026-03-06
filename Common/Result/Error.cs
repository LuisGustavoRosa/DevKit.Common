namespace DevKit.Common.Common.Result;

public sealed class Error
{
    public string Code { get; }
    public string Message { get; }

    public static readonly Error None = new(string.Empty, string.Empty);

    public Error(string code, string message)
    {
        Code = code;
        Message = message;
    }
}
