using System.Linq.Expressions;

namespace Api.Models.Repositories;

public interface IRepository<T> where T : class
{
    Task<IList<T>> GetAll();
    Task<T?> Find(Expression<Func<T, bool>> predicate);
    Task<T?> GetById(long Id);
    Task Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}