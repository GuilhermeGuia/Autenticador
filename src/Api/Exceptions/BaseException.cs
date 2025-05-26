using System.Net;

namespace Api.Exceptions;
public abstract class BaseException(string message) : SystemException(message)
{
    public abstract HttpStatusCode GetStatusCode();
    public abstract string GetErrorMessage();
}
