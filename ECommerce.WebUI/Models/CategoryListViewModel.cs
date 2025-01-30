using ECommerce.Domain.Entites;

namespace ECommerce.WebUI.Models;

public class CategoryListViewModel
{
    public List<Category> Categories { get; set; } = [];
    public int CurrentCategory { get; set; }
}
