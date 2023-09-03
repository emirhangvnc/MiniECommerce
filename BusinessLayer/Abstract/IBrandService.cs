using CoreLayer.Results;
using EntityLayer;

namespace BusinessLayer.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAllBrand();
        IDataResult<Brand> GetByBrandId(int id);
        IDataResult<Brand> GetByBrandName(string brandName);
    }
}