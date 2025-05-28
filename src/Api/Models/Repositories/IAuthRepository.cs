namespace Api.Models.Repositories;

public interface IAuthRepository : IRepository<UserEntity>
{
    Task<UserEntity>? GetByEmail(string email);
    Task<UserEntity>? GetByName(string name);
    Task<bool> UserExists(string email);
}
