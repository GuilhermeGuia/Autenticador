using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("/")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet()]
        public string Get()
        {
            return "rodando api";
        }
    }
}
