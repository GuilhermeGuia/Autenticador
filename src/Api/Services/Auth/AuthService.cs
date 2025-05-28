using Api.Exceptions;
using Api.Infra.Crypto;
using Api.Models;
using Api.Models.Repositories;
using Api.Models.Request;

namespace Api.Services.Auth;

public class AuthService(IAuthRepository authRepository, Hasher hasher, IUnitOfWork unitOfWork) : IAuthService
{
    public async Task ExecuteRegister(RegisterRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name))
            throw new RegisterException("Nome inválido.");

        if (string.IsNullOrWhiteSpace(request.Email))
            throw new RegisterException("Email inválido.");

        if (string.IsNullOrWhiteSpace(request.Password))
            throw new RegisterException("Senha inválida.");

        if (await authRepository.UserExists(request.Email))
            throw new RegisterException("Email já cadastrado no sistema.");

        // fazer crypto da senha
        var password = hasher.Encrypt(request.Password);

        var user = new UserEntity(request.Name, request.Email, password);

        await authRepository.Add(user);

        await unitOfWork.SaveChangesAsync();

        // enviar notificação via email pro cara


    }
}
