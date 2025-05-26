using Api.Infra.DataAccess;
using Api.Services.Auth;
using Microsoft.EntityFrameworkCore;

namespace Api.DI;

public static class DependencyInjectionExtension
{
    public static void AddDI(this IServiceCollection services, IConfiguration configuration)
    {
        AddServices(services);
        AddDbContext(services, configuration);
    }

    public static void AddServices(IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
    }
    public static void AddDbContext(IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Default");

        services.AddDbContext<AutenticadorDbContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });
    }
}
