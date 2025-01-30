using ECommerce.Application.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Concrete;

public class OrderService(IOrderDal orderDal) : IOrderService
{
    private readonly IOrderDal _orderDal = orderDal;
    public List<Order> GetAll()
    {
        return _orderDal.GetList();
    }

    //public List<Order> GetShipCountryName()
    //{
    //    return _orderDal.GetList().Where(o => o.ShipCountry)
    //}
}
