public interface IRepository<T, TKey>
    where T : IEntity<TKey>
{
    void Add(T entity);
    List<T> GetAll();
}