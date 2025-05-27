
using Api.Models.Repositories;

namespace Api.Infra.DataAccess.Repositories;

public class UnitOfWork(AutenticadorDbContext dbContext) : IUnitOfWork
{
    public async Task SaveChangesAsync() => await dbContext.SaveChangesAsync();
}
