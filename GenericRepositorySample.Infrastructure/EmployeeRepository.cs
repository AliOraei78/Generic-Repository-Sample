using GenericRepositorySample.Domain;
using System.Collections.Generic;
public class EmployeeRepository
{
    private readonly List<Employee> _employees = new List<Employee>();

    public void Add(Employee employee) => _employees.Add(employee);

    public List<Employee> GetAll() => _employees;
}