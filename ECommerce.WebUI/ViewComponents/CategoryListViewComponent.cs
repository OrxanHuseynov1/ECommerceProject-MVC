using ECommerce.Application.Abstract;
using ECommerce.WebUI.Models;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.ViewComponents;

public class CategoryListViewComponent(ICategoryService categoryService) : ViewComponent
{
    private readonly ICategoryService _categoryService = categoryService;

    public ViewViewComponentResult Invoke()
    {
        var model = new CategoryListViewModel
        {
            Categories = _categoryService.GetAll()
        };
        return View(model);
    }
}
