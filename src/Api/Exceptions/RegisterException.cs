using System.Net;

namespace Api.Exceptions;

public class RegisterException(string message) : BaseException(message)
{
    public override string GetErrorMessage() => Message;
    public override HttpStatusCode GetStatusCode() => HttpStatusCode.BadRequest;
}
