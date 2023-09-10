using BusinessLayer.Abstract;
using BusinessLayer.Concrete.Base;
using CoreLayer.Results;
using DataLayer.Abstract;
using DataLayer.Concrete.Context;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ProductManager : ManagerBase, IProductService
    {
        IProductDal _productDal;
        public ProductManager(ECommerceContext eCommerceContext, IProductDal productDal) : base(eCommerceContext)
        {
            _productDal = productDal;
        }
        public IDataResult<List<Product>> GetAllProduct()
        {
            var result = _productDal.GetAll();
            if (result == null)
                return new ErrorDataResult<List<Product>>("Ürün Bulunamadı");
            return new SuccessDataResult<List<Product>>(result, "Ürünler Listelendi");
        }

        public IDataResult<Product> GetByProductId(int id)
        {
            var result = _productDal.Get(c => c.Id == id);
            if (result == null)
                return new ErrorDataResult<Product>("Bu Id'de Ürün bulunamadı");
            return new SuccessDataResult<Product>(result);
        }
    }
}
