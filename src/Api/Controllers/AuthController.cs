using Microsoft.AspNetCore.Identity.Data;
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
        //var result = service.ExecuteRegister(request);

        return Created(string.Empty, "AUTENTICADOR");
    }

    [HttpGet]
    //[ProducesResponseType(typeof(CreateUserInput), StatusCodes.Status201Created)]
    public IActionResult Login(
    )
    {
        return Ok("AUTENTICADOR");
    }
}
