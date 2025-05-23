using Api.Exceptions;
using Api.Models.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Api.Filters;

public class ExceptionGlobalFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is BaseException castDesafioPicPayException)
            HandleProjectException(castDesafioPicPayException, context);
        else
            HandleUnknowException(context);
    }

    private void HandleProjectException(BaseException castDesafioPicPayException, ExceptionContext context)
    {
        context.HttpContext.Response.StatusCode = (int)castDesafioPicPayException.GetStatusCode();
        context.Result = new ObjectResult(new BaseRequest<string>(castDesafioPicPayException.GetErrorMessage()));
    }

    private void HandleUnknowException(ExceptionContext context)
    {
        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Result = new ObjectResult(new BaseRequest<string>("Erro interno"));
    }
}

