using ECommerce.Domain.Entites;
using ECommerce.Repository.DataAccess;

namespace ECommerce.DataAccess.Abstract;

public interface IEmployeeDal : IEntityRepository<Employee>
{
}
