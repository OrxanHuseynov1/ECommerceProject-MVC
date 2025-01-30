using ECommerce.Application.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.Domain.Entites;

namespace ECommerce.Application.Concrete;

public class CustomerService(ICustomerDal customerDal) : ICustomerService
{
    private readonly ICustomerDal _customerDal = customerDal; 
    public List<Customer> GetAll()
    {
        return _customerDal.GetList();
    }
}
