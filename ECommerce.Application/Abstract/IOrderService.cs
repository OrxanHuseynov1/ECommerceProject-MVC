using ECommerce.Domain.Entites;

namespace ECommerce.Application.Abstract;

public interface IOrderService
{
    public List<Order> GetAll();
    //public List<Order> GetShipCountryName();

}
