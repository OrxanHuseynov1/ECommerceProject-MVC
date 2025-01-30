using ECommerce.Application.Abstract;
using ECommerce.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers;

public class CustomerController(ICustomerService customerService) : Controller
{
    private readonly ICustomerService _customerService = customerService;
    public IActionResult Index(int page = 1)
    {
        int pageSize = 10;
        var customers = _customerService.GetAll().ToList();
        var pagedCustomers = customers.Skip((page - 1) * pageSize).Take(pageSize).ToList();

        var model = new CustomerListViewModel
        {
            Customers = pagedCustomers, 
            PageCount = (int)Math.Ceiling((double)customers.Count / pageSize),
            PageSize = pageSize,
            CurrentPage = page,
        };
        return View(model);
    }
}
