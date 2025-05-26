using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Infra.DataAccess;

public class AutenticadorDbContext(DbContextOptions<AutenticadorDbContext> options) : DbContext(options)
{
    #region DBSETS
        public virtual DbSet<UserEntity> Users { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AutenticadorDbContext).Assembly);
    }
}
