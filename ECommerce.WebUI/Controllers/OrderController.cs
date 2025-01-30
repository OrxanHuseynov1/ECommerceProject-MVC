using ECommerce.Application.Abstract;
using ECommerce.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers;

public class OrderController(IOrderService orderService) : Controller
{
    private readonly IOrderService _orderService = orderService;
    public IActionResult Index(int page = 1)
    {
        int pageSize = 10;
        var orders = _orderService.GetAll().ToList();
        var pagedOrders = orders.Skip((page - 1) * pageSize).Take(pageSize).ToList();

        var model = new OrderListViewModel
        {
            Orders = pagedOrders,
            PageCount = (int)Math.Ceiling((double)orders.Count / pageSize),
            PageSize = pageSize,
            CurrentPage = page,
        };
        return View(model);
    }
}
