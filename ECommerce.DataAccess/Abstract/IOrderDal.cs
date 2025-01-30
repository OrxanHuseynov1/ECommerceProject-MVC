using ECommerce.Domain.Entites;
using ECommerce.Repository.DataAccess;

namespace ECommerce.DataAccess.Abstract;

public interface IOrderDal : IEntityRepository<Order>
{
}
