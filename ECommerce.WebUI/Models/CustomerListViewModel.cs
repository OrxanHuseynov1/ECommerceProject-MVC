using ECommerce.Domain.Entites;

namespace ECommerce.WebUI.Models;

public class CustomerListViewModel
{
    public List<Customer> Customers { get; set; } = [];
    public int PageCount { get; set; }
    public int PageSize { get; set; }
    public int CurrentPage { get; set; }
}
