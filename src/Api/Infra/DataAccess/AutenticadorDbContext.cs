using Microsoft.EntityFrameworkCore;

namespace Api.Infra.DataAccess;

public class AutenticadorDbContext : DbContext
{
    public AutenticadorDbContext(DbContextOptions<AutenticadorDbContext> options) : base(options) { }
    #region DBSETS
        


    #endregion
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AutenticadorDbContext).Assembly);
    }
}
