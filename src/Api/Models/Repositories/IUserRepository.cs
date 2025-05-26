namespace Api.Models.Repositories;

public interface IUserRepository
{
    Task<UserEntity>? GetByEmail(string email);
    Task<UserEntity>? GetByName(string name);
}
