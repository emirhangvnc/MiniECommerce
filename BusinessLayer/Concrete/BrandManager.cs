using BusinessLayer.Abstract;
using BusinessLayer.Concrete.Base;
using CoreLayer.Results;
using DataLayer.Abstract;
using DataLayer.Concrete.Context;
using EntityLayer;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class BrandManager : ManagerBase, IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(ECommerceContext eCommerceContext, IBrandDal brandDal) : base(eCommerceContext)
        {
            _brandDal = brandDal;
        }
        public IDataResult<List<Brand>> GetAllBrand()
        {
            var result = _brandDal.GetAll();
            if (result == null)
                return new ErrorDataResult<List<Brand>>("Marka Bulunamadı");
            return new SuccessDataResult<List<Brand>>(result,"Markalar Listelendi");
        }

        public IDataResult<Brand> GetByBrandId(int id)
        {
            var result = _brandDal.Get(c => c.Id == id);
            if (result == null)
                return new ErrorDataResult<Brand>("Bu Id'de Marka bulunamadı");
            return new SuccessDataResult<Brand>(result);
        }

        public IDataResult<Brand> GetByBrandName(string brandName)
        {
            var result = _brandDal.Get(c => c.BrandName == brandName);
            if (result == null)
                return new ErrorDataResult<Brand>("Bu İsimde Marka bulunamadı");
            return new SuccessDataResult<Brand>(result);
        }
    }
}
