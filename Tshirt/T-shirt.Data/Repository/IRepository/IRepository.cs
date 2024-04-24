namespace T_shirt.Data.Repository.IRepository
{

    using System.Linq.Expressions;

    public interface IRepository<T> where T : class
    {

        IEnumerable<T> GetAll(string? includeProperties = null);

        T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null);

        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null);

        void Add(T entity);

        void Remove(int id);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entity);

    }
}
