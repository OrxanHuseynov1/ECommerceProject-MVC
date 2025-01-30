using ECommerce.Domain.Entites;

namespace ECommerce.WebUI.Models;

public class OrderListViewModel
{
    public List<Order> Orders { get; set; } = [];
    //public List<Order> ShipCountries { get; set; } = [];
    public int PageCount { get; set; }
    public int PageSize { get; set; }
    public int CurrentPage { get; set; }
}
