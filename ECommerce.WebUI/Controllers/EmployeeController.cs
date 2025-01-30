using ECommerce.Application.Abstract;
using ECommerce.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
namespace ECommerce.WebUI.Controllers;

public class EmployeeController(IEmployeeService employeeService) : Controller
{
    private readonly IEmployeeService _employeeService= employeeService;
    public IActionResult Index(int page = 1)
    {
        int pageSize = 10;
        var employees = _employeeService.GetAll().ToList();
        var pagedEmployees = employees.Skip((page - 1) * pageSize).Take(pageSize).ToList();

        var model = new EmployeeListViewModel
        {
            Employees = pagedEmployees,
            PageCount = (int)Math.Ceiling((double)employees.Count / pageSize),
            PageSize = pageSize,
            CurrentPage = page,
        };
        return View(model);
    }
}
