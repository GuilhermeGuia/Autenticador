using Api.Exceptions;
using Api.Models.Request;

namespace Api.Services.Auth;

public class AuthService : IAuthService
{

    public async Task<string> ExecuteRegister(RegisterRequest request)
    {
        // criar logica para registro de usuarios no sistema

        if (string.IsNullOrWhiteSpace(request.Name))
            throw new RegisterException("Nome inválido.");

        if (string.IsNullOrWhiteSpace(request.Email))
            throw new RegisterException("Email inválido.");

        if (string.IsNullOrWhiteSpace(request.Password))
            throw new RegisterException("Senha inválida.");





        return "request";
    }

}
