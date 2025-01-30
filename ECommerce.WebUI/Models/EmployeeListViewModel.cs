using ECommerce.Domain.Entites;

namespace ECommerce.WebUI.Models;

public class EmployeeListViewModel
{
    public List<Employee> Employees { get; set; } = [];
    public int PageCount { get; set; }
    public int PageSize { get; set; }
    public int CurrentPage { get; set; }
}
