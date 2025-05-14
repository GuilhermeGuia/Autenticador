using Autenticador.Models.Request;

namespace Autenticador.Services.Auth;

public interface IAuthService
{
    Task<string> ExecuteRegister(RegisterRequest request);
    //void ExecuteLogin();
    //void ExecuteVerifyEmail();
    //void ExecuteResetPassword();
    //void ExecuteNewPassword();
}
