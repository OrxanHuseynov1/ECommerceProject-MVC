using ECommerce.Domain.Entites;

namespace ECommerce.Application.Abstract;

public interface ICategoryService   
{
    public List<Category> GetAll();
}
