using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Product()
    {
        return Redirect("/product");
    }
    public IActionResult Customer()
    {
        return Redirect("/customer");
    }
    public IActionResult Employee()
    {
        return Redirect("/employee");
    }
    public IActionResult Order()
    {
        return Redirect("/order");
    }
    public IActionResult Supplier()
    {
        return Redirect("/Supplier");
    }


}
