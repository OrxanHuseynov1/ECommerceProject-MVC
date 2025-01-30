using ECommerce.Application.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.Domain.Entites;

namespace ECommerce.Application.Concrete;

public class SupplierService(ISupplierDal supplierDal) : ISupplierService
{
    private readonly ISupplierDal _supplierDal = supplierDal;
    public List<Supplier> GetAll()
    {
        return _supplierDal.GetList();
    }
}
