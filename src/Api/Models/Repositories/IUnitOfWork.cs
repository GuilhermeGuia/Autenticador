namespace Api.Models.Repositories;

public interface IUnitOfWork
{
    Task SaveChangesAsync();
}
