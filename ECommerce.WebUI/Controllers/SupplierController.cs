using ECommerce.Application.Abstract;
using ECommerce.Application.Concrete;
using ECommerce.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
    public class SupplierController(ISupplierService supplierService) : Controller
    {
        private readonly ISupplierService _supplierService = supplierService;

        public IActionResult Index(int page = 1)
        {
            int pageSize = 10;
            var suppliers = _supplierService.GetAll().ToList();
            var pagedSuppliers = suppliers.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            var model = new SupplierListViewModel
            {
                Suppliers = pagedSuppliers,
                PageCount = (int)Math.Ceiling((double)suppliers.Count / pageSize),
                PageSize = pageSize,
                CurrentPage = page,
            };
            return View(model);
        }
    }
}
