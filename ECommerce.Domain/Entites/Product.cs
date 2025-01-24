using ECommerce.Domain.Abstract;

namespace ECommerce.Domain.Entites;

public class Product : IEntity
{
    public int ProductId { get; set; }
    public string? ProductName { get; set; }
    public int CategoryId { get; set; }
    public int UnitPrice { get; set; }
    public int UnitInStock { get; set; }
}
