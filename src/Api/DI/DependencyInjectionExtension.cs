using Api.Services.Auth;

namespace Api.DI;

public static class DependencyInjectionExtension
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
    }
}
