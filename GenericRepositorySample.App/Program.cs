using GenericRepositorySample.Domain;

public class Program
{
    public static void Main(string[] args)
    {
        var employeeRep = new GenericRepository<Employee, Guid>();
        var productRep = new GenericRepository<Product, int>();

        employeeRep.Add(
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "1st.Employee"
            });
        employeeRep.Add(
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "2nd.Employee"
            });

        productRep.Add(new Product() { 
            Id = 21221, 
            Name = "1st.Product" 
        });
        productRep.Add(new Product() { 
            Id = 111, 
            Name = "2nd.Product" 
        });

        var employees = employeeRep.GetAll();
        var products = productRep.GetAll();

        foreach (var employee in employees) 
        { 
            System.Console.WriteLine($"Employee id: {employee.Id} and the name= {employee.Name}");
            System.Console.WriteLine("----------");
        }
        foreach (var product in products) 
        { 
            System.Console.WriteLine($"Product id: {product.Id} and the name= {product.Name}");
            System.Console.WriteLine("----------");
        }
    }
}