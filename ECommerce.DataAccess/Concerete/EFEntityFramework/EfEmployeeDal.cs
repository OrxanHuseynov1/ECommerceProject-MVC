using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Context;
using ECommerce.Domain.Entites;
using ECommerce.Repository.DataAccess.EntityFrameworkAccess;

namespace ECommerce.DataAccess.Concerete.EFEntityFramework;

public class EfEmployeeDal : EFEntityRepositoryBase<Employee, NorthWindDbContext>, IEmployeeDal    
{
}
