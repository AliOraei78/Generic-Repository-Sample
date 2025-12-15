public interface IReadOnlyRepository<out T>
{
    T GetById(int index);
    IEnumerable<T> GetAll();
}