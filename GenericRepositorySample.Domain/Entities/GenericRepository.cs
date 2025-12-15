using GenericRepositorySample.Domain;
using System.Collections.Generic;
public class GenericRepository<T, TKey> : IRepository<T, TKey>
    where T : IEntity<TKey>
{
    private readonly List<T> _list = new List<T>();

    public void Add(T entity) => _list.Add(entity);

    public List<T> GetAll() => _list;  
}