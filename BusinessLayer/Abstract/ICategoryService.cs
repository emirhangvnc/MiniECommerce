using CoreLayer.Results;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAllCategory();
        IDataResult<Category> GetByCategoryId(int id);
    }
}
