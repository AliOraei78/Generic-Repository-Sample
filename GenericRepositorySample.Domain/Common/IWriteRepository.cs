public interface IWriteRepository<in T>
{
    void Add(T entity);
}