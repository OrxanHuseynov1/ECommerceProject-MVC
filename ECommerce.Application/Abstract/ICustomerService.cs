using ECommerce.Domain.Entites;

namespace ECommerce.Application.Abstract;

public interface ICustomerService
{
    public List<Customer> GetAll();

}
