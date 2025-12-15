using GenericRepositorySample.Domain;
using System.Collections.Generic;
public class GenericRepository<T, TKey> : IReadOnlyRepository<T>, IWriteRepository<T>
    where T : IEntity<TKey>
{
    private readonly List<T> _list = new List<T>();

    public void Add(T entity) => _list.Add(entity);

    public T GetById(int index) => _list[index];

    public IEnumerable<T> GetAll() => _list;  
}