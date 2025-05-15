using System.Net;

namespace Autenticador.Exceptions;

public abstract class BaseException : SystemException
{
    public BaseException(string message) : base(message) { }
    public abstract HttpStatusCode GetStatusCode();
    public abstract IList<string> GetErrorMessages();
}
