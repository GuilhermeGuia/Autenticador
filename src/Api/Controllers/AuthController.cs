using Api.Exceptions;
using Api.Models.Request;
using Api.Services.Auth;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    [HttpPost]
    //[ProducesResponseType(typeof(CreateUserInput), StatusCodes.Status201Created)]
    public async Task<IActionResult> Register(
        [FromServices] IAuthService service,
        RegisterRequest request
    )
    {
        await service.ExecuteRegister(request);

        return Created();
    }
}
