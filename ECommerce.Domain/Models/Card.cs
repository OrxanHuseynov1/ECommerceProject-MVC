namespace ECommerce.Domain.Models;

public class Card
{
    public List<CartLine> CartLines { get; set; }

    public Card()
    {
        CartLines = [];
    }

    public decimal Total => CartLines.Sum(c =>  ( c.Product!.UnitPrice ?? 0) * c.Quantity);
}
