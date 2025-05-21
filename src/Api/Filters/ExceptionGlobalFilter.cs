using Api.Exceptions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

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
        context.Result = new ObjectResult(castDesafioPicPayException.GetErrorMessages());
    }

    private void HandleUnknowException(ExceptionContext context)
    {
        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Result = new ObjectResult("Erro interno");
    }
}

