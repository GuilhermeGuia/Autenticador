using Api.Infra.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Api.Infra;

public static class DatabaseMigration
{
    public static void MigrateDatabase(IServiceProvider serviceProvider)
    {
        var migrator = serviceProvider.GetRequiredService<AutenticadorDbContext>();

        migrator.Database.Migrate();
    }
}
