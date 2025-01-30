using ECommerce.Application.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Concerete.EFEntityFramework;
using ECommerce.Domain.Entites;

namespace ECommerce.Application.Concrete;

public class EmployeeService(IEmployeeDal employeeDal) : IEmployeeService
{
    private readonly IEmployeeDal _employeeDal = employeeDal;
    public List<Employee> GetAll()
    {
        return _employeeDal.GetList();
    }
}
