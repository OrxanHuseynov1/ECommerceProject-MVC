using ECommerce.Application.Abstract;
using ECommerce.Application.Concrete;
using ECommerce.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace ECommerce.WebUI.ViewComponents;

public class OrderListViewComponent(IOrderService orderService) : ViewComponent
{
    private readonly IOrderService _orderService = orderService;

    public ViewViewComponentResult Invoke()
    {
        var orders = _orderService.GetAll();
        var groupedOrders = orders.GroupBy(order => order.ShipCountry);

        return View(groupedOrders);
    }
}
