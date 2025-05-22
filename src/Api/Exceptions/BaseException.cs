using System.Net;

namespace Api.Exceptions;
public abstract class BaseException : SystemException
{
    public BaseException(string message) : base(message) { }
    public abstract HttpStatusCode GetStatusCode();
    public abstract string GetErrorMessage();
}
