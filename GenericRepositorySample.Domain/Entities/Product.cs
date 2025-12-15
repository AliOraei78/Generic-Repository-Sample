public class Product : IEntity<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; } =string.Empty;
}