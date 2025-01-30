using ECommerce.Domain.Entites;

namespace ECommerce.Application.Abstract;

public interface IEmployeeService
{
    public List<Employee> GetAll();

}
