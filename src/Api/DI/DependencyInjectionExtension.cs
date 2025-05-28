using Api.Infra.Crypto;
using Api.Infra.DataAccess;
using Api.Infra.DataAccess.Repositories;
using Api.Models.Repositories;
using Api.Services.Auth;
using Microsoft.EntityFrameworkCore;

namespace Api.DI;

public static class DependencyInjectionExtension
{
    public static void AddDI(this IServiceCollection services, IConfiguration configuration)
    {
        AddServices(services);
        AddRepositories(services);
        AddDbContext(services, configuration);
    }

    public static void AddServices(IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();

        services.AddScoped<Hasher>();
    }
    public static void AddDbContext(IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Default");

        services.AddDbContext<AutenticadorDbContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });
    }

    public static void AddRepositories(IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IAuthRepository, AuthRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
