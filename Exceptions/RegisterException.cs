using System.Net;

namespace Autenticador.Exceptions;

public class RegisterException : BaseException
{
    public RegisterException(string message) : base(message)
    {
            
    }

    public override IList<string> GetErrorMessages() => [Message];

    public override HttpStatusCode GetStatusCode() => HttpStatusCode.BadRequest;
}
