using System.Xml.Linq;
using Api.Models;
using Api.Models.Repositories;

namespace Api.Infra.DataAccess.Repositories;

public class UserRepository(AutenticadorDbContext dbContext) : Repository<UserEntity>(dbContext), IUserRepository
{
    public async Task<UserEntity>? GetByEmail(string email) => await Find(x => x.Email == email);
    public async Task<UserEntity>? GetByName(string name) => await Find(x => x.Name == name);
    public async Task<bool> ValidateUserExists(string email) {

        var user = await Find(x => x.Email == email);

        return user == null;
    }
}
