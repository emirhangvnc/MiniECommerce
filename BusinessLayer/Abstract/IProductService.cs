using CoreLayer.Results;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ProductDto;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAllProduct();
        IDataResult<Product> GetByProductId(int id);

        IDataResult<List<ProductCategoryDetailsDto>> GetProductsByCategoryId(int categoryId);

        IDataResult<ProductDetailsDto> ProducDetailByUrl(string url);
    }
}