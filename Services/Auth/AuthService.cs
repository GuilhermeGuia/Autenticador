using Autenticador.Models.Request;

namespace Autenticador.Services.Auth;

public class AuthService : IAuthService
{

    public async Task<string> ExecuteRegister(RegisterRequest request)
    {
        // criar logica para registro de usuarios no sistema
        // validacao de dados!

        return "request";
    }

}
