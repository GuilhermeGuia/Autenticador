
using Api.Models.Request;

namespace Api.Services.Auth;

public interface IAuthService
{
    Task ExecuteRegister(RegisterRequest request);
    //void ExecuteLogin();
    //void ExecuteVerifyEmail();
    //void ExecuteResetPassword();
    //void ExecuteNewPassword();
}
