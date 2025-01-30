using ECommerce.Application.Abstract;
using ECommerce.Domain.Entites;
using ECommerce.DataAccess.Abstract;

namespace ECommerce.Application.Concrete;

public class CategoryService(ICategoryDal categoryDal ) : ICategoryService

{
    private readonly ICategoryDal _categoryDal = categoryDal;
    public List<Category> GetAll()
    {
        return _categoryDal.GetList();
    }
}
