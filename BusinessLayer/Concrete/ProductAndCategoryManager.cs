using BusinessLayer.Abstract;
using BusinessLayer.Concrete.Base;
using CoreLayer.Results;
using DataLayer.Abstract;
using DataLayer.Concrete;
using DataLayer.Concrete.Context;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ProductAndCategoryManager : ManagerBase, IProductAndCategoryService
    {
        IProductAndCategoryDal _productAndCategoryDal;
        public ProductAndCategoryManager(ECommerceContext eCommerceContext, IProductAndCategoryDal productAndCategoryDal) : base(eCommerceContext)
        {
            _productAndCategoryDal = productAndCategoryDal;
        }

        public IDataResult<List<ProductAndCategory>> GetByCategoryId(int id)
        {
            var result = _productAndCategoryDal.GetAll(c => c.CategoryId == id);
            if (result == null)
                return new ErrorDataResult<List<ProductAndCategory>>("Bu Id'de Kategori bulunamadı");

            return new SuccessDataResult<List<ProductAndCategory>>(result);
        }
    }
}
