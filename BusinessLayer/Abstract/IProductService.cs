using CoreLayer.Results;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAllProduct();
        IDataResult<Product> GetByProductId(int id);
    }
}