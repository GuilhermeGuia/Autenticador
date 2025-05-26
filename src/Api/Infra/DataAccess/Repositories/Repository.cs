using System.Linq.Expressions;
using Api.Models.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Api.Infra.DataAccess.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly AutenticadorDbContext _dbContext;
    private readonly DbSet<T> _dbSet;
    public Repository(AutenticadorDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = dbContext.Set<T>();
    }

    public async Task Add(T entity) => await _dbSet.AddAsync(entity);
    public void Delete(T entity) => _dbSet.Remove(entity);
    public async Task<T?> Find(Expression<Func<T, bool>> predicate) => await _dbSet.Where(predicate).FirstOrDefaultAsync();
    public async Task<IList<T>> GetAll() => await _dbSet.ToListAsync();
    public async Task<T?> GetById(long Id) => await _dbSet.FindAsync(Id);
    public void Update(T entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        _dbSet.Update(entity);
    }
}
