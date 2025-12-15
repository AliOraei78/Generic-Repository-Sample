using GenericRepositorySample.Domain;
using System.Collections.Generic;

public class ProductRepository
{
    private readonly List<Product> products = new List<Product>();

    public void Add(Product product) => products.Add(product);

    public List<Product> GetAll() => products;
}
