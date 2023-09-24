using CoreLayer.Results;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IProductAndCategoryService
    {
        IDataResult<List<ProductAndCategory>> GetByCategoryId(int id);
    }
}
